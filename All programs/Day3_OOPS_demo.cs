////////////////////////////// classes and objects 
//////////////////////////////classes are blueprints for creating objects
////////////////////////////// objects are instances of classes

////////////////////////////// class is a user defined data type
////////////////////////////// class is a collection of data members and member functions
////////////////////////////// data members are variables that hold the state of the object
////////////////////////////// member functions are methods that define the behavior of the object
////////////////////////////// class is a template for creating objects
////////////////////////////// object is an instance of a class


//////////////////////////////Pillars of OOPS
////////////////////////////// 1. Encapsulation
////////////////////////////// 2. Inheritance
//////////////////////////////      types : single, multiple, hierarchical, multilevel, hybrid
////////////////////////////// 3. Polymorphism
//////////////////////////////      types : compile time (method overloading, operator overloading),
//////////////////////////////      runtime (method overriding)
////////////////////////////// 4. Abstraction




////////////////////////////// classes and objects demo
////////////////////////////using System;

////////////////////////////namespace ConsoleApp_Hexaware
////////////////////////////{
////////////////////////////    class Car
////////////////////////////    {
////////////////////////////        //accss modifiers
////////////////////////////        // public - accessible from anywhere
////////////////////////////        // private - accessible only within the class
////////////////////////////        // protected - accessible within the class and derived

////////////////////////////        // data members
////////////////////////////        public string color;
////////////////////////////        public string model;
////////////////////////////        public int year;

////////////////////////////        // member function
////////////////////////////        public void Start()
////////////////////////////        {
////////////////////////////            Console.WriteLine("Car is starting");
////////////////////////////        }
////////////////////////////        public void Stop()
////////////////////////////        {
////////////////////////////            Console.WriteLine("Car is stopping");
////////////////////////////        }
////////////////////////////    }


////////////////////////////    class Day3_OOPS_demo
////////////////////////////    {
////////////////////////////        static void Main(string[] args)
////////////////////////////        {
////////////////////////////            Car c1= new Car(); // creating an object of the class Car
////////////////////////////            c1.color = "Red"; // setting the color of the car
////////////////////////////            c1.model = "Toyota"; // setting the model of the car
////////////////////////////            c1.year = 2020; // setting the year of the car
////////////////////////////            Console.WriteLine( "Car Details: ");
////////////////////////////            Console.WriteLine($"Color: {c1.color}");
////////////////////////////            Console.WriteLine($"Model: {c1.model}");
////////////////////////////            Console.WriteLine($"Year: {c1.year}");

////////////////////////////            c1.Start(); // calling the Start method of the car object
////////////////////////////            c1.Stop(); // calling the Stop method of the car object


////////////////////////////            Console.ReadLine();
////////////////////////////        }
////////////////////////////    }
////////////////////////////}


////////////////////////////===================================================

//////////////////////////// Encapsulation
//////////////////////////// Encapsulation is the process of wrapping data and methods into a
//////////////////////////// single unit called class.
//////////////////////////// It restricts direct access to some of an object's components,
//////////////////////////// which can prevent the accidental modification of data.
//////////////////////////// Encapsulation helps in data hiding and abstraction.

//////////////////////////// It allows us to control access to the data members and methods of a class.

//////////////////////////// We can use access modifiers to control the visibility of class members.
//////////////////////////// The most common access modifiers are public, private, and protected.
////////////////////////////Example of encapsulation in C#:
//////////////////////////using System;

//////////////////////////class encpasulationdemo
//////////////////////////{
//////////////////////////    static void Main(string[] args)
//////////////////////////    {
//////////////////////////        // Creating an object of the class Employee
//////////////////////////        Employee emp = new Employee();

//////////////////////////        // Setting the properties using setter methods
//////////////////////////        emp.SetName("John Doe");
//////////////////////////        emp.SetSalary(50000);

//////////////////////////        // Getting the properties using getter methods
//////////////////////////        Console.WriteLine("Employee Name: " + emp.GetName());
//////////////////////////        Console.WriteLine("Employee Salary: " + emp.GetSalary());

//////////////////////////        Console.ReadLine();
//////////////////////////    }
//////////////////////////}
//////////////////////////// Adding the missing methods to the Employee class to fix the CS1061 error.
//////////////////////////class Employee
//////////////////////////{
//////////////////////////    private string name;
//////////////////////////    private double salary;

//////////////////////////    // Setter method for name
//////////////////////////    public void SetName(string name)
//////////////////////////    {
//////////////////////////        this.name = name;
//////////////////////////    }

//////////////////////////    // Getter method for name
//////////////////////////    public string GetName()
//////////////////////////    {
//////////////////////////        return name;
//////////////////////////    }

