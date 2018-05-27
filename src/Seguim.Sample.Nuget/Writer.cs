﻿using System;
using Seguim.Sample.Nuget.Domain;

namespace Seguim.Sample.Nuget {
    public class Writer {
        public Writer (Author author) {
            this.Author = author ?? throw new ArgumentNullException(nameof(author));
        }
        public Author Author { get; }

        public void Write (string message) {
            Console.WriteLine($"Message: {message}");
            Console.WriteLine();
            Console.WriteLine($"Author: {Author}");
        }
    }
}