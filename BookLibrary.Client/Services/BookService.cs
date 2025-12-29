using BookLibrary.Client.Models;

namespace BookLibrary.Client.Services
{
    public class BookService
    {
        private List<Book> books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "Władca Pierścieni: Drużyna Pierścienia",
                Author = "J.R.R. Tolkien",
                Genre = "Fantasy",
                Year = 1954,
                Description = "Epicka opowieść o wyprawie w celu zniszczenia potężnego pierścienia.",
                CoverUrl = "/images/covers/book-1.jpg"
            },
            new Book
            {
                Id = 2,
                Title = "Harry Potter i Kamień Filozoficzny",
                Author = "J.K. Rowling",
                Genre = "Fantasy",
                Year = 1997,
                Description = "Historia młodego czarodzieja rozpoczynającego naukę w Hogwarcie.",
                CoverUrl = "/images/covers/book-2.jpg"
            },
            new Book
            {
                Id = 3,
                Title = "1984",
                Author = "George Orwell",
                Genre = "Dystopia",
                Year = 1949,
                Description = "Wizja totalitarnego państwa kontrolującego każdy aspekt życia.",
                CoverUrl = "/images/covers/book-3.jpg"
            },
            new Book
            {
                Id = 4,
                Title = "Mistrz i Małgorzata",
                Author = "Michaił Bułhakow",
                Genre = "Fantastyka",
                Year = 1967,
                Description = "Opowieść o szatanie odwiedzającym Moskwę w czasach stalinowskich.",
                CoverUrl = "/images/covers/book-4.jpg"
            },
            new Book
            {
                Id = 5,
                Title = "Zbrodnia i kara",
                Author = "Fiodor Dostojewski",
                Genre = "Klasyka",
                Year = 1866,
                Description = "Psychologiczna analiza zbrodni i jej konsekwencji moralnych.",
                CoverUrl = "/images/covers/book-5.jpg"
            },
            new Book
            {
                Id = 6,
                Title = "Hobbit",
                Author = "J.R.R. Tolkien",
                Genre = "Fantasy",
                Year = 1937,
                Description = "Przygody hobbita Bilba Bagginsa w towarzystwie krasnoludów.",
                CoverUrl = "/images/covers/book-6.jpg"
            },
            new Book
            {
                Id = 7,
                Title = "Wiedźmin: Ostatnie życzenie",
                Author = "Andrzej Sapkowski",
                Genre = "Fantasy",
                Year = 1993,
                Description = "Zbiór opowiadań o wiedźminie Geralcie z Rivii.",
                CoverUrl = "/images/covers/book-7.jpg"
            },
            new Book
            {
                Id = 8,
                Title = "Folwark zwierzęcy",
                Author = "George Orwell",
                Genre = "Dystopia",
                Year = 1945,
                Description = "Alegoryczna opowieść o rewolucji zwierząt na farmie.",
                CoverUrl = "/images/covers/book-8.jpg"
            },
            new Book
            {
                Id = 9,
                Title = "Idiota",
                Author = "Fiodor Dostojewski",
                Genre = "Klasyka",
                Year = 1869,
                Description = "Historia księcia Myszkina i jego spotkania z rosyjskim społeczeństwem.",
                CoverUrl = "/images/covers/book-9.jpg"
            },
            new Book
            {
                Id = 10,
                Title = "Bracia Karamazow",
                Author = "Fiodor Dostojewski",
                Genre = "Klasyka",
                Year = 1880,
                Description = "Opowieść o trzech braciach i ich złożonych relacjach z ojcem.",
                CoverUrl = "/images/covers/book-10.jpg"
            },
            new Book
            {
                Id = 11,
                Title = "Duma i uprzedzenie",
                Author = "Jane Austen",
                Genre = "Romans",
                Year = 1813,
                Description = "Historia miłości Elizabeth Bennet i Mr. Darcy'ego.",
                CoverUrl = "/images/covers/book-11.jpg"
            },
            new Book
            {
                Id = 12,
                Title = "Wielki Gatsby",
                Author = "F. Scott Fitzgerald",
                Genre = "Klasyka",
                Year = 1925,
                Description = "Opowieść o tajemniczym milionerze i jego nieszczęśliwej miłości.",
                CoverUrl = "/images/covers/book-12.jpg"
            },
            new Book
            {
                Id = 13,
                Title = "Dziennik Bridget Jones",
                Author = "Helen Fielding",
                Genre = "Romans",
                Year = 1996,
                Description = "Humorystyczny dziennik samotnej trzydziestolatki w Londynie.",
                CoverUrl = "/images/covers/book-13.jpg"
            },
            new Book
            {
                Id = 14,
                Title = "Kod da Vinci",
                Author = "Dan Brown",
                Genre = "Thriller",
                Year = 2003,
                Description = "Pościg za tajemnicą ukrytą w dziełach Leonarda da Vinci.",
                CoverUrl = "/images/covers/book-14.jpg"
            },
            new Book
            {
                Id = 15,
                Title = "Inferno",
                Author = "Dan Brown",
                Genre = "Thriller",
                Year = 2013,
                Description = "Robert Langdon na tropie tajemnicy związanej z Boską Komedią Dantego.",
                CoverUrl = "/images/covers/book-15.jpg"
            },
            new Book
            {
                Id = 16,
                Title = "Nowy wspaniały świat",
                Author = "Aldous Huxley",
                Genre = "Dystopia",
                Year = 1932,
                Description = "Wizja przyszłego społeczeństwa kontrolowanego przez technologię.",
                CoverUrl = "/images/covers/book-16.jpg"
            },
            new Book
            {
                Id = 17,
                Title = "Sto lat samotności",
                Author = "Gabriel García Márquez",
                Genre = "Klasyka",
                Year = 1967,
                Description = "Saga rodziny Buendía w magicznym miasteczku Macondo.",
                CoverUrl = "/images/covers/book-17.jpg"
            },
            new Book
            {
                Id = 18,
                Title = "Lśnienie",
                Author = "Stephen King",
                Genre = "Horror",
                Year = 1977,
                Description = "Opowieść o rodzinie zamkniętej w nawiedzonym hotelu.",
                CoverUrl = "/images/covers/book-18.jpg"
            },
            new Book
            {
                Id = 19,
                Title = "To",
                Author = "Stephen King",
                Genre = "Horror",
                Year = 1986,
                Description = "Grupa przyjaciół zmaga się z przerażającym złem w ich rodzinnym mieście.",
                CoverUrl = "/images/covers/book-19.jpg"
            },
            new Book
            {
                Id = 20,
                Title = "Zabić drozda",
                Author = "Harper Lee",
                Genre = "Klasyka",
                Year = 1960,
                Description = "Opowieść o rasizmie i sprawiedliwości w amerykańskim Południu.",
                CoverUrl = "/images/covers/book-20.jpg"
            }
        };

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book? GetBookById(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }

        public List<Book> SearchBooks(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return books;

            searchTerm = searchTerm.ToLower();
            return books.Where(b =>
                b.Title.ToLower().Contains(searchTerm) ||
                b.Author.ToLower().Contains(searchTerm)
            ).ToList();
        }

        public List<Book> FilterByGenre(string genre)
        {
            if (string.IsNullOrWhiteSpace(genre) || genre == "Wszystkie")
                return books;

            return books.Where(b => b.Genre == genre).ToList();
        }

        public List<string> GetAllGenres()
        {
            return books.Select(b => b.Genre).Distinct().OrderBy(g => g).ToList();
        }
    }
}