//////////////////////////    // Setter method for salary
//////////////////////////    public void SetSalary(double salary)
//////////////////////////    {
//////////////////////////        this.salary = salary;
//////////////////////////    }

//////////////////////////    // Getter method for salary
//////////////////////////    public double GetSalary()
//////////////////////////    {
//////////////////////////        return salary;
//////////////////////////    }
//////////////////////////}


////////////////////////// functions in c#

////////////////////////using System;
////////////////////////class functions_demo
////////////////////////{
////////////////////////    static void Main(string[] args)
////////////////////////    {
////////////////////////        // Calling the function to display a message
////////////////////////        DisplayMessage("Hello, World!");

////////////////////////        // Calling the function to add two numbers
////////////////////////        int sum = AddNumbers(5, 10);
////////////////////////        Console.WriteLine("Sum: " + sum);

////////////////////////        functions_demo obj = new functions_demo();
////////////////////////        obj.display(); // calling the display function

////////////////////////        Console.ReadLine();
////////////////////////    }
////////////////////////    // Function to display a message
////////////////////////    static void DisplayMessage(string message)
////////////////////////    {
////////////////////////        Console.WriteLine(message);
////////////////////////    }
////////////////////////    // Function to add two numbers and return the result
////////////////////////    static int AddNumbers(int a, int b)
////////////////////////    {
////////////////////////        return a + b;
////////////////////////    }

////////////////////////    public void display()
////////////////////////    {
////////////////////////        Console.WriteLine("This is a function in C#.");
////////////////////////    }
////////////////////////}

////////////////////////===================================================
//////////////////////// 2.Abstraction
//////////////////////// Abstraction is the process of hiding the implementation details and
//////////////////////// showing only the essential features of an object.
//////////////////////// It allows us to focus on what an object does instead of how it does it.
//////////////////////// Abstraction can be achieved using abstract classes and interfaces in C#.
//////////////////////// An abstract class is a class that cannot be instantiated and can contain
//////////////////////// abstract methods (methods without a body) and concrete methods (methods with a body).

////////////////////////====================================================

//////////////////////// 3.Inheritance
//////////////////////// Inheritance is the process of acquiring the properties and behaviors
//////////////////////// of another class.
//////////////////////// It allows us to create a new class (derived class) based on an existing class (base class).
//////////////////////// The derived class inherits the members (fields, properties, methods) of the base class.
//////////////////////// Inheritance promotes code reusability and establishes a relationship between classes.
//////////////////////// In C#, we can use the `:` symbol to indicate inheritance.
//////////////////////// The derived class can extend or override the members of the base class.
//////////////////////// C# supports single inheritance, meaning a class can inherit
//////////////////////// from only one base class. However, a class can implement multiple interfaces.


//////////////////////using System;

//////////////////////class vehicle
//////////////////////{
//////////////////////    public string brand;
//////////////////////    public int speed;
//////////////////////    public void Start()
//////////////////////    {
//////////////////////        Console.WriteLine("Vehicle is starting");
//////////////////////    }
//////////////////////    public void Stop()
//////////////////////    {
//////////////////////        Console.WriteLine("Vehicle is stopping");
//////////////////////    }
//////////////////////}

//////////////////////class Car : vehicle // Car class inherits from vehicle class  //single inheritance
//////////////////////{
//////////////////////    public string model;
//////////////////////    public void DisplayDetails()
//////////////////////    {
//////////////////////        Console.WriteLine($"Brand: {brand}, Model: {model}, Speed: {speed} km/h");
//////////////////////    }
//////////////////////}

//////////////////////class Bike : Car  //Multi level  inheritance
//////////////////////{
//////////////////////    public string type;
//////////////////////    public void DisplayDetails()
//////////////////////    {
//////////////////////        Console.WriteLine($"Brand: {brand}, Type: {type}, Speed: {speed} km/h");
//////////////////////    }
//////////////////////}

//////////////////////class Bike1 : vehicle // Bike class inherits from vehicle class  //hierarchical inheritance
//////////////////////{
//////////////////////    public string type;
//////////////////////    public void DisplayDetails()
//////////////////////    {
//////////////////////        Console.WriteLine($"Brand: {brand}, Type: {type}, Speed: {speed} km/h");
//////////////////////    }
//////////////////////}

//////////////////////// entire program is an example of hybrid inheritance
//////////////////////class mainclass
//////////////////////{
//////////////////////    static void Main(string[] args)
//////////////////////    {
//////////////////////        Car obj = new Car(); // creating an object of the Car class
//////////////////////        obj.brand = "Toyota"; // setting the brand of the car
//////////////////////        obj.model = "Camry"; // setting the model of the car
//////////////////////        obj.speed = 120; // setting the speed of the car

