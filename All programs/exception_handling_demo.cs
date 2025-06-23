//////////// exception handling in c#

//////////// try-catch-finally blocks are used to handle exceptions in C#.
//////////// try-finally, try-catch, try-catch-finally, try with multiple catches
//////////// are the three types of exception handling blocks in C#.

//////////using System;

//////////namespace ConsoleApp_Hexaware
//////////{
//////////     class exception_handling_demo
//////////    {
//////////        static void Main(string[] args)
//////////        {
//////////            try
//////////            {
//////////                Console.WriteLine("Enter first number :");
//////////                int num1 = Convert.ToInt32(Console.ReadLine());

//////////                Console.WriteLine("Enter second number :");
//////////                int num2 = Convert.ToInt32(Console.ReadLine());

//////////                int result = num1 / num2;
//////////                Console.WriteLine("Result of division is : " + result);
//////////            }
//////////            catch (DivideByZeroException ex)
//////////            {
//////////                Console.WriteLine("Error occurred please check " + ex.Message);
//////////            }

//////////            catch (Exception ex)
//////////            {
//////////                // Handle the exception
//////////                Console.WriteLine("An error occurred: " + ex.Message);
//////////            }




//////////            //finally                                                  //closing pointers   
//////////            //{
//////////            //    // This block will always execute
//////////            //    Console.WriteLine("Execution completed.");
//////////            //}
//////////            Console.ReadLine();
//////////        }

//////////    }
//////////}


////////// types : built-in exceptions, user-defined exceptions
////////// built-in exceptions are the ones that are already defined in the .NET framework, such as
////////// DivideByZeroException, NullReferenceException, etc. User-defined exceptions are
////////// custom exceptions that you can create by inheriting from the Exception class.

////////using System;
////////public class InvalidAgeException : Exception
////////{
////////    public InvalidAgeException(String message) : base(message)
////////    { }
////////}
////////public class TestUserDefinedException
////////{
////////    static void validate(int age)
////////    {
////////        if (age < 18)
////////        {
////////            throw new InvalidAgeException("Sorry, Age must be greater than 18");
////////        }
////////    }
////////    public static void Main(string[] args)
////////    {
////////        try
////////        {
////////            validate(12);
////////        }
////////        catch (InvalidAgeException e)
////////        {
////////            Console.WriteLine(e);
////////        }

////////        Console.WriteLine("Rest of the code");
////////    }
////////}


////////  invalid bank balance exception

//////using System;

//////public class ThrowTest
//////{
//////    public static void fn(Int32 age)
//////    {
//////        if (age < 0)
//////        {
//////            // throw an argument out of range exception if the age is
//////            // less than zero.
//////            throw new ArgumentOutOfRangeException("Age Cannot Be Negative ");
//////        }
//////    }

//////    public static void Main()
//////    {
//////        try
//////        {
//////            fn(-10);
//////        }

//////        catch (Exception e)
//////        {
//////            Console.WriteLine(String.Concat(e.StackTrace, e.Message));
//////            Console.ReadLine();
//////        }
//////    }
//////}

////// nested try--catch blocks
//using System;

//class nestedtrycatchdemo
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            //-------------------------
//            //-------------------------// Outer try block
//            Console.WriteLine("Outer try block");
//            try
//            {
//                Console.WriteLine("Inner try block");
//                int result = 10 / int.Parse("0"); // This will throw DivideByZeroException
//            }
//            catch (DivideByZeroException ex)
//            {
//                Console.WriteLine("Caught an exception in inner try block: " + ex.Message);
//            }
//        }

//        catch (Exception ex)
//        {
//            Console.WriteLine("Caught an exception in outer try block: " + ex.Message);
//        }


//        finally
//        {
//            Console.WriteLine("Finally block executed.");
//        }
//    }
//}

////=================================================================================
