using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Cart
    {

        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem (Book boo, int qty)
        {
            CartLine line = Lines
                .Where(b => b.Book.BookId == boo.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = boo,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty; 
            }
        }

        public virtual void RemoveLine(Book boo) =>
            Lines.RemoveAll(x => x.Book.BookId == boo.BookId);

        public virtual void Clear() => Lines.Clear();

        //MIGHT NEED TO GO BACK TO VID 10 TO FIX THIS
        public decimal ComputeTotalSum() => (decimal)Lines.Sum(e => e.Book.Price * e.Quantity);
        

        public class CartLine
        {
            public int CartLineId { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }

    }
}