//////////////////////        obj.Start(); // calling the Start method of the vehicle class

//////////////////////        obj.DisplayDetails(); // calling the DisplayDetails method of the Car class

//////////////////////        obj.Stop(); // calling the Stop method of the vehicle class

//////////////////////        Console.ReadLine();
//////////////////////    }
//////////////////////}


//////////////////////====================================================
////////////////////// 4. Polymorphism
////////////////////// Polymorphism is the ability of an object to take on many forms.
////////////////////// It allows us to use a single interface to represent different types of objects.
////////////////////// In C#, polymorphism can be achieved through method overloading and method overriding.    
////////////////////// Method overloading allows us to define multiple methods with the same name but different parameters (compile-time polymorphism).
////////////////////// Method overriding allows us to redefine a method in a derived class that is already defined in the base class (run-time polymorphism).
////////////////////// Method overriding is achieved using the `virtual` keyword in the base class and the `override` keyword in the derived class.
////////////////////// C# also supports operator overloading, which allows us to define custom behavior for operators (e.g., +, -, *, /) for user-defined types.
////////////////////// Operator overloading is done by defining methods with the `operator` keyword.
////////////////////// Example of method overloading and overriding in C#:


////////////////////// function overloading

////////////////////using System;

////////////////////class PolymorphismDemo
////////////////////{
////////////////////    static void Main(string[] args)
////////////////////    {
////////////////////        // Calling the overloaded Add method
////////////////////        Console.WriteLine("Sum of two integers: " + Add(5, 10));
////////////////////        Console.WriteLine("Sum of three integers: " + Add(5, 10, 15));
////////////////////        Console.WriteLine("Sum of two doubles: " + Add(5.5, 10.5));
////////////////////        Console.ReadLine();
////////////////////    }
////////////////////    // Method overloading
////////////////////    static int Add(int a, int b)
////////////////////    {
////////////////////        return a + b;
////////////////////    }
////////////////////    static int Add(int a, int b, int c)
////////////////////    {
////////////////////        return a + b + c;
////////////////////    }
////////////////////    static double Add(double a, double b)
////////////////////    {
////////////////////        return a + b;
////////////////////    }
////////////////////}


//////////////////// method overriding
//////////////////using System;

//////////////////class Animal
//////////////////{
//////////////////    //static void function1()
//////////////////    //{
//////////////////    //    Console.WriteLine("Hello...i am from Animal class");    
//////////////////    //}
//////////////////    public virtual void Speak()
//////////////////    {
//////////////////       // function1();                    // Calling the static method from the Animal class
//////////////////        Console.WriteLine("Animal speaks");
//////////////////    }
//////////////////}





//////////////////class Dog : Animal
//////////////////{
//////////////////    public override void Speak()
//////////////////    {

//////////////////        Console.WriteLine("Dog barks");
//////////////////    }
//////////////////}




//////////////////class Cat : Animal
//////////////////{
//////////////////    public override void Speak()
//////////////////    {
//////////////////        Console.WriteLine("Cat meows");
//////////////////    }
//////////////////}






//////////////////class PolymorphismDemo
//////////////////{
//////////////////    static void Main(string[] args)
//////////////////    {
//////////////////        Animal myDog = new Dog(); // Upcasting
//////////////////        Animal myCat = new Cat(); // Upcasting

//////////////////        myDog.Speak(); // Calls the Speak method of Dog class
//////////////////        myCat.Speak(); // Calls the Speak method of Cat class

//////////////////        Console.ReadLine();
//////////////////    }
//////////////////}



////////////////// namespaces  demo


////////////////using System;

////////////////namespace mynamespace1
////////////////{
////////////////    class A
////////////////    {
////////////////      public void function1()
////////////////        {
////////////////            Console.WriteLine("mynamespace1 --A class-- function1() ");
////////////////        }
////////////////    } 
////////////////}

////////////////namespace mynamespace2
////////////////{
////////////////    class B
////////////////    {
////////////////        public void function2()
////////////////        {
////////////////            Console.WriteLine("mynamespace2 --B class-- function2() ");
////////////////        }
////////////////    }
////////////////}

////////////////namespace mynamespace3
////////////////{
////////////////    class C
////////////////    {
////////////////        public void function3()
////////////////        {
////////////////            Console.WriteLine("mynamespace3 --C class-- function3() ");
////////////////        }
////////////////    }
////////////////}


////////////////============================================================================

//////////////// operator overloading
//////////////// +, - .....

