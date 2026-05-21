using System.Text.Json;

namespace HouseholdUtilitiesWeb.Services;

public class ConsoleEngine
{
    public string Output { get; private set; } = "";

    private string mode = "main";

    private string appliance = "";
    private decimal flowRate;
    private int minutes;
    private decimal volume;
    private decimal cycles;
    private decimal waterPrice;

    private List<Book> books = new();

    private readonly List<string> options = new()
    {
        "Household Water Usage & Cost Calculator",
        "Library Catalogue",
        "Hexadecimal Converter",
        "End the Program"
    };

    public ConsoleEngine()
    {
        LoadCatalogue();
        Menu(options);
        WriteLine("Choose an option:");
    }

    public void Submit(string input)
    {
        input = input.Trim();
        WriteLine($"> {input}");

        switch (mode)
        {
            case "main": MainMenu(input); break;

            case "calc-appliance": GetAppliance(input); break;
            case "calc-type": GetCalculatorType(input); break;
            case "calc-flow": GetFlowRate(input); break;
            case "calc-minutes": GetMinutes(input); break;
            case "calc-volume": GetVolume(input); break;
            case "calc-cycles": GetCycles(input); break;
            case "calc-price": GetWaterPrice(input); break;
            case "calc-again": CalculatorAgain(input); break;

            case "hex": RunHexCalc(input); break;

            case "library-main": LibraryMain(input); break;
            case "library-title": LibraryTitle(input); break;
            case "library-author": LibraryAuthor(input); break;
            case "library-category": LibraryCategory(input); break;
            case "library-genre": LibraryGenre(input); break;
            case "library-remove": LibraryRemove(input); break;
            case "library-filter-category": LibraryFilterCategory(input); break;
            case "library-filter-genre": LibraryFilterGenre(input); break;
        }
    }

    private void MainMenu(string input)
    {
        int selectedOption = ValidChoice(input, 1, 4);

        if (selectedOption == -1)
        {
            WriteLine("Invalid input! Choose a number from 1-4");
            return;
        }

        switch (selectedOption)
        {
            case 1:
                WriteLine($"\nRunning {options[selectedOption - 1]}\n");
                mode = "calc-appliance";
                WriteLine("Enter Appliance Name:");
                break;

            case 2:
                WriteLine($"\nRunning {options[selectedOption - 1]}\n");
                mode = "library-main";
                ShowLibraryMenu();
                break;

            case 3:
                WriteLine($"\nRunning {options[selectedOption - 1]}\n");
                mode = "hex";
                WriteLine("Enter the base 10 number you want to convert to Hexadecimal:");
                break;

            case 4:
                WriteLine("\nTerminated the Program.\n");
                break;
        }
    }

    private void Menu(List<string> menuOptions)
    {
        for (int x = 0; x < menuOptions.Count; x++)
        {
            WriteLine($"{x + 1}) {menuOptions[x]}");
        }
    }

    private int ValidChoice(string input, int min, int max)
    {
        bool isValidInput = int.TryParse(input, out int selectedOption);

        if (isValidInput && selectedOption >= min && selectedOption <= max)
        {
            return selectedOption;
        }

        return -1;
    }

    private decimal ValidDecimalChoice(string input, decimal min, decimal max)
    {
        bool isValidInput = decimal.TryParse(input, out decimal selectedOption);

        if (isValidInput && selectedOption >= min && selectedOption <= max)
        {
            return selectedOption;
        }

        return -1;
    }

    private void ShowMainMenu()
    {
        mode = "main";
        WriteLine("");
        Menu(options);
        WriteLine("Choose an option:");
    }

    private void GetAppliance(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            WriteLine("Input cannot be empty. Please enter a valid value.");
            WriteLine("Enter Appliance Name:");
            return;
        }

        appliance = input;

