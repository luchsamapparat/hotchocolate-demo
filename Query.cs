using System;
using System.Collections.Generic;

namespace Demo
{
    public class Query
    {
        public Book GetBook() =>
            new Book
            {
                Title = "C# in depth.",
                Authors = new List<Author> {
                    new Author {
                        Name = "Jon Skeet"
                    }
                }
            };
    }
}