using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Assignment04.Part01
{
    internal class Book
    {
        public Book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price {  get; set; }
        public override string ToString()
        {
            return $"ISBN: {ISBN}\nTitle: {Title}\nAuthor: {Authors}\n" +
                $"Publication Date: {PublicationDate}\nPrice: {Price}";
        }


    }
}