//////////////// Unary operator overloading

////////////using System;
////////////class Complex
////////////{
////////////    private int x;
////////////    private int y;
////////////    public Complex()                // default constructor 
////////////    {
////////////    }
////////////    public Complex(int i, int j)   // parameterized constructor
////////////    {
////////////        x = i;
////////////        y = j;
////////////    }
////////////    public void ShowXY()
////////////    {
////////////        Console.WriteLine("{0} {1}", x, y);
////////////    }
////////////    public static Complex operator -(Complex c)
////////////    {
////////////        Complex temp = new Complex();

////////////        temp.x = -c.x;
////////////        temp.y = -c.y;

////////////        return temp;
////////////    }
////////////}
////////////class MyClient
////////////{
////////////    public static void Main()
////////////    {
////////////        Complex c1 = new Complex(10, 20);
////////////        c1.ShowXY(); // displays 10 & 20

////////////        Complex c2 = new Complex();
////////////        c2.ShowXY(); // displays 0 & 0

////////////        c2 = -c1;
////////////        c2.ShowXY(); // diapls -10 & -20
////////////    }
////////////}

//////////////constructors 
////////////// A constructor is a special method that is called when an
////////////// object of a class is created.


//////////////using System;

//////////////class computer
//////////////{
//////////////    private string software;
//////////////    private string hardware;

//////////////    public computer()    //default constructor
//////////////    {       
//////////////        Console.WriteLine("deafult constructor is invoked");
//////////////    }

//////////////    public computer(string s1, string s2)       //parameterized constructor
//////////////    {
//////////////        software = s1;
//////////////        hardware = s2;

//////////////        Console.WriteLine(software+"    "+ hardware);
//////////////    }
//////////////}

//////////////class myclass
//////////////{
//////////////    static void Main(string[] args)
//////////////    {
//////////////        computer c1 = new computer();

//////////////        computer c2 = new computer("Hotel Managemnt", "mouse");


//////////////        Console.ReadLine();
//////////////    }
//////////////}
/////////////
////////////===========================================================================================

//////////// Properties in C#
//////////// Properties are a way to encapsulate data in a class.
//////////// They provide a way to get and set the values of private fields in a class
//////////// without exposing the fields directly.
//////////// Properties can have get and set accessors, allowing you to control how the data is accessed and modified.
//////////// Properties can also include validation logic in the set accessor to ensure that the data being assigned is valid.
//////////// Properties are defined using the `get` and `set` keywords.
//////////// They can be used to create read-only or write-only properties as well.
//////////// read only, write only, and read-write properties can be created using properties in C#.
//////////// auto implemnted property


//////////using System;

//////////class employee
//////////{
//////////    public int Id { get; set; }   // auto implemented property          //accessors
//////////    public string Name { get; set; }
//////////    public string Description { get; set; }

//////////    private string c="delhi";  // private field, can only be accessed within the class
//////////    public string city 
//////////    { 
//////////        get
//////////        {
//////////            return c;  // read only property, can only be accessed within the class
//////////        }
//////////    }  // read only property, can only be set in the constructor or within the class

//////////    private string c2;
//////////    public string country 
//////////    { 
//////////        set
//////////        {
//////////           c2=value;  // write only property, can only be set from outside the class
//////////        }
//////////    }// write only property, can only be set from outside the class
//////////}


//////////class myclass
//////////{
//////////    static void Main(string[] args)
//////////    {
//////////        employee e1 = new employee();
//////////        e1.Id = 1;
//////////        e1.Name = "anil";
//////////        e1.Description = "employee";

//////////        Console.WriteLine(e1.Id);
//////////        Console.WriteLine(e1.Name);
//////////        Console.WriteLine(e1.Description);

//////////        Console.WriteLine("City is : "+ e1.city);
//////////        e1.city = "Bangalore";   // Error, cannot set value to read only property
//////////        e1.country = "India";  // setting the value of the write only property
//////////        Console.WriteLine(e1.country);   // Error 


//////////        Console.ReadLine();
//////////    }
//////////}

//////////===========================================================================================

////////using System;
////////class Employee
////////{
////////    private int age;

////////    public int Age
////////    {
////////        get { return age; }
////////        set
////////        {
////////            if (value < 18)
////////                Console.WriteLine("Minimum age is 18.");
////////            age = value;
////////        }
////////    }
////////}
////////class Program
////////{
////////    static void Main()
////////    {
////////        Employee emp = new Employee();
////////        emp.Age = 2;
////////        Console.WriteLine("Age: " + emp.Age);
////////    }
////////}


////////=================================================
//////// stop the inheritance 
//////// sealed keyword

//////using System;

//////sealed class BaseClass
//////{
//////    public  void Display()
//////    {
//////        Console.WriteLine("Base class display method.");
//////    }
//////}

//////class derivedclass : BaseClass // This will cause a compile-time error because BaseClass is sealed
//////{
//////    public  void Display()
//////    {
//////        Console.WriteLine("Base class display method.");
//////    }
//////}

//////class mainclassA
//////{
//////    static void Main(string[] args)
//////    {
//////        BaseClass obj = new BaseClass();
//////        obj.Display(); // This will call the Display method of BaseClass


//////    }
//////}

//////=====================================================================

////// interfaces 
////// multiple inheritance xxxxx .net, java 
////// interfaces are used to achieve multiple inheritance in C#
////// An interface is a contract that defines a set of methods and properties that a class must implement.
////// Interfaces allow you to define a common set of behaviors that can be shared across different classes, regardless of their inheritance hierarchy.
////// A class can implement multiple interfaces, allowing for a form of multiple inheritance.
////// Interfaces are defined using the `interface` keyword, and classes implement them using the `:` symbol.
////// An interface can contain method signatures, properties, events, and indexers, but it cannot contain any implementation details (no method bodies).
////// Classes that implement an interface must provide concrete implementations for all of its members.
////// Interfaces can also inherit from other interfaces, allowing for a hierarchical structure of interfaces.
////// types : implicit , explicit
////// c# 8.0 ....definition of interface can have implementation details
////// after c# 8.0, interfaces can have default implementations for methods, properties, and events.


//////using System;

//////interface IAnimal
//////{
//////    void Speak(); // Method signature without implementation
//////}

//////class Dog : IAnimal // Implementing the IAnimal interface
//////{
//////    public void Speak() // Providing implementation for the Speak method
//////    {
//////        Console.WriteLine("Dog barks");
//////    }
//////}

//////class Cat : IAnimal // Implementing the IAnimal interface
//////{
//////    public void Speak() // Providing implementation for the Speak method
//////    {
//////        Console.WriteLine("Cat meows");
//////    }
//////}

//////class mainclass
//////{
//////    static void Main(string[] args)
//////    {
//////        Dog d1 = new Dog();
//////        d1.Speak();

//////        Cat c1 = new Cat();
//////        c1.Speak();


//////    }
//////}


////using System;

////interface IAnimal
////{
////    void Speak(); // Method signature without implementation
////}

////interface IAnimal2 // Another interface for demonstration
////{
////    void Eat(); // Method signature without implementation
////}

////class Dog : IAnimal,IAnimal2 // Implementing the IAnimal interface  //implicit 
////{
////    // Implicit interface implementation

////    //public void Eat()
////    //{
////    //    Console.WriteLine("Dog eats");
////    //}

////    //public void Speak() // Providing implementation for the Speak method
////    //{
////    //    Console.WriteLine("Dog barks");
////    //}

////    // Explicit interface implementation for IAnimal
////    void IAnimal.Speak()
////    {
////        Console.WriteLine("Dog barks");
////    }

////    void IAnimal2.Eat()
////    {
////        Console.WriteLine("Dog eats");
////    }
////    {
////        Console.WriteLine("Dog barks");
////    }

////}

////class Cat : IAnimal // Implementing the IAnimal interface
////{
////    public void Speak() // Providing implementation for the Speak method
////    {
////        Console.WriteLine("Cat meows");
////    }
////}

////class mainclass
////{
////    static void Main(string[] args)
////    {
////        Dog d1 = new Dog();
////        d1.Speak();
////        d1.Eat();

////        Cat c1 = new Cat();
////        c1.Speak();


////    }
////}

////=======================================================================

//// Abstract classes and methods
//// atleast 1 abstract function should be present in the abstract class
//// an abstract class cannot be instantiated directly


//using System;

//abstract class myabstractclass
//{
//    public abstract void Display(); // Abstract method with no implementation

//    public void Show() // Concrete method with implementation  // non abstract method
//    {
//        Console.WriteLine("This is a concrete method in the abstract class.");
//    }
//}

//class myclass : myabstractclass
//{
//    public override void Display() // Providing implementation for the abstract method
//    {
//        Console.WriteLine("This is the implementation of the abstract method in the derived class.");
//    }
//}

//class mainclass
//{
//    static void Main(string[] args)
//    {
//        //myabstractclass obj= new myabstractclass();
//        //obj.Display(); // This will cause a compile-time error because myabstractclass is abstract

//        myclass obj1= new myclass();
//        obj1.Display(); // Calling the overridden method in the derived class
//    }
//}