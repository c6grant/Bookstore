﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            ProjectDBContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<ProjectDBContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorMiddle = "",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95m,
                        PageNum = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris",
                        AuthorMiddle = "Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58m,
                        PageNum = 944

                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorMiddle = "",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54m,
                        PageNum = 832

                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        AuthorMiddle = "C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61m,
                        PageNum = 864

                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorMiddle = "",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33m,
                        PageNum = 528

                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorMiddle = "",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95m,
                        PageNum = 288

                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorMiddle = "",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99m,
                        PageNum = 304

                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorMiddle = "",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66m,
                        PageNum = 240

                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorMiddle = "",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16m,
                        PageNum = 400

                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorMiddle = "",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03m,
                        PageNum = 642

                    },

                    new Book
                    {
                        Title = "Enders Game",
                        AuthorFirst = "Orson",
                        AuthorMiddle = "Scott",
                        AuthorLast = "Card",
                        Publisher = "Tor Books",
                        ISBN = "978-0765370624",
                        Classification = "Fiction",
                        Category = "Science Fiction",
                        Price = 7.99m,
                        PageNum = 324

                    },

                    new Book
                    {
                        Title = "The Hunger Games",
                        AuthorFirst = "Suzanne",
                        AuthorMiddle = "",
                        AuthorLast = "Collins",
                        Publisher = "Scholastic Corporation",
                        ISBN = "978-0439023481",
                        Classification = "Adventure",
                        Category = "Science Fiction",
                        Price = 10.00m,
                        PageNum = 374

                    },

                    new Book
                    {
                        Title = "Harry Potter and the Order of the Phoenix",
                        AuthorFirst = "J.",
                        AuthorMiddle = "K.",
                        AuthorLast = "Rowling",
                        Publisher = "Bloomsbury",
                        ISBN = "978-0747551003",
                        Classification = "Fantasy",
                        Category = "Fantasy",
                        Price = 15.00m,
                        PageNum = 870

                    }








                    );

                context.SaveChanges();
            }

        }
    }
}