        mode = "calc-type";
        WriteLine("\nPick 1 or 2:");
        WriteLine("1) For Time-Based Appliances");
        WriteLine("2) For Cycle based appliances");
    }

    private void GetCalculatorType(string input)
    {
        int selectedOption = ValidChoice(input, 1, 2);

        if (selectedOption == -1)
        {
            WriteLine("Invalid input! Choose a number from 1-2");
            return;
        }

        if (selectedOption == 1)
        {
            mode = "calc-flow";
            WriteLine("Enter the flow rate (Litres/Minute)");
        }
        else
        {
            mode = "calc-volume";
            WriteLine("Enter the volume in (Litres/cycle)");
        }
    }

    private void GetFlowRate(string input)
    {
        decimal result = ValidDecimalChoice(input, 0m, 999999999m);

        if (result == -1)
        {
            WriteLine("Invalid input! Choose a number from 0-999999999");
            return;
        }

        flowRate = result;
        mode = "calc-minutes";
        WriteLine("Enter minutes used per day");
    }

    private void GetMinutes(string input)
    {
        int result = ValidChoice(input, 0, 999999999);

        if (result == -1)
        {
            WriteLine("Invalid input! Choose a number from 0-999999999");
            return;
        }

        minutes = result;
        mode = "calc-price";
        WriteLine("Enter water price per 1000L");
    }

    private void GetVolume(string input)
    {
        decimal result = ValidDecimalChoice(input, 0m, 999999999m);

        if (result == -1)
        {
            WriteLine("Invalid input! Choose a number from 0-999999999");
            return;
        }

        volume = result;
        mode = "calc-cycles";
        WriteLine("Enter cycles per day");
    }

    private void GetCycles(string input)
    {
        decimal result = ValidDecimalChoice(input, 0m, 999999999m);

        if (result == -1)
        {
            WriteLine("Invalid input! Choose a number from 0-999999999");
            return;
        }

        cycles = result;
        mode = "calc-price";
        WriteLine("Enter water price per 1000L");
    }

    private void GetWaterPrice(string input)
    {
        decimal result = ValidDecimalChoice(input, 0m, 999999999m);

        if (result == -1)
        {
            WriteLine("Invalid input! Choose a number from 0-999999999");
            return;
        }

        waterPrice = result;

        if (flowRate > 0 || minutes > 0)
        {
            CalcDailyUsage(appliance, flowRate, minutes, waterPrice);
        }
        else
        {
            CalcDailyUsage(appliance, volume, cycles, waterPrice);
        }

        mode = "calc-again";
        WriteLine("Do you want to perform another calculation? Y/N");
    }

    private void CalculatorAgain(string input)
    {
        string endCalc = input.Trim().ToUpper();

        if (endCalc == "Y" || endCalc == "YES")
        {
            flowRate = 0;
            minutes = 0;
            volume = 0;
            cycles = 0;

            mode = "calc-appliance";
            WriteLine("Enter Appliance Name:");
        }
        else if (endCalc == "N" || endCalc == "NO")
        {
            ShowMainMenu();
        }
        else
        {
            WriteLine("Invalid input! Enter Y/N");
        }
    }

    private void Calculations(string appliance, decimal dailyUsage, decimal waterPrice)
    {
        decimal monthlyUsage = dailyUsage * 30;
        decimal yearlyUsage = dailyUsage * 365;
        decimal dailyCost = (dailyUsage / 1000) * waterPrice;
        decimal monthlyCost = (monthlyUsage / 1000) * waterPrice;
        decimal yearlyCost = (yearlyUsage / 1000) * waterPrice;

        string receipt = $"{appliance}\n------------------\n" +
                         $"Daily usage (L): {dailyUsage:F2}\n" +
                         $"Monthly usage (L): {monthlyUsage:F2}\n" +
                         $"Yearly usage (L): {yearlyUsage:F2}\n" +
                         $"Estimated Daily Cost (£): £{dailyCost:F2}\n" +
                         $"Estimated Monthly Cost (£): £{monthlyCost:F2}\n" +
                         $"Estimated Yearly Cost (£): £{yearlyCost:F2}\n";

        WriteLine(receipt);
        WriteLine("Receipt has been created in the browser console.\n");
    }

    private void CalcDailyUsage(string appliance, decimal flowRate, int minutes, decimal waterPrice)
    {
        decimal dailyUsage = flowRate * minutes;
        Calculations(appliance, dailyUsage, waterPrice);
    }

    private void CalcDailyUsage(string appliance, decimal volume, decimal cycles, decimal waterPrice)
    {
        decimal dailyUsage = volume * cycles;
        Calculations(appliance, dailyUsage, waterPrice);
    }

    private void RunHexCalc(string input)
    {
        int denary = ValidChoice(input, 0, 999999999);

        if (denary == -1)
        {
            WriteLine("Invalid input! Choose a number from 0-999999999");
            return;
        }

        if (denary == 0)
        {
            WriteLine("0x0");
            ShowMainMenu();
            return;
        }

        Dictionary<int, string> hexMap = LoadHexMap();

        var remainder = new List<string>();

        while (denary > 0)
        {
            int digit = denary % 16;
            remainder.Add(hexMap[digit]);
            denary /= 16;
        }

        remainder.Reverse();
        WriteLine($"Hexadecimal: 0x{string.Join("", remainder)}\n");

        ShowMainMenu();
    }

    private Dictionary<int, string> LoadHexMap()
    {
        var hexMap = new Dictionary<int, string>();
        string[] defaultHex = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

        for (int i = 0; i < 16; i++)
        {
            hexMap[i] = defaultHex[i];
        }

        return hexMap;
    }

    private string bookTitle = "";
    private string bookAuthor = "";
    private bool bookIsFiction;
    private bool filterIsFiction;

    private readonly List<string> fictionGenres = new()
    {
        "Horror", "Science Fiction", "Crime", "Thriller", "Adventure"
    };

    private readonly List<string> nonFictionGenres = new()
    {
        "Autobiography", "History", "Science", "Philosophy"
    };

    private void ShowLibraryMenu()
    {
        List<string> options1 = new()
        {
            "Add Book",
            "Remove Book",
            "Filter By Genre",
            "List of all Books",
            "Back to Main Menu"
        };

        Menu(options1);
        WriteLine("Choose 1-5:");
    }

    private void LibraryMain(string input)
    {
        int selectedOption = ValidChoice(input, 1, 5);

        if (selectedOption == -1)
        {
            WriteLine("Invalid input! Choose a number from 1-5");
            return;
        }

        switch (selectedOption)
        {
            case 1:
                mode = "library-title";
                WriteLine("Enter Title:");
                break;

            case 2:
                mode = "library-remove";
                WriteLine("Enter Title of book to remove:");
                break;

            case 3:
                mode = "library-filter-category";
                WriteLine("Choose Category:");
                WriteLine("1) Fiction");
                WriteLine("2) Non-Fiction");
                break;

            case 4:
                ListAllBooks();
                ShowLibraryMenu();
                break;

            case 5:
                ShowMainMenu();
                break;
        }
    }

    private void LibraryTitle(string input)
    {
        bookTitle = input;
        mode = "library-author";
        WriteLine("Enter Author:");
    }

    private void LibraryAuthor(string input)
    {
        bookAuthor = input;

        mode = "library-category";
        WriteLine("Choose Category:");
        WriteLine("1) Fiction");
        WriteLine("2) Non-Fiction");
    }

    private void LibraryCategory(string input)
    {
        int categoryChoice = ValidChoice(input, 1, 2);

        if (categoryChoice == -1)
        {
            WriteLine("Invalid input! Choose a number from 1-2");
            return;
        }

        bookIsFiction = categoryChoice == 1;

        mode = "library-genre";
        WriteLine("Choose Genre:");

        var genreList = bookIsFiction ? fictionGenres : nonFictionGenres;
        Menu(genreList);
        WriteLine($"Choose 1-{genreList.Count}:");
    }

    private void LibraryGenre(string input)
    {
        var genreList = bookIsFiction ? fictionGenres : nonFictionGenres;

        int genreChoice = ValidChoice(input, 1, genreList.Count);

        if (genreChoice == -1)
        {
            WriteLine($"Invalid input! Choose a number from 1-{genreList.Count}");
            return;
        }

        string genre = genreList[genreChoice - 1];

        Book newBook = new()
        {
            Title = bookTitle,
            Author = bookAuthor,
            Genre = new List<string> { genre },
            IsFiction = bookIsFiction
        };

        AddBook(newBook);
        SaveCatalogue();

        mode = "library-main";
        ShowLibraryMenu();
    }

    private void LibraryRemove(string input)
    {
        RemoveBook(input);
        SaveCatalogue();

        mode = "library-main";
        ShowLibraryMenu();
    }

    private void LibraryFilterCategory(string input)
    {
        int categoryChoice = ValidChoice(input, 1, 2);

        if (categoryChoice == -1)
        {
            WriteLine("Invalid input! Choose a number from 1-2");
            return;
        }

        filterIsFiction = categoryChoice == 1;

        mode = "library-filter-genre";
        WriteLine("Choose Genre:");

        var genreList = filterIsFiction ? fictionGenres : nonFictionGenres;
        Menu(genreList);
        WriteLine($"Choose 1-{genreList.Count}:");
    }

    private void LibraryFilterGenre(string input)
    {
        var genreList = filterIsFiction ? fictionGenres : nonFictionGenres;

        int genreChoice = ValidChoice(input, 1, genreList.Count);

        if (genreChoice == -1)
        {
            WriteLine($"Invalid input! Choose a number from 1-{genreList.Count}");
            return;
        }

        string filterGenre = genreList[genreChoice - 1];

        var results = FindByGenre(filterGenre, filterIsFiction);

        if (results.Count == 0)
        {
            WriteLine($"No books found in genre '{filterGenre}'.");
        }
        else
        {
            WriteLine($"Books in genre '{filterGenre}':");

            foreach (var b in results)
            {
                WriteLine($"- {b.Title} by {b.Author}");
            }
        }

        mode = "library-main";
        ShowLibraryMenu();
    }

    private void AddBook(Book b)
    {
        books.Add(b);
        WriteLine($"Book '{b.Title}' added.");
    }

    private void RemoveBook(string title)
    {
        var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

        if (book != null)
        {
            books.Remove(book);
            WriteLine($"Book '{title}' removed.");
        }
        else
        {
            WriteLine($"Book '{title}' not found");
        }
    }

    private List<Book> FindByGenre(string genre, bool? isFiction = null)
    {
        return books.Where(b => b.Genre.Contains(genre) &&
                                (isFiction == null || b.IsFiction == isFiction))
                    .ToList();
    }

    private void ListAllBooks()
    {
        if (books.Count == 0)
        {
            WriteLine("No books in catalogue.");
        }
        else
        {
            WriteLine("All books in catalogue:");

            foreach (var b in books)
            {
                WriteLine($"- {b.Title} by {b.Author} ({string.Join(", ", b.Genre)}) [{(b.IsFiction ? "Fiction" : "Non-Fiction")}]");
            }
        }
    }

    private void SaveCatalogue()
    {
        string json = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("books.json", json);
        WriteLine("Catalogue saved to JSON.");
    }

    private void LoadCatalogue()
    {
        if (File.Exists("books.json"))
        {
            string json = File.ReadAllText("books.json");
            books = JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();
            WriteLine("Catalogue loaded from JSON.");
        }
        else
        {
            books = new List<Book>();
        }
    }

    private void WriteLine(string text)
    {
        Output += text + "\n";
    }

    private class Book
    {
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public List<string> Genre { get; set; } = new();
        public bool IsFiction { get; set; }
    }
}