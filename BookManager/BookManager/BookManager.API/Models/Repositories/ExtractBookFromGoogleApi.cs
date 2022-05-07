using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using BookManager.API.Data;
using BookManager.API.Models.Interfaces;
using Newtonsoft.Json;
using BookManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManager.API.Models.Repositories
{
    public class ExtractBookFromGoogleApi : IExtractBookFromGoogleApi
    {
        private readonly ApplicationDbContext _context;
        private readonly IidentifierInterface _iidentifierInterface;
        private readonly IBookRepositoryInterface _bookRepositoryInterface;
        private readonly IItemInterface _itemInterface;
        public ExtractBookFromGoogleApi(ApplicationDbContext context,
            IidentifierInterface _iidentifierInterface,
            IBookRepositoryInterface books,
            IItemInterface itemInterface)
        {
            this._context = context;
            this._iidentifierInterface = _iidentifierInterface;
            this._bookRepositoryInterface = books;
            this._itemInterface = itemInterface;
        }
        
        public async Task<ExtractBookResponse> ExtractBooksFromLink(string Link)
        {
            try
            {
                Link = $"https://www.googleapis.com/books/v1/volumes?q={Link}";
                string finalHtml = default;
                using (WebClient client = new WebClient())
                {
                    client.Encoding = System.Text.Encoding.UTF8;
                    var doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(client.DownloadString(Link));
                    foreach (var href in doc.DocumentNode.Descendants("a").Select(x => x.Attributes["href"]))
                    {
                        if (href == null) continue;
                        href.Value = "http://ahmadalli.somee.com/default.aspx?url=" + HttpUtility.UrlEncode(href.Value);
                    }
                    StringWriter writer = new StringWriter();
                    doc.Save(writer);
                    finalHtml = writer.ToString();
                }

                // string Json = File.ReadAllText();
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(finalHtml);
                foreach (Item item in myDeserializedClass.items)
                {
                    var newVolume = new Book()
                    {
                        Titolo = item.volumeInfo.title,
                        ContentVersion = item.volumeInfo.contentVersion,
                        PageCount = item.volumeInfo.pageCount,
                        Description = item.volumeInfo.description?.ToString(),
                        ImageLink = item.volumeInfo.imageLinks.thumbnail,
                        Language = item.volumeInfo.language,
                        MaturityRating = item.volumeInfo.maturityRating,
                        PublishDate = item.volumeInfo.publishedDate?.ToString(),
                        Publisher = item.volumeInfo.publisher?.ToString(),
                        ////////
                    };
                    var isBook = await _context.Books.FirstOrDefaultAsync(x => x.Titolo == newVolume.Titolo);
                    if (isBook is null)
                    {
                        await _context.Books.AddAsync(newVolume);
                        await _context.SaveChangesAsync();
                        var NewIdentifier = new Identifiers();
                        var newAuthor = new Author();
                        var newCat = new Categories();
                        foreach (var identifier in item.volumeInfo.industryIdentifiers)
                        {
                            NewIdentifier = new Identifiers()
                            {
                                BookId = newVolume.Id,
                                Indentifier = identifier.identifier,
                                Type = identifier.type
                            };
                            await _context.AddAsync(NewIdentifier);
                            await _context.SaveChangesAsync();
                        }
                        foreach (var author in item.volumeInfo.authors)
                        {
                            newAuthor = new Author()
                            {
                                BookId = newVolume.Id,
                                AuthorName = author,
                            };
                            await _context.AddAsync(newAuthor);
                            await _context.SaveChangesAsync();
                        }
                        try
                        {
                            foreach (var category in item.volumeInfo.categories)
                            {
                                newCat = new Categories()
                                {
                                    BookId = newVolume.Id,
                                    CategoryName = category,
                                };
                                await _context.AddAsync(newCat);
                                await _context.SaveChangesAsync();
                            }
                        }
                        catch (Exception)
                        {
                            return null;
                        }
                        
                        await _itemInterface.AddItem(new BookManager.Models.Item()
                        {
                            BookId = newVolume.Id,
                            ItemDiscussionList = null,
                            ItemReviewList = null
                        });
                    }
                       
                   
                }

                List<string> ExtractedTitleBooks = new List<string>();
                ExtractedTitleBooks = myDeserializedClass.items.Select(x => x.volumeInfo.title).ToList();
                return new ExtractBookResponse()
                {
                    Succes = true,
                    ExtractedCount = myDeserializedClass.items.Count,
                    Message = "Libri estratti",
                    TitlesOfExtractedBooks = ExtractedTitleBooks
                };
            }
            catch (Exception)
            {
                return null;
            }
        }
        public class ExtractBookResponse
        {
            public bool Succes { get; set; }
            public string Message { get; set; }
            public int ExtractedCount { get; set; }
            public List<string> TitlesOfExtractedBooks { get; set; }
        }


        public class IndustryIdentifier
        {
            public string type { get; set; }
            public string identifier { get; set; }
        }

        public class ReadingModes
        {
            public bool text { get; set; }
            public bool image { get; set; }
        }

        public class PanelizationSummary
        {
            public bool containsEpubBubbles { get; set; }
            public bool containsImageBubbles { get; set; }
        }

        public class ImageLinks
        {
            public string smallThumbnail { get; set; }
            public string thumbnail { get; set; }
        }

        public class VolumeInfo
        {
            public string title { get; set; }
            public List<string> authors { get; set; }
            public string publisher { get; set; }
            public object publishedDate { get; set; }
            public string description { get; set; }
            public List<IndustryIdentifier> industryIdentifiers { get; set; }
            public ReadingModes readingModes { get; set; }
            public int pageCount { get; set; }
            public string printType { get; set; }
            public List<string> categories { get; set; }
            public string maturityRating { get; set; }
            public bool allowAnonLogging { get; set; }
            public string contentVersion { get; set; }
            public PanelizationSummary panelizationSummary { get; set; }
            public ImageLinks imageLinks { get; set; }
            public string language { get; set; }
            public string previewLink { get; set; }
            public string infoLink { get; set; }
            public string canonicalVolumeLink { get; set; }
            public string subtitle { get; set; }
        }

        public class ListPrice
        {
            public double amount { get; set; }
            public string currencyCode { get; set; }
            public int amountInMicros { get; set; }
        }

        public class RetailPrice
        {
            public double amount { get; set; }
            public string currencyCode { get; set; }
            public int amountInMicros { get; set; }
        }

        public class Offer
        {
            public int finskyOfferType { get; set; }
            public ListPrice listPrice { get; set; }
            public RetailPrice retailPrice { get; set; }
        }

        public class SaleInfo
        {
            public string country { get; set; }
            public string saleability { get; set; }
            public bool isEbook { get; set; }
            public ListPrice listPrice { get; set; }
            public RetailPrice retailPrice { get; set; }
            public string buyLink { get; set; }
            public List<Offer> offers { get; set; }
        }

        public class Epub
        {
            public bool isAvailable { get; set; }
            public string acsTokenLink { get; set; }
        }

        public class Pdf
        {
            public bool isAvailable { get; set; }
            public string acsTokenLink { get; set; }
        }

        public class AccessInfo
        {
            public string country { get; set; }
            public string viewability { get; set; }
            public bool embeddable { get; set; }
            public bool publicDomain { get; set; }
            public string textToSpeechPermission { get; set; }
            public Epub epub { get; set; }
            public Pdf pdf { get; set; }
            public string webReaderLink { get; set; }
            public string accessViewStatus { get; set; }
            public bool quoteSharingAllowed { get; set; }
        }

        public class SearchInfo
        {
            public string textSnippet { get; set; }
        }

        public class Item
        {
            public string kind { get; set; }
            public string id { get; set; }
            public string etag { get; set; }
            public string selfLink { get; set; }
            public VolumeInfo volumeInfo { get; set; }
            public SaleInfo saleInfo { get; set; }
            public AccessInfo accessInfo { get; set; }
            public SearchInfo searchInfo { get; set; }
        }

        public class Root
        {
            public string kind { get; set; }
            public int totalItems { get; set; }
            public List<Item> items { get; set; }
        }
    }
}
