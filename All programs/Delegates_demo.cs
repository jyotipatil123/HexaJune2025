//////////// Delegates in c#
//////////// function pointers with type safety
//////////// declare, assign, call 
/////////// types : single cast, multi cast 

////////// 1 function --1 delegate pointer --single cast delegate
////////// multiple functions with 1 delegate pointer --- multi cast delegate

//////////using System;
//////////class demo
//////////{
//////////    public delegate void DemoDelegate();          //declare the delegate
//////////    static void Main(string[] args)
//////////    {
//////////        DemoDelegate obj1 = new DemoDelegate(function1);   //assign
//////////        obj1();  //call

//////////        demo d2= new demo();
//////////        DemoDelegate obj3 = new DemoDelegate(d2.function2);
//////////        obj3();

//////////        Console.ReadLine();
//////////    }
//////////    static void function1()
//////////    {
//////////        Console.WriteLine("static void function is invoked");
//////////    }

//////////    public void function2()
//////////    {
//////////        Console.WriteLine("public void function is invoked");
//////////    }
//////////}


//////////====================================================================

////////// built in delegates 
////////// Func, Action, Predicate 

////////using System;

////////class MyClass
////////{
////////    public delegate int calcdelegate(int x, int y);
////////    static void Main(string[] args)
////////    {
////////        calcdelegate c1;

////////        c1 = Add;
////////        Console.WriteLine("Addition result is : "+ c1(10, 2));

////////        c1 += sub;
////////        Console.WriteLine(c1(10, 2));

////////        c1 += mult;
////////        Console.WriteLine(c1(10, 2));

////////        c1 += div;
////////        Console.WriteLine(c1(10, 2));

////////        Console.ReadLine();
////////    }
////////    static int Add(int a, int b) {  return (a + b);  }
////////    static int sub(int a, int b) {   return (a - b); }
////////    static int div(int a, int b)  {   return (a / b); }
////////    static int mult(int a, int b) {   return (a * b);  }
////////}

////////======================================================================================

//////// Func delegate

//////using System;

//////class MyClass
//////{
//////    static void Main(string[] args)
//////    {
//////        Func<int, int, int> func_calc;

//////        func_calc = Add;
//////        Console.WriteLine(func_calc(5,2));

//////        func_calc = sub;
//////        Console.WriteLine(func_calc(5, 2));

//////        Console.ReadLine();
//////    }
//////    public static int Add(int a, int b) { return (a + b); }
//////    public static int sub(int a, int b) { return (a - b); }
//////}

//////============================================================================

////// Action delegate

//////using System;

//////class MyClass
//////{
//////    private static int result;  // global
//////    static void Main(string[] args)
//////    {
//////        Action<int, int> addition = Add;
//////        addition(10,20);

//////        Console.WriteLine("Addition result is : "+result);

//////        Console.ReadLine();
//////    }
//////    private static void Add(int a, int b)
//////    {
//////        result = a + b;
//////    }
//////}

//////  predicate delegate

//////using System;
//////class mainclass
//////{
//////    static bool IsUpperCase(string str)
//////    {
//////        return str.Equals(str.ToUpper());
//////    }

//////    static void Main(string[] args)
//////    {
//////        Predicate<string> var1 = IsUpperCase;

//////        bool result = var1("hello world!!");

//////        Console.WriteLine(result);
//////    }
//////}

////// one more example on Predicate

////using System;

////class Program
////{
////    static void Main(string[] args)
////    {
////        Predicate<string> CheckIfApple = IsApple;
////        bool result = IsApple("I Phone X");

////        if (result)
////            Console.WriteLine("It's an IPhone");
////    }

////    private static bool IsApple(string modelName)
////    {
////        if (modelName == "I Phone X")
////            return true;
////        else
////            return false;
////    }
////}


//// anonymous method 
//// no function name 

//using System;

//class MyClass
//{
//    public delegate int mydelegate(int x, int y);
//    static void Main(string[] args)
//    {
//        mydelegate a = delegate (int x,int y) 
//                      {
//                           return x+y;
//                      };

//        Console.WriteLine("Addition result is : "+a(10, 2));

//        mydelegate b = delegate (int x, int y) { return x - y; };
//        Console.WriteLine("Subtraction result is : " + a(10, 2));

//        mydelegate c = delegate (int x, int y) { return x * y; };
//        Console.WriteLine("Multiplication result is : " + a(10, 2));

//        mydelegate d = delegate (int x, int y) { return x / y; };
//        Console.WriteLine("Division result is : " + a(10, 2));

//        Console.ReadLine();
//    }
//}

//=============================================================

//Event 
// delegates and events --together 

//using System;
//namespace SampleApp
//{
//    public delegate string MyDel(string str);   // defining delegate

//    class EventProgram
//    {
//        event MyDel MyEvent;  //declaration for events 

//        public EventProgram()   // constructor 
//        {
//            this.MyEvent += new MyDel(this.WelcomeUser);
//        }
//        public string WelcomeUser(string username)
//        {
//            return "Welcome " + username;
//        }
//        static void Main(string[] args)
//        {
//            EventProgram obj1 = new EventProgram();
//            string result = obj1.MyEvent("Tutorials Point");
//            Console.WriteLine(result);
//        }
//    }
//}


using System;
namespace SampleApp
{
    public delegate int MyCalc(int a, int b);   // defining delegate

    class EventProgram
    {
        event MyCalc MyEvent;  //declaration for events 
        public EventProgram()   // constructor 
        {
          
        }
        static int add(int x, int y)      {         return (x + y);      }
        static int sub(int x, int y)      {          return (x - y); }
        static int mult(int x, int y)    {       return (x * y);      }
        static int div(int x, int y)     {        return (x / y);       }
        static void Main(string[] args)
        {
            EventProgram obj1 = new EventProgram();
            int result1 = obj1.MyEvent(10,2);

            EventProgram obj2 = new EventProgram();
            int result2 = obj2.MyEvent(10, 2);

            EventProgram obj3 = new EventProgram();
            int result3 = obj3.MyEvent(10, 2);

            EventProgram obj4 = new EventProgram();
            int result4 = obj4.MyEvent(10, 2);

            MyEvent += new MyCalc(add);


            Console.WriteLine(result);
        }
    }
}