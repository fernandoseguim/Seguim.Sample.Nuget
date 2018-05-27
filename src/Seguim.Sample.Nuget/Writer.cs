using System;

namespace Seguim.Sample.Nuget {
    public class Writer {
        public Writer (string author) {
            this.Author = author ?? throw new ArgumentNullException(nameof(author));
        }
        public string Author { get; }

        public void Write (string message) {
            Console.WriteLine($"Message: {message}");
            Console.WriteLine();
            Console.WriteLine($"Author: {Author}");
        }
    }
}