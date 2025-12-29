# BookLibrary - Cyfrowa Biblioteka Książek

Aplikacja webowa do przeglądania kolekcji książek z funkcją wyszukiwania i filtrowania.

# Opis projektu

BookLibrary to aplikacja typu Single Page Application (SPA) stworzona w technologii Blazor WebAssembly. 
Umożliwia przeglądanie, wyszukiwanie i filtrowanie kolekcji 20 książek różnych gatunków literackich.


# Funkcjonalności

- Przeglądanie listy książek** - wyświetlanie kolekcji 20 książek w formie responsywnych kart
- Wyszukiwanie - filtrowanie książek po tytule lub autorze
- Filtrowanie po gatunku - wybór gatunku z listy rozwijanej
- Strona szczegółów - pełne informacje o wybranej książce
- Responsywny design - dostosowanie do różnych urządzeń
- Ciemny motyw - nowoczesny, elegancki interfejs

# Technologie

# Frontend:
- Blazor WebAssembly (.NET 8)
- C# - logika aplikacji
- Razor Components - komponenty UI
- HTML5 & CSS3 - struktura i stylowanie
- LINQ - operacje na danych

# Narzędzia:
- Visual Studio 2022
- GitHub - hosting kodu

# Struktura projektu

BookLibrary/
├── Components/
│   ├── Layout/
│   │   └── MainLayout.razor          
│   └── Pages/
│       ├── _Imports.razor            
│       ├── App.razor                 
│       └── Routes.razor              
├── wwwroot/
│   ├── images/                       
│   ├── bootstrap/                    
│   ├── app.css                       
│   └── favicon.png                   
├── Program.cs                       
├── appsettings.json                  
└── README.md                         

BookLibrary.Client/
├── Models/
│   └── Book.cs                       
├── Services/
│   └── BookService.cs               
├── Pages/
│   ├── Index.razor                 
│   └── BookDetails.razor            
├── _Imports.razor                    
└── Program.cs                        

# Uruchomienie projektu:

1. Sklonuj repozytorium:
git clone https://github.com/TWOJA-NAZWA/BookLibrary.git
cd BookLibrary

2. Otwórz projekt w Visual Studio:
- Kliknij dwukrotnie na plik `BookLibrary.sln`

3. Uruchom aplikację:
- Naciśnij `F5` 
- Aplikacja otworzy się w przeglądarce pod adresem `https://localhost:xxxx`


## Autorzy projektu

Damian Baliński - 123702
Jakub Szymański - 122893

Społeczna Akademia Nauk - Informatyka (zaoczne)  
Semestr: 3  
Grupa: 3  
Przedmiot: Technologie Internetowe