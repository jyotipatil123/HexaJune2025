//////// value types and reference types in c#

//////using System;

//////namespace ConsoleApp_Hexaware
//////{
//////     class valuetype_reftype_demo
//////    {
//////        static void Main(string[] args)
//////        {
//////            // value type example
//////            //int, char, float, bool, struct, enum 
//////            //stored in the stack 

//////            int a = 10; // value type
//////            int b = a; // b is a copy of a
//////            b = 20; // changing b does not affect a
//////            Console.WriteLine($"Value Type Example: a = {a}, b = {b}"); // Output: a = 10, b = 20

//////            //===============================================
//////            // reference type example
//////            // stored in heap 
//////            // here reference of the actual data is stored 
//////            // whenever you are referrring, address will be referred and not the value
//////            // class, arrays, interface, string, object 

//////            india obj1 = new india();
//////            obj1.population = "too much";
//////            Console.WriteLine(obj1.population);

//////            india obj2 = obj1; // obj2 is a reference to obj1
//////            obj2.population = "too too much";
//////            Console.WriteLine(obj2.population);

//////            Console.ReadLine();

//////        }
//////    }

//////    class india
//////    {
//////        public string population;
//////    }

//////}


////// nullable types in c#

////using System;

////class NullableTypesDemo
////{
////    static void Main(string[] args)
////    {
////        // Nullable type example

////        int a = 10;
////        // non-nullable type
////        Console.WriteLine(a);

////        int? b = null;  //compile time error
////        Console.WriteLine(b);


////        Console.ReadLine();
////    }
////}
////============================================================
//// anonymous types in c#
//// anonymous types are used to create an object without
//// defining a class

//// anonymous types helps to create an object without explicitly
//// defining a class  
//// LINQ queries are used to create anonymous types

//using System;
//class mainclass
//{
//    static void Main(string[] args)
//    {
//        var person = new { Name = "John", Age = 30 }; // anonymous type

//        Console.WriteLine(person.Name);
//        Console.WriteLine(person.Age);

//        // person.Name = "Doe"; 
//        // This will give an error because anonymous types are immutable
//        Console.ReadLine();
//    }
//}