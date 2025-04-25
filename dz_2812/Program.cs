using System;

class Program
{
    static void drawsquare(int sidelength, char symbol)
    {
        for (int i = 0; i < sidelength; i++)
        {
            for (int j = 0; j < sidelength; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }

    static bool ispalindrome(int number)
    {
        int original = number;
        int reversed = 0;
        while (number > 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }
        return original == reversed;
    }

    static int[] filterarray(int[] originalArray, int[] filterArray)
    {
        return Array.FindAll(originalArray, item => Array.IndexOf(filterArray, item) == -1);
    }

    class Website
    {
        public string name { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public string ipaddress { get; set; }

        public void inputdata()
        {
            Console.Write("Enter website name: ");
            name = Console.ReadLine();
            Console.Write("Enter website URL: ");
            url = Console.ReadLine();
            Console.Write("Enter website description: ");
            description = Console.ReadLine();
            Console.Write("Enter website IP address: ");
            ipaddress = Console.ReadLine();
        }

        public void displaydata()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"URL: {url}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"IP Address: {ipaddress}");
        }
    }

    class Magazine
    {
        public string title { get; set; }
        public int yearest { get; set; }
        public string description { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public void inputdata()
        {
            Console.Write("Enter magazine title: ");
            title = Console.ReadLine();
            Console.Write("Enter year established: ");
            yearest = int.Parse(Console.ReadLine());
            Console.Write("Enter magazine description: ");
            description = Console.ReadLine();
            Console.Write("Enter contact phone: ");
            phone = Console.ReadLine();
            Console.Write("Enter email: ");
            email = Console.ReadLine();
        }

        public void displaydata()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Year Established: {yearest}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"Email: {email}");
        }
    }

    class Store
    {
        public string name { get; set; }
        public string address { get; set; }
        public string profile { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public void inputdata()
        {
            Console.Write("Enter store name: ");
            name = Console.ReadLine();
            Console.Write("Enter store address: ");
            address = Console.ReadLine();
            Console.Write("Enter store profile: ");
            profile = Console.ReadLine();
            Console.Write("Enter contact phone: ");
            phone = Console.ReadLine();
            Console.Write("Enter email: ");
            email = Console.ReadLine();
        }

        public void displaydata()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Profile: {profile}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"Email: {email}");
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter side length for square: ");
            int sidelength = int.Parse(Console.ReadLine());
            Console.Write("Enter symbol to draw square: ");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();
            drawsquare(sidelength, symbol);
            Console.Write("Enter a number to check if it's a palindrome: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(ispalindrome(number) ? "The number is a palindrome." : "The number is not a palindrome.");

            int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filterArray = { 6, 88, 7 };
            int[] filteredArray = filterarray(originalArray, filterArray);
            Console.WriteLine("Filtered array: " + string.Join(", ", filteredArray));

            Website website = new Website();
            website.inputdata();
            website.displaydata();

            Magazine magazine = new Magazine();
            magazine.inputdata();
            magazine.displaydata();

            Store store = new Store();
            store.inputdata();
            store.displaydata();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter the correct data type.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

