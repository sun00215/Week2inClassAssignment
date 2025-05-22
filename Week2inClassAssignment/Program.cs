namespace Week2inClassAssignment;

// Exercise 1 & 2: Create a Simple Class with Constructor
class Book
{
    private string _title;
    private string _author;
    private int _yearPublished;

    // Constructor for Exercise 2
    public Book(string title, string author, int yearPublished)
    {
        _title = title;
        _author = author;
        _yearPublished = yearPublished;
    }
    
    // Method to display book information
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title} Author: {_author} Year Published: {_yearPublished}");
    }
}

// Exercise 3 & 4: Properties, Encapsulation and Method Returning a Value
class Student
{
    // Private fields - using underscore prefix for private fields
    private string _name = string.Empty; 
    private int _grade;

    // Properties with encapsulation
    public string Name
    {
        get { return _name; }
        set { _name = value ?? string.Empty; } 
    }
                    
    public int Grade
    {
        get { return _grade; }
        set 
        { 
            // Only set grade if it's between 0 and 100
            if (value >= 0 && value <= 100)
            {
                _grade = value;
            }
        }
    }

    // Method returning a value for Exercise 4
    public bool IsPassing()
    {
        return _grade >= 50;
    }
}

// Exercise 5: Class Interaction
class Engine
{
    public int HorsePower { get; set; }
}

class Car
{
    public string Model { get; set; } = string.Empty; 
    public Engine Engine { get; set; } = new Engine(); 

    public void Describe()
    {
        Console.WriteLine($"Model: {Model} Engine Horsepower: {Engine.HorsePower}");
    }
}

// Exercise 6: String methods
class StringUtils
{
    public static int CountVowels(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        int count = 0;
        
        string lowerInput = input.ToLower();
        
        foreach (char c in lowerInput)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                count++;
            }
        }
        
        return count;
    }
}

// Main Program to test all exercises
class Program
{
    static void Main()
    {
        Console.WriteLine("Exercise 1 & 2: Book Class with Constructor");
        Book book = new Book("The Hobbit", "J.R.R. Tolkien", 1937);
        book.DisplayInfo();
        
        Console.WriteLine("\nExercise 3 & 4: Student Class with Properties and Methods");
        Student student = new Student();
        student.Name = "Alice";
        student.Grade = 85;
        Console.WriteLine($"Student: {student.Name}, Grade: {student.Grade}");
        Console.WriteLine($"Is passing: {student.IsPassing()}");
        
        // Test invalid grade
        student.Grade = 120; 
        Console.WriteLine($"After trying to set invalid grade: {student.Grade}");
        
        Console.WriteLine("\nExercise 5: Class Interaction");
        Car car = new Car
        {
            Model = "Mustang",
            Engine = new Engine { HorsePower = 450 }
        };
        car.Describe();
        
        Console.WriteLine("\nExercise 6: String Methods");
        Console.WriteLine($"CountVowels(\"Hello World\") = {StringUtils.CountVowels("Hello World")}");
        Console.WriteLine($"CountVowels(\"Apples ARE awesome\") = {StringUtils.CountVowels("Apples ARE awesome")}");
        
        Console.ReadLine();
    }
}