//////// keywords : `string`, `var`, `dynamic`, `object`
//////// This code snippet is a demonstration of the use of different string-related keywords in C#.
//////// It includes examples of `string`, `var`, `dynamic`, and `object` keywords.

////////strings demo 
//////using System;


//////namespace ConsoleApp_Hexaware
//////{
//////     class strings_keywords_demo
//////    {
//////        static void Main(string[] args)
//////        {
//////            // keywords 
//////            string str1 = "Hello, World!"; // using string keyword
//////            var str2 = "Hello, Universe!"; // using var keyword (implicitly typed)
//////            dynamic str3 = "Hello, Galaxy!"; // using dynamic keyword (can change type at runtime)
//////            object str4 = "Hello, Multiverse!"; // using object keyword (can hold any type)

//////            Console.WriteLine(str1  );
//////            Console.WriteLine(str2  );
//////            Console.WriteLine(str3  );
//////            Console.WriteLine(str4  );


//////            // Demonstrating type changes with dynamic
//////            dynamic var1= "Initial String";
//////            Console.WriteLine(var1);

//////            var1 = 42; // Changing to an integer
//////            Console.WriteLine(var1);

//////            var1 = 3.14; // Changing to a double
//////            Console.WriteLine(var1);


//////            Console.ReadLine();
//////        }
//////    }
//////}
//////==================================================================
////// keywords are the reserved words in C# that have special meaning in the language.
////// They cannot be used as identifiers (names for variables, classes, methods, etc.).

//////=====================================================================================
////// structures and enums 

////// structures (structs) in C# are value types that can encapsulate data
////// and related functionality.

////using System;

////struct book
////{
////    public string title;
////    public string author;
////    public int pages;

////    // Method to display book information
////    public void DisplayInfo()
////    {
////        Console.WriteLine($"Title: {title}, Author: {author}, Pages: {pages}");
////    }
////}

////class struct_demo
////{
////    static void Main(string[] args)
////    {
////        book b1= new book();

////        b1.title = "C# Programming";
////        b1.author = "John Doe";
////        b1.pages = 300;
////        b1.DisplayInfo();

////       // book b2 = new book { title = "Java Programming", author = "Jane Doe", pages = 400 };
////        book b2 = new book();
////        b2.title = "Asp.net Programming";
////        b2.author = "Cathie";
////        b2.pages = 400;
////        b2.DisplayInfo();
////    }
////}


////=================================================================

//// enums (enumerations) in C# are a distinct type that consists of a set of
//// named constants called the enumerator list.

//using System;

//class enum_demo
//    {
//      // Define an enumeration for colors
//        enum Colors
//        {
//            Red,
//            Green,
//            Blue,
//            Yellow
//        }
//    static void Main(string[] args)
//    {
//        // Assign an enum value to a variable
//        Colors favoriteColor = Colors.Green;

//        // Display the enum value
//        Console.WriteLine($"Favorite color is: {favoriteColor}");
                
//        // Convert enum to integer
//        int colorValue = (int)favoriteColor;
//        Console.WriteLine($"Color value: {colorValue}");
        
//        // Convert integer back to enum
//        Colors colorFromInt = (Colors)colorValue;
//        Console.WriteLine($"Color from integer: {colorFromInt}");
//    }
//}

//================================================================


