# C# Learnings

Contents: 


**C# beginners**
- Intro to c# and .NET
- Primitive Types and Expressions
- Non-Primitive Types
- Control Flow
- Arrays and Lists
- Working with dates
- Working with text
- Working with files
- Debugging apps

**C# intermediate**
- Classes
- Association between classes
- Inheritance - second pillar of OOP
- Polymorphism - third pillar of OOP
- Interfaces

**C# advanced**
- Generics
- Delegates
- Lambda Expressions
- Events
- Extension Methods
- LINQ
- Nullable Types
- Dynamic
- Exception Handling
- Asynchronous Programming

---


# START OF BEGINNER C# 


### Intro to c# and .NET
c# vs .NET 
- c# is a programming language 
- .NET is a framework for building apps on windows 

.NET
- CLR (common language runtime)
- class library for building apps

CLR 
- solves problem of running compiled code on different operating systems (compiles to intermediate code, IL code)
- CLR compiles IL to native machine code (just in time compilation)

Architecture of .NET Apps
- Apps will have building blocks called 'classes'
- A class will have data (attributes) and methods (or functions)
- Data represents state
- Methods represent behaviour 
- I.e. a Car has attributes of make, model, color. Its functions are Start() and Move()

- To organise classes, we use "Namespace" => a container for related classes
- Namespace for data, namespace for security, etc 

- An assembly is a container for related namespaces (DLL or EXE)

- When you build an app, it builds one or more assemblies depending on how you partition your code 

Creating your first c# App
- When you're in a namespace, you have access to all other classes within that namespace
- If you want access to another namespace, you'll need to import it using the 'using' syntax 

````c#
static void Main(string[] args)
{
}
````
methods have an output type (in this case void - it means nothing) and an input type (in this case an array of strings, argsS)

---

### Primitive Types and Expressions 

Variables and Constants 
- Variable: a name given to a storage location in memory
- Constant: an immutable value 
- Declaring variables / constants
````c#
int Number; //note: you cannot compile unless you've used it, like below
int Number = 1;
const float Pi = 3.14f; //a const needs to be defined
````
- Identifiers cannot start with a number, i.e. ``1route`` will not work, instead use ``oneRoute``
- Identifiers cannot use white space, i.e. ``one Route``
- Identifiers cannot be a reserved keyoword, i.e. ``int``

Naming Conventions
- for local variables use camelCase: ``int oneRoute;``
- for constants use PascalCase: ``const int MaxZoom = 5;``

Most commonly used primitive types:


Integral Numbers
- byte (0 to 255)
- short (-32,768 to 32,767)
- int (-2.1b to 2.1b)
- long (...even more)
Real Numbers
- float
- double
- decimal
Character
- char
Boolean
- bool

Non-Primitive types
- string
- array
- enum
- class

---

Overflowing
````c#
byte number = 255; //largest number that can be stored in a byte
number = number + 1; //now overflows to zero!

//to stop overflowing, you need to do this: 
checked 
{
  byte number = 255; 
  number = number + 1; //now an exception will be thrown, and the program will crash unless we handle the exception.
  //rare this is ever used lol
}
````

---

Scope 
- Where a variable / constant has meaning
````c#
{
  byte a = 1; // access only to a
  {
    byte b = 2; //access to a and b
    {
      byte c = 3; //access to a, b and c
    }
  }
}
````

Type Conversion
- Implicit type conversion
````c#
byte b = 1; // 00000001
int i = b; // 00000000 00000000 0000000 00000001
// the compiler is 100% sure that no data loss will happen, data types can be converted implicitly

int i = 1;
byte b = i;
// this won't compile, because an integer is 4 bytes - so there is a chance for data loss! 
// in this example, no data loss will happen. but it will need to be explicitly converted.
````
- Explicit type conversion (type casting)
````c#
int i = 1;
byte b = (byte)i;

float f = 1.0f;
int i = (int)f;
````
- Conversion between non-compatible types
````c#
string s = "1";
int i = (int)s; //wont compile, needs to be converted to an int first. Either convert class or parse method

string s = "1";
int i = Convert.ToInt32(s);
int j = int.Parse(s); //imo this is better..
````


---

Operators 


Arithmetic
- Add +
- Subtract - 
- Multiply *
- Divide /
- Remainder %
- Increment ++ 
````c#
//postfix increment: 
int a = 1; 
int b = a++; 
//a = 2, b = 1

//prefix increment
int a = 1;
int b = ++a;
//a = 2, b = 2
````
- Decrement --


Comparison 
- Equal ==
- Not equal !=
- greater than >
- greater than or equal to >=
- less than <
- less than or equal to <=

Assignment
- assignment =
- addition assignment +=, ``a += 3`` i.e ``a = a + 3``
- subtraction assignment -=
- multiplication assignment *=
- division assignment /=

Logical
- And && 
- Or ||
- Not !

Bitwise
- And &
- Or | 


### Non-primitive Types
- Classes
- Structures
- Arrays
- Strings 
- Enums
- Reference types vs value types 

Classes
- Fields / attributes
- Methods / functions (behaviour)
- When you instantiate a class, you get an object. When you run your application - its the objects talking to eachother and collaborating to provide some functionality. 
````c#
namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Mark";
            person.Introduce();
        }
    }

    public class Person
    {
        public string Name;

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + Name);
        }
    }
}
````
- to create an object, you need to allocate memory for them (unlike primitive types). I.e. var person = new Person();
````c#
public class Calculator
{
  public static int Add(int a, int b)
  {
    return a + b;
  }
}
````
- static modifier => we do not have to create an object to access a static method in a class
- i.e. ``var result = Calculator.Add(1, 2) //3``
- Note: you only want to have one class per file. To move a class to a new file, put cursor on class name and hit alt + enter and select "Move to Person.cs"
- If you create a new class unrelated to your other class, its best to use a new namespace. Simply create a file in the app, and move the unrelated class to this namespace. The convention is to use the origional namespace and put .whatever the file name was. I.e. if the outside namespace is "HelloWorld" but you've made a math file, the namespace in there should be "HelloWorld.Math"

--- 

Structs or "Structures"
- very similar to a class, but instead of using the class keyword, we use 'struct'
````c#
public struct RgbColor
{
  public int Red;
  public int Green;
  public int Blue;
}
````
- Use a structure when you want to define a small, lightweight object 

---

Arrays
- tbh not used much, lists are used now...
- declaring arrays ``int[] numbers = new int[3];`` makes an array of 3 integers
- accessing array using index ``numbers[0] = 1;``, ``numbers[1] = 2;``, ``numbers[2] = 3;`` etc
- can use object initialisation syntax instead: ``int[] numbers = new int[3] { 1, 2, 3};``

Strings
- surrounded by double quotes "hmm"
- using string literals: ``string firstName = "Mark";``
- using string concatenation ``string name = $"{firstName} {secondName}";``
- using string join ``var numbers = new int[3] {1,2,3};`` => ``string list = string.Join(",", numbers)``
- access string characters using index ``list[0];`` would be 1
- escape characters: ``\n`` new line ``\t`` tab ``\\`` backslash ``\'`` single quotation mark ``\"`` double quotation mark
- verbatim strings (don't have to use special characters), just prefix with @ like: ``string path = @"c:\projects\project1\folder1";``
````c#
static void Main(string[] args)
{
    String firstName = "Mark"; //string class in .net framework (need to import the class!)
    string myName = "hmm"; //string keyword in c#
}
````
- Note: ALWAYS use $"{var} {anothervar}" to use variables. and to use strings with special characters ALWAYS use @"c:\projects"

---

Enums 
- Use enums where you have a number of related constants, i.e. 
````c#
public enum ShippingMethod
{
  RegularAirMail = 1, //note if you don't set them, the first value will be set to 0. I think better to be explicit!
  RegisteredAirMail = 2,
  Express = 3
}

var method = ShippingMethod.Express;
````
````c#
public enum ShippingMethod
{
    RegularAirMail = 1, 
    RegisteredAirMail = 2,
    Express = 3
}
class Program
{
    static void Main(string[] args)
    {
        var method = ShippingMethod.Express;
        System.Console.WriteLine(method); // this will show "Express"
        System.Console.WriteLine((int)method); // this will show "3"

        var methodId = 3;
        System.Console.WriteLine((ShippingMethod)3); // can also reverse-cast!

        // convert string to a shippingMethod => need to parse!
        var shippingMethod = Enum.Parse(typeof(ShippingMethod), "Express");

        Console.WriteLine(shippingMethod);
    }
}
````

Reference Types and Value Types
- We have two main types from which we create new types
- Structures and classes
- Structures:
  - primitive types
  - custom structures
- Classes:
  - Arrays
  - strings
  - custom classes
- Structures are value types, classes are reference types 
- Value types:
  - allocated on stack
  - memory allocation done automatically 
  - immediately removed when out of scope
- Reference types
  - you need to allocate memory (i.e. by using the new operator.. ``var person = new Person();`` )
  - memory allocated on heap (when out of scope, it wont be removed immediately)
  - garbage collected by CLR 
````c#
static void Main(string[] args)
{
    var a = 10;
    var b = a;
    b++;
    // integers are value types. when we copy it, it is stored in the target location in memory.
    Console.WriteLine($"{a} A and {b} B"); // a is 10, b is 11

    var array1 = new int[3] { 1, 2, 3 };
    var array2 = array1;
    array2[0] = 0;
    Console.WriteLine(array1[0]); // array1[0] is 0!
    Console.WriteLine(array2[0]); //array2[0] is 0. Array1 and array2 are pointing to the same object on the heap
}
````

````c#
public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number); // number will be 1, since it is a value type

            var person = new Person();
            person.Age = 10;
            MakeOld(person);
            Console.WriteLine(person.Age); //age will be 20, since it is a reference type and needs to be made using the new keyword
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
````

### Control Flow 

Conditional Statements
- if / else
````c#
//all good for 1 line of code
if (condition)
  someStatement

else if (anotherConditon)
  anotherStatement

else
  yetAnotherStatement 

// for more than 1 line of code
if (condition)
{
  someStatement
  anotherStatement
}
````
- switch / case
````c#
switch(role)
{
  case Role.Admin:
    ...
    break;
  case Role.Moderator:
    ...
    break; 
  default:
    ...
    break;
}
````
- conditional operator => a ? b : c


Iteration Statements
- For loops
````c#
for (var i = 0; i < 10 ; i++) // counter ; condition ; increment for each repeat
{
  ...
}
````
- foreach loops
````c#
foreach (var number in numbers)
{
  //numbers is the array
}
````
- while loops
````c#
while (i<10)
{
  ...
  i++; //similar to for loop but has a diff syntax
}
````
- do-while loops
````c#
do
{
  ...
  i++;
} while (i<10); //gross... do not use, just use for and foreach lol
````

break and continue
- break: jumps out of the loop
- continue: jumps to the next iteration

````c#
var name = "John Smith";
for (var i = 0; i < name.Length; i++)
{
    Console.WriteLine(name[i]);
}

foreach (var letter in name)
{
    Console.WriteLine(letter);
}
````

````c#
// while loops are better if you dont know how many times it will run.

while (true)
{
    Console.Write("Type your name: ");
    var input = Console.ReadLine();

    if (String.IsNullOrWhiteSpace(input))
        break; //jumps out of loop

    Console.WriteLine($"@Echo: {input}");
}
````
using random and casting for ascii:
````c#
var random = new Random();
for (var i = 0; i < 10; i++)
{
    var randomNum = random.Next(97, 122);
    Console.WriteLine(randomNum);
    Console.WriteLine((char)randomNum); //ascii
}
````

````c#
var random = new Random();
const int passwordLength = 10;
var buffer = new char[passwordLength];

for (var i = 0; i < passwordLength; i++)
{
    var asciiMin = 97;
    var asciiMax = 122;
    var randomNum = random.Next(asciiMin, asciiMax);
    buffer[i] = (char)randomNum;
}

var password = new string(buffer);
Console.WriteLine(password);
````

---

### Arrays and Lists

Arrays
- Represents a fixed number of variables of a particular type
- Single dimension arrays 
``var numbers = new int[5] {1, 2, 3, 4, 5}``
- OR multidimension arrays (like a matrix)
- Either rectangular or jagged
  - Rectangular like 3x5 
  - Jagged is like an array of arrays => this is faster! 
- Syntax for rectangular array:
````c#
var matrix = new int[3, 5]; //.. can also do new int[3, 4, 5] for 3 dimensions
//or 
var matrix = new int[3, 3]
{
  {1, 2, 3}
  {4, 5, 6}
  {7, 8, 9}
}
var element = matrix[0, 0] //1
var element = matrix[2, 2] //9
````
- Syntax for jagged array: (array of arrays)
````c#
//0, 1, 2, 3
//0, 1, 2, 3, 4
//0, 1, 2
var array = new int[3][]; //first bracket: number of elements in top level array
array[0] = new int[4];
array[1] = new int[5];
array[2] = new int[3];
array[0][0] = 1; //set new value
````


Lists
- Array has a fixed size, list has a dynamic size 
- ``var numbers = new List<int>();`` a list is a generic type, so in the angled brackets we specify the type. You can create a list of anything! 
- initialise like so: ``var numbers = new List<int>() {1, 2, 3, 4, 5};``
- useful methods:
  - Add() to add an object
  - AddRange() to add a list of objects (another list or array)
  - Remove() to remove one object from a list
  - RemoveAt() to remove an object at the given index of the list
  - IndexOf() to get the index of a given object
  - Contains() which tells us if the list contains the given object or not 
  - Count, which returns the number of objects in the list 


- We use lists 99.9% of the time!

---

### Working with Dates
- ``var dateTime = new DateTime()``
- DateTime: 
````c#
static void Main(string[] args)
{
    var dateTime = new DateTime(2015, 1, 1);
    Console.WriteLine(dateTime);

    //to get current datetime:
    var now = DateTime.Now;
    Console.WriteLine(now);
    var today = DateTime.Today;
    Console.WriteLine(today);

    Console.WriteLine(now.Hour);
    Console.WriteLine(now.Minute);

    //DateTime objects in c# are immutable
    var tomorrow = now.AddDays(1);
    var yesterday = now.AddDays(-1);

    //convert to string 
    Console.WriteLine(now.ToLongDateString()); //only date
    Console.WriteLine(now.ToShortDateString());
    Console.WriteLine(now.ToShortTimeString()); //only time
    Console.WriteLine(now.ToLongTimeString());

    Console.WriteLine(now.ToString()); //displays both
    Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
}
````
- TimeSpan:
````c#
static void Main(string[] args)
{
    //Creating timeSpan objects:

    //timespan is a length of time! 
    var timeSpan = new TimeSpan(1, 2, 3);

    //duration 1hr
    var timeSpan2 = new TimeSpan(1, 0, 0);
    var timeSpan1 = TimeSpan.FromHours(1); //more readable

    var start = DateTime.Now;
    var end = DateTime.Now.AddMinutes(2);
    var duration = end - start; //this creates a timespan

    Console.WriteLine(duration);

    //Timespan Properties:
    Console.WriteLine(timeSpan.TotalMinutes); //62.05
    Console.WriteLine(timeSpan.Minutes); //2

    //Add (similar to dateTime, it is immutable. but provides add and subtract (returns new timespan)
    Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(8)));

    //Subtract
    Console.WriteLine(timeSpan.Subtract(TimeSpan.FromMinutes(2)));

    //conversion to and from string 
    timeSpan.ToString();
    TimeSpan.Parse("01:02:03"); //this returns a timespan object
}
````

---

### Working with Text
Strings
- A class
- Immutable 
- Methods
  - ToLower() //all charcters to lower case
  - ToUpper() //all characters to upper case
  - Trim() gets rid of white spaces around a string
  - IndexOf('a'), LastIndexOf("Hello") .. returns index
  - Substring(startIndex), Substring(startIndex, length)
  - Replace('a', '!'), Replace("Mark", "Mosh")
  - String.IsNullOrEmpty(str), String.IsNullOrWhiteSpace(str)
  - str.Split(' '), splits by empty character.. returns array of strings
- Converting strings to numbers
````c#
string s = "1234";
int i = int.Parse(s);
int j = Convert.ToInt32(s); //he prefers this, need to catch the int.Parse way
````
- Converting numbers to strings
````c#
int i = 1234;
string s = i.ToString(); // "1234"
string t = i.ToString("C"); // "$1,234.00" => "C" is a format string short for currency. 
string t = i.ToString("C0"); // "$1,234"
````
````c#
static void Main(string[] args)
{
    var fullName = "Mark Janssen ";
    Console.WriteLine( $"'{fullName.Trim()}'");
    Console.WriteLine($"{ fullName.ToUpper()}");

    var index = fullName.IndexOf(' ');
    var firstName = fullName.Substring(0, index);
    var lastName = fullName.Substring(index+1);
    Console.WriteLine(firstName);
    Console.WriteLine(lastName);

    var names = fullName.Split(' ');
    Console.WriteLine(names[0]);
    Console.WriteLine(names[1]);

    var newName = fullName.Replace("Mark", "Merk");
    Console.WriteLine(newName);

    if (String.IsNullOrWhiteSpace(" "))
        Console.WriteLine("Invalid");

    var str = "25";
    var age = Convert.ToInt32(str);
    Console.WriteLine(age);

    float price = 29.95f;
    Console.WriteLine( price.ToString("C")); //every object in dotnet has a ToString method
}
````

StringBuilder
- Defined in System.Text
- a Mutable string
- easy and fast to create and manipulate strings
- string manipulation methods
  - Append()
  - Insert()
  - Remove()
  - Replace()
  - Clear()

````c#
static void Main(string[] args)
{
    var builder = new StringBuilder("Hello World");
    // builder will not have any methods to search for a character of a string
    builder.Append('-', 10)
            .AppendLine()
            .Append("Header")
            .AppendLine()
            .Append('-', 10);
    //all these return a string builder, can chain them! 
    builder.Replace('-', '+');

    builder.Remove(0, 10);

    builder.Insert(0, new string('-', 10));
    Console.WriteLine(builder);

    Console.WriteLine( builder[0] );
}
````

Procedural Programming (functional programming)
- Paradigm based on procedure calls (functions / methods etc)
- Break down code into a number of methods all responsible for one thing
  - You should always seperate the code that works with the console, from the code that does some logic
  - i.e. console is only relevant in console applications

Object Oriented Programming
- A paradigm based on objects

---

### Working with Files
System.IO Namespace
- includes classes:
  - File, FileInfo
    - provide methods for creating, copying, deleting, moving and opening of files
    - fileInfo: provides instance methods
    - file provides static methods
      - create()
      - copy()
      - delete()
      - exists()
      - getAttributes()
      - Move()
      - ReadAllText()
  - Directory, DirectoryInfo
    - DirectoryInfo provides instance methods 
    - Directory: provides static methods
      - CreateDirectory()
      - Delete()
      - Exists()
      - GetCurrentDirectory()
      - GetFiles()
      - Move()
      - GetLogicalDrives()
  - Path
    - GetDirectoryName()
    - GetFileName()
    - GetExtension()
    - GetTempPath()


---


### Debugging Applications
Debugging Tools in Visual Studio
- Put one or more breakpoints in your application
- Run application in debug mode:
  - When it hits a debugged line, f10 or "step over" executes 1 line at a time 
  - you can drag the yellow arrow up to move it to another part to debug 
  - use f11 or "step into" to see what is happening inside a function
  - watch window: Debug => Windows => Watch => Watch1. 
    - Watch window allows you to enter variables by name and watch them over time 
    - if a value changes, it will be indicated by red 
  - press "continue" or f5 again to continue to the next break point
- to get rid of all break points: debug => delete all breakpoints
- if program is throwing exception, you can run in debug mode without breakpoints and it will show you where!

Removing Side Effects
- In his example, he's removing items from the original list (which was a reference type since it was an object) - the side effect is that it affects the original list!
- Instead make a copy of that list, i.e. by instantiating a new List and copying the old one into it. 
Defensive Programming
````c#
public static List<int> GetSmallests(List<int> list, int count)
{
    if (list == null)
        throw new ArgumentNullException("list");

    if (count > list.Count || count <= 0)
        throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of elements in the list");

    var buffer = new List<int>(list);
    var smallests = new List<int>();
    while (smallests.Count < count)
    {
        var min = GetSmallest(buffer);
        smallests.Add(min);
        buffer.Remove(min);
    }
    return smallests;
}
````
Call Stack Window
- Start program in debug mode with a breakpoint
- debug => windows => callstack 
  - item on the bottom of the list is where you started
  - item on the top of the list is where you are now
  - you can click around in the callstack and it will bring you to the place
Locals and Autos Windows
- watch window can get a bit tedious to type variables 
- autos and locals (below watch) 
- autos is like watch but with automatic list of variables 
- locals window just shows variables in local scope
- debug => windows => autos or locals


---


# END OF BEGINNER C#


--- 


# START OF INTERMEDIATE C#


### Classes
Introduction
- A class is a building block of a software application
- Real world example
  - Presentation / API
  - Business logic / Domain
  - Data Access / Persistence - (Repository)
- Anatomy
  - data (represented by fields)
  - behavior (methods or functions)
- Declaring classes we use PascalCase
````c#
public class Person
{
  public string Name; //we wouldn't normally use public 
  public void Introduce()
  {
    Console.WriteLine($"Hello, my name is {Name}");
  }
  public static void Welcome()
  {
    Console.WriteLine("Welcome to the jungle");
  }
}

//instantiate object
var mark = new Person();
mark.Name = "Mark";
mark.Introduce();
Person.Welcome();
````
- Introduce() is an instance method, accessible from an instance of the object
- Welcome() is a static method, accessible from the class
- Why use static members?
  - to represent concepts that are singleton (only one instance of this concept in the memory)
  - DateTime.Now (it doesn't make sense to have different objects telling us that now has a different value)
- Example of a static method:
````c#
public class Person
{
    public string Name;

    public void Introduce(string to)
    {
        Console.WriteLine($"Hi {to}, I am {Name}");
    }

    public static Person Parse(string str)
    {
        var person = new Person();
        person.Name = str;

        return person;
    }
}
class Program
{
    static void Main(string[] args)
    {
        var person = new Person();
        person.Name = "Mark";
        person.Introduce("Mosh");

        var person2 = Person.Parse("John");
        person2.Introduce("Bob");
    }
}
````


Constructors
- A constructor is a method that is called when an instance of a class is created
- to put object in an early state (initializing some of the fields of the class)
- it will be the same name as the class itself
````c#
public class Customer
{
  public string Name;
  public Customer()
  {
    this.Name = name;
  }
}

//var customer = new Customer("John");
````
- Constructor overloading
  - overloading means having a method with the same name but different signatures (i.e. its return type, or parameters, or both)
````c#
public class Customer
{
  public Customer() { ... }
  public Customer(string name) { ... }
  public Customer(int id, string name) { ... }
}
````
- we only use constructors in classes where we REALLY want to initialize that object for early state
- ``public List<Order> Orders;`` creates a object of type List, and the generic parameter (in <>) takes a type, so in this case we can store items of type Order in this list.
- as a rule of thumb / best practice, whenever you have a class that has a list of objects of any type. ALWAYS initialise that to an empty list, in the default constructor. i.e. ``Orders = new List<Order>();``
  - this is because Orders will not be initialized, so when its referenced it will be set to null
  - BEST to do it in the constructor. The responsibility of initializing the Orders will be the responsibility of the customers class
  - If you've got multiple constructors that all need this initilized Orders then... inherit from the other constructor with "this()" => it will inherit from the function of the same name without arguments
  ````c#
  public Customer()
  {
      this.Orders = new List<Order>();
  }

  public Customer(int id)
      : this()
  {
      this.Id = id; // + this.Orders
  }

  public Customer(int id, string name)
      : this(id)
  {
      this.Name = name; // + this.Orders + this.Id (chained initialisation!)
  }
  ````
- the use of "this()" is a bit confusing - just use it when you need to! 


Object Initializeers
- another way to initialize an object
- simply syntax for quickly initialising an object, without having to use a constructor (to avoid creating multiple constructors)
````c#
var person = new Person
{
  FirstName = "Mark",
  LastName = "Janssen"
};
````
- the default (paramaterless) constructor will be called, and then these properties initialised.
- this is favoured, so we can reserve constructors only when we REALLY need to use them.


Methods
- Signature of methods
  - name, number and type of parameters
- Method overloading
  - having a method with same name but different signatures
  - not great to use method overloading if you dont have to, i.e.:
  ````c#
  public class Calculator
  {
    public int Add(int n1, int n2) {}
    public int Add(int n1, int n2, int n3) {}
    public int Add(int n1, int n2, int n3, int n4) {} //..etc
  }
  // instead use: 
  public class Calculator
  {
    public int Add(int[] numbers) {}
  }
  var result = calculator.Add(new int[] {1, 2, 3, 4});
  // even easier to use PARAMS MODIFIER (look below)
  ````
- Params modifier
````c#
public class Calculator
{
  public int Add(params int[] numbers) {}
}
var result = calculator.Add(1, 2, 3, 4); //.. then we dont have to initialise a new int array each time. 
````
- Ref modifier (he says codesmell)
````c#
public class MyClass
{
  public void MyMethod(int a)
  {
    a+=2;
  }
}
var a = 1;
myClass.MyMethod(a); // will return 1

//the ref modifier:
public class Weirdo
{
  public void DoAWeirdThing(ref int a)
  {
    a += 2;
  }
}
var a = 1;
weirdo.DoAWeirdThing(ref a); //original a gets modified, value will be 3. He doesn't like it, don't do it, just know if someone else does it.
````
- Out modifier (he says codesmell)
````c#
public class MyClass
{
  public void MyMethod(out int result)
  {
    result = 1;
  }
}
int a;
myClass.MyMethod(out a);
````
- When an exception is thrown, its better that you explicitly state the exception and mention the variable that is causing it
  - i.e. 
  ````c#
  public void Move(Point newLocation)
  {
      if (newLocation == null)
          throw new ArgumentException("newLocation");

      Move(newLocation.X, newLocation.Y);
  }
  ````
- To stop the program from crashing, you need to use a try/catch block, i.e.:
````c#
try
{
    var point = new Point(10, 20);
    point.Move(null);
    Console.WriteLine(point.X);
    Console.WriteLine(point.Y);

    point.Move(100, 200);
    Console.WriteLine(point.X);
    Console.WriteLine(point.Y);
}
catch (Exception)
{
    Console.WriteLine("Error occured, in catch block");
}
````

Fields
- Initialization
  - using the constructor, forces some fields to exist
- Read-only fields
  - using the readonly modifier, we can make sure that field is only assigned once. 
````c#
public class Customer
{
  public int Id;
  public string Name;
  //public List<Order> Orders;
  //public List<Order> Orders = new List<Order>(); // can initialize like this!
  readonly List<Order> Orders = new List<Order>(); // can be initialized here or in one of the constructors of the class
}
````


Access Modifiers
- A way to control access to a class / its members
- Used to create safety in our programs
- Types: 
  - Public
  - Private
  - Protected
  - Internal
  - Protected Internal

````c#
public class Customer
{
  private string Name;
}

var john = new Customer();
john.Name; // won't compile - we can't access a private field!
````
- This is the beginning of OOP
  - encapsulation / information hiding (access modifiers!)
  - inheritance
  - polymorphism
- Encapsulation (in practice)
  - define fields as private
  - provide getter / setter methods as public
````c#
public class Person
{
  private string Name;

  public void SetName(string name)
  {
    if (!String.IsNullOrEmpty(name))
      this.Name = name;
  }

  public string GetName()
  {
    return Name;
  }
}
````
- the convention is to start private fields with an underline:
````c#
public class Person
{
  private string _name;

  public void SetName(string name)
  {
    this._name = name;
  }

  public string GetName()
  {
    return _name;
  }
}
````


Properties
- Help us achieve the same as above (getters and setters) with less code
- They are class members that encapsulate a getter/setter for accessing a field
- Why? to create a getter/setter with less code
````c#
// less code than above
public class Person
{
  private string _name;

  public string Name
  {
    get { return _name; }
    set { _name = value; }
  }
}
````
- even better to use "auto-implemented properties"
````c#
public class Person
{
  public string Name  {get; set; }
}
````
- with above syntax, dotnet internally creates a private field with a get and a set accessor methods
- convention is to put properties on the top, a vertical space, then the constructor.

Indexers
- A way to access elements in a class that represent a list of values
```c#
var array = new int[5];
array[0] = 1;

var cookie = new HttpCookie();
cookie.Expire = DateTime.Today.AddDays(5);

cookie["name"] = "Mark"; //this is an indexer also!
```
- To declare an indexer.. an indexer is exactly like a property. 
````c#
public class HttpCookie
{
  public string this[string key]
  {
    get { ... }
    set { ... }
  }
}
````
- If you are working with a class that has the semantics of a collection, a list, or a dictionary, you can improve your code by using an indexer


### Association between classes


Class Coupling
- measure of how interconnected systems and subsystems are
- to design a loosely coupled application...
  - encapsulation (not needing to know certain things aka access modifiers)
  - the relationships between classes (this section)
  - interfaces
- types of relationships
  - inheritance 
  - composition
  - favour composition over inheritance, composition results in less coupling


Inheritance
- What is inheritance?
  - A kind of relationship between two classes that allows one to inherit code from the other
  - Is-A
  - i.e: A car is a Vehicle
- What are the benefits?
  - code re-use
  - polymorphic behaviour
- UML Notation (unified modelling language, used to graphically represent how classes interact)
  - i.e. base / parent class "PresentationObject"
  - derived / children classes "Text", "Table", "Image"
  - in c#, a class can have only one parent
- Syntax
````c#
public class PresentationObject
{
}
public class Text : PresentationObject
{
}
````


Composition
- What is composition
  - A kind of relationship between two classes that allows one to contain the other 
  - Has-a relationship
  - Example: Car has an Engine
- What are the benefits
  - code re-use
  - flexibility
  - a means to loose-coupling
  - i.e. DbMigrator requires logging, and Installer requires logging. 
- UML Notation
  - DbMigrator and Installer both have a composition relationship to the logger class
- Syntax
  - it is simply a private field in the class
````c#
public class Installer
{
  private Logger _logger;

  public Installer(Logger logger)
  {
    _logger = logger;
  }
}
````


Favour Composition over Inheritance
- Problems with Inheritance
  - Easily abused by amateur designers / developers
  - Large hierachies
  - Fragility
  - Tight coupling
    - if you change the parent class, the children will be affected possibly adversely 
- Advantages of Composition over inheritance
  - Any inheritance relationship can be translated to Composition
  - i.e. theres an "Animal" class that "Person" and "Dog" classes inherit through. If we then introduce a Walk() method to "Animal", but then add a "Goldfish" class that inherits through animal, its broken because gold fish can't walk
  - Instead we could have a composition between the creature, and a class "Animal" and a class "Walkable". Since a class can have only one inheritance, this can't be done. But it can have as many compositions as it wants, so it can be done via composition. 


- Benefits of Composition
  - great flexibility
  - eventually loose coupling
- 2 types of relationships between classes
  - inheritance (Is-a)
  - composition (Has-a)


- Inheritance
  - Pros: code re-use, easier to understand
  - Cons: Tightly coupled- fragile, can be abused

- Composition
  - Pros: code re-use, great flexibility, loose coupling
  - Cons: a little harder to understand


- Inheritance is not necessarily a bad thing
- Use both inheritance and composition


### Inheritance - second pillar of OOP
Access Modifiers
- Why Access Modifiers are Important
- Black box metaphor
  - "we don't know whats inside" - think of a dvd player, we just get a button or a light or something. Our object also should have limited visibility from the outside
  - this helps to isolate changes!
  - the light or button that we see from the outside is the public interface 
- C# access modifiers
  - public
    - accessible from everywhere
  ````c#
  public class Customer
  {
    public void Promote() {...}
  }
  var customer = new Customer();
  customer.Promote();
  ````
  - private
    - accessible only from the class
  - protected
    - accessible only from the class and its derived classes
    - big issue with encapsulation ... we don't want this, it will be super coupled. BREAKS ENCAPSULATION 
    - bad design, do not use
  - internal
    - accessible only from the same assembly
    ````c#
    internal class RateCalculator
    { 
    }
    ````
  - protected internal
    - Accessible only from the same assembly or any derived classes
    - Mosh thinks its the weirdest thing in c#
    - also violates encapsulation
    - bad for writing, reading and interpreting code
    ````c#
    public class Customer
    {
      protected internal void Weirdo() {...}
    }
    ````

- Sounds like better to use private by default, only make public what you need to and avoid protected / internal / protected internal... 
- however some design patterns use this...


Constructors and Inheritance
- Base class constructors are always executed first
  - the default (or parameterless) constructor specifically
- Base class constructors are not inherited
  - A constructor defined in the base will not be defined in the child class, you need to redefine it 
  - nor will the fields - you need to use this syntax to inherit private fields from the parent class:
  ````c#
  public class Car : Vehicle
  {
    public Car(string registrationNumber)
      : base(registrationNumber) //this lets you access the base class, the constructor of the vehicle class.
    {
      // initalise fields specific to the car class
    }
  }
  ````

Upcasting and Downcasting
- Conversion from a derived class to a base class (upcasting)
  - like casting an object back up to its parent
  - they're both pointing to the same object in memory, which is why its so safe to do
- Conversion from a base class to a derived class (downcasting)
  - casting a parent down to its child
- The as and is keywords
````c#
public class Shape 
{}
public class Circle : Shape
{}

//upcasting
Circle circle = new Circle();
Shape shape = circle; //implicit conversion - converting a child to its parent 

//downcasting
Circle anotherCircle = (Circle)shape; //explicit conversion - converting a parent to its child 
// note - this can cause an invalid cast exception, i.e:
Car car = (Car)shape; //throws InvalidCastException
````
- A safer way to do downcasting is to use the as keyword 
````c#
Car car = (Car) obj;
Car car = obj as Car; //this won't throw an exception, but null instead.
if (car != null)
{
  ...
}
````
- We also have the is keyword
````c#
if (obj is Car) //check the type of an object, if it is, do it! better to use as imo..
{
  Car car = (Car) obj; 
}
````


Boxing and Unboxing
- Boxing is the process of converting a value type instance to an object reference
````c#
int number = 10;
object obj = number;
//or
object obj = 10;
````
- unboxing is the opposite of boxing, it converts an object reference type to a value type
````c#
object obj = 10;
int number = (int)obj; //unboxed!
````
- boxing / unboxing have a performance penality - avoid if possible.


- Value types and reference types
- Value types
  - Sorted on the stack
  - all primitive types: byte, int, float, char bool
  - the struct type
  - short lifetime
- Reference types
  - sroted in the heap
  - Any classes (object, array, string, custom classes that we make, etc)
- an object reference can be implicitly converted to a base class reference
- the Object class is the base of all classes in .NET framework
````c#
Circle circle = new Circle(); //child of shape
Shape shape = circle;
object shape = circle;
````


### Polymorphism - third pillar of OOP


Method Overriding
- Method overriding
  - modifying the implementation of an inherited method
  - overriding is overriding the base class's method, overloading is having a method with the same name but different signatures
- Virtual / override keywords
````c#
public class Shape
{
  public virtual void Draw() //the virtual keyword gives us the ability to change the implementation in a derived class
  {}
}

public class Circle : Shape
{
  public override void Draw() //override keyword is that this method will be run instead of the one in shape on a Cirlce object
  {}
}
public class Image : Shape
{
}
````
- Instead of using a switch statement, should always use polymorphism! 


Abstract Classes and Members
- Abstract modifier
  - Indicates that a class or a member is missing implementation
  - i.e. derived (children) classes need to provide implenetation detail
````c#
public abstract class Shape
{
  public abstract void Draw();
}

public class Circle : Shape
{
  public override void Draw()
  {
    //impelemention detail
  }
}
````
- Rules about abstract classes and members
  - abstact member cannot include implementation (no body, simply a decleration)
  - if a member is declared as abstract, the containing class needs to be declared as abstract too
  - derived class (of abstract class) must implement all abstract members in the base abstract class. 
  - an abstract class cannot be instantiated
- Why use abstract?
  - provide common behavior, and force other developers to follow your design
  - stops us from accidently creating bugs by forgetting to create implementation


Sealed Classes and Members
- the opposite of abstract classes
- prevents derivation of classes or overriding of methods!
- can be applied to a class, or a class member
````c#
public sealed class Circle : Shape //now we cannot create a class that derives from Circle 
{
  public override void Draw() {...}
}
````
- or: 
````c#
public class Circle : Shape 
{
  public sealed override void Draw() {...} //now we cannot override this method. 
  //Note that sealed can only be applied to methods overriding the virtual method on the base class
}
````
- Sealed is a feature hardly ever used - Mosh has never used it, suggests we avoid it unless absolutely necessary
- There are classes in dotnet defined as sealed, which means you cannot inherit from them. I.e. String - if you want to extend it, you need to use Extension Methods (covered in c# advanced)


### Interfaces
What is an Interface?
- A language construct that is similar to class (in syntax), but fundamentally different
````c#
public interface ITaxCalculator //convention starts with I
{
  int Calculate(); //interfaces do not have implementation logic, just declerations
}
````
- Interfaces used to build loosely-coupled applications
- instead of "OrderProcessor" being dependent on "TaxCalculator", its going to be dependent on "ITaxCalculator"


Interfaces and Testability
- interfaces improve the testability of applications
- to add tests: right click solution and click "add new project" search for "unit test project" (for dotnet framework)
- Note that it exists in another namespace. Convention is to name the project the same name and add .UnitTests at the end
````c#
namespace InterfacesTestability
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    public class ShippingCalculator : IShippingCalculator // ShippingCalculator implements IShippingCalculator, not inheriance
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }

    static void Main(string[] args)
    {
      var orderProcessor = new OrderProcessor(new ShippingCalculator()); // this is dependency on concrete ShippingCalculator, but its in the main method ... its OK in the Main method. This way we can test classes individually
    }
}
````
- You should name your test files after your classes, i.e. if testing "OrderProcessor", the test should be called "OrderProcessorTests"
- Convention for naming tests: METHODNAME_CONDITION_EXPECTATION, i.e. Process_OrderIsAlreadyShipped_ThrowsAnException()
- When you use a class that takes an Interface, you need to create a fake version of that in the test file - one that inherits from the interface. Write it out and inherit from the interface, then right click the interface and go "implement interface" 
````c#
public class FakeShippingCalculator : IShippingCalculator
{
    public float CalculateShipping(Order order)
    {
        throw new NotImplementedException();
    }
}
````

Interfaces and Extensibility
- this is all about using composition over inheritance 
- aka dependency injection, open-closed principle: classes open for extension, not for modification


Interfaces are NOT for Multiple Inheritance
- in some languages (not c#) classes can have multiple base-types (or inherit from multiple parent classes)
- but it can have multiple interfaces - but its not inheriting code, just declarations
- interfaces have nothing to do with inheritance


# C# ADVANCED


### Generics
- To use an indexer for a given type of a list, would need to make different classes for each one:
````c#
public class List //list of numbers
{
  public void Add(int number) {...}
  public int this[int index] {...} //this will return like list[0]
}

public class BookList //list of books
{
  public void Add(Book book) { ... }
  public Book this[int index] { ... }
}
````
- Instead we could use the base class:
````c#
public class ObjectList //list of the base class, object
{
  public void Add(object value) {...}
  public object this[int index] { ... } //the issue is performance, everything added and returned will need to be boxed or unboxed
}
````
- To create a generic list: 
````c#
public class GenericList<T> //T short for 'template' or 'type'
{
  public void Add(T value) {...}
  public T this[int index] { ... }
}

//back in main:
var numbers = new GenericList<int>();
numbers.Add(10);

var books = new GenericList<Book>();
books.Add(new Book());
````
- this enables code reusabiliy without performance penalty! 
- in practical terms, you will be using generics more than creating them. very rare to create them! 
- "System.Collections.Generic." look at this in VS and you'll see all of them
- A "dictionary" is just a key-value pair
- Always prefix your generics with T and give them a proper name, i.e. ``public class GenericDictonary<TKey, TValue>{}``
````c#
public class Utilities
{
    public int Max(int a, int b)
    {
        return a > b ? a : b;
    }

    //example of a generic method in a non-generic class
    // applies a constraint. 
    // 5 types of constraints:
    // where T : IComparable (applying a constraint to an interface)
    // where T : Product (applying a constraint to a specific class, where T is a product or any of its children)
    // where T : struct (a value type)
    // where T : class (a reference type)
    // where T : new() (an object that has a default constructor)
    public T Max<T>(T a, T b) where T : IComparable // reads like "where T is IComparable" 
    {
        return a.CompareTo(b) > 0 ? a : b;
    }
}
````
- An example of this in action for a class: ``where T : class`` (a reference type)
````c#
public class DiscountCalculator<TProduct> where TProduct : Product
{
    public float CalculateDiscount(TProduct product)
    {
        return product.Price;
    }
}
````
- An example of this in action for a value type: ``where T : struct``
````c#
public class Nullable<T> where T : struct
{
    private object _value;
    public bool HasValue
    {
        get { return _value != null;  }
    }

    public Nullable()
    {
    }

    public Nullable(T value)
    {
        _value = value;
    }

    public T GetValueOrDefault()
    {
        if (HasValue)
            return (T)_value;

        return default(T); //default operator, returns the default of a given value type, default is a special reserved keyword
    }
}
````
- An example of this in action for a new(): ``where T : new()``
````c#
public class Utilities<T> where T : IComparable, new() //use a comma to add more constraints
{
    public int Max(int a, int b)
    {
        return a > b ? a : b;
    }

    public void DoSomething(T value)
    {
        var obj = new T(); //strange things happen, when you're going round the twist
    }
}
````


### Delegates
- An object that knows how to call a method (or a group of methods)
- A reference to a function
- Why? It allows us to design extensible and flexible applications (eg frameworks)
````c#
//below code is not extensible, what if another dev wants to use a different filter? 
//the same problem can be solved with polymorphism / composition, but we will use delegates for this example
public class PhotoProcessor
{
    public void Process(string path)
    {
        var photo = Photo.Load(path);

        var filters = new PhotoFilters();
        filters.ApplyBrightness(photo);
        filters.ApplyContrast(photo);
        filters.Resize(photo);

        photo.Save();
    }
}
// in main: 
var photoProcessor = new PhotoProcessor();
photoProcessor.Process("123");
````
- Change it using delegates: 
````c#
public class PhotoProcessor
{
    public delegate void PhotoFilterHandler(Photo photo); //this is the delegate
    public void Process(string path, PhotoFilterHandler filterHandler)
    {
        var photo = Photo.Load(path);

        filterHandler(photo);

        photo.Save();
    }
}

//in main: 
static void Main(string[] args)
{
    var photoProcessor = new PhotoProcessor();
    var filters = new PhotoFilters();

    PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
    filterHandler += filters.ApplyContrast;
    filterHandler += RemoveRedEyeFilter;

    photoProcessor.Process("123", filterHandler);
}

//to add a new filter, while not changing the PhotoProcessor / PhotoFilters classes:
static void RemoveRedEyeFilter(Photo photo) //it must have the same signature as the delegate
{
    System.Console.WriteLine("Apply remove red eye");
}
````
- instead of creatng a custom delegate, we can use the ones built into .NET => "action" and "func"
- ``System.Action<`` will show you that it takes between 1 and 16 parameters. Action points to a method that returns void
- ``System.Func<`` also takes 1-16 params. Func points to a method that returns a value, using ``out TResult``
````c#
//to use the baked-in delegate:
public class PhotoProcessor
{
    public void Process(string path, Action<Photo> filterHandler) //it will take any delegate that takes a photo argument and returns void
    {
        var photo = Photo.Load(path);
        filterHandler(photo);

        photo.Save();
    }
}

static void Main(string[] args)
{
    var photoProcessor = new PhotoProcessor();
    var filters = new PhotoFilters();

    Action<Photo> filterHandler = filters.ApplyBrightness; //change type here
    filterHandler += filters.ApplyContrast;
    filterHandler += RemoveRedEyeFilter;

    photoProcessor.Process("123", filterHandler);
}
````
- How to decide when to use interfaces/composition vs delegates? Use a delegate when:
  - its sometimes personal preference
  - An eventing design pattern is used
  - The caller doesn't need to access other properties or methods on the object implementing the method (i.e. in the Process method)
  - sounds like interfaces/composition is generally better..


### Lambda Expressions
- What is a lambda expression? 
  - An anonymous method (like public of private)
  - no access modifier
  - no name
  - no return statement
- Why do we use them?
  - for convenience 
````c#
//i.e. these are equivilent: 
static void Main(string[] args)
{
    // args => expression (args goes to expression)
    //number => number * number;

    Func<int, int> squareLambda = number => number * number;

    Console.WriteLine(squareLambda(5)); //25
    Console.WriteLine(squareFunction(5)); //25
}

static int SquareFunction(int number)
{
    return number * number;
}
````


### Events (and delegates)
- A mechanism for communication between objects
- Used in building Loosely Coupled Applications
- Helps extending applications
- An example:
  - VideoEncoder (publisher, event sender), uses a delegate
    - Delegate: agreement / contract between Publisher and Subscriber
    - determines the signatue of the event handler method in Subscriber
    - Steps to set it up: 
      - 1 - define a delegate
      - 2 - define an event based on that delegate
      - 3 - raise the event
  - MailService (subscriber, event receiver)
  - MessageService (another subscriber, event receiver)

````c#
public class VideoEventArgs : EventArgs
{
    public Video Video { get; set; }
}

//publisher 
public class VideoEncoder
{
    //this is the convention in .net: first argument is an object of source, second argument is what you want to send to the event 
    public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);// step 1. defining delegate
    public event VideoEncodedEventHandler VideoEncoded; // step 2. define event based on delegate. past tense refers to that something has happened or finished

    public void Encode(Video video)
    {
        Console.WriteLine("Encoding video...");
        Thread.Sleep(3000);

        OnVideoEncoded(video); //assume this method will notify all subscribers
    }

    //.net convention is that event publisher methods should be protected, virtual and void. Should start with "On"
    protected virtual void OnVideoEncoded(Video video) // step 3. this method raises the event
    {
        if (VideoEncoded != null) //i.e. there are subscribers
        {
            VideoEncoded(this, new VideoEventArgs() { Video = video }); // EventArgs.Empty when you don't want to send any data
        }
    }
}

public class MailService
{
    public void OnVideoEncoded(object source, VideoEventArgs e) //subscriber - has the same signature as the delegate
    {
        Console.WriteLine("MailService: Sending an email...");
        Console.WriteLine($"MailService: {e.Video.Title}");
    }
}

public class MessageService
{
    public void OnVideoEncoded(object source, VideoEventArgs args) //subscriber - has the same signature as the delegate
    {
        Console.WriteLine("MessageService: Sending a text message...");
        Console.WriteLine($"MessageService: {args.Video.Title}");
    }
}

static void Main(string[] args)
{
    var video = new Video() { Title = "Video 1" };
    var videoEncoder = new VideoEncoder(); //publisher
    var mailService = new MailService(); //subscriber
    var messageService = new MessageService(); //subscriber

    videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //adds subscriber to publisher
    videoEncoder.VideoEncoded += messageService.OnVideoEncoded; //adds subscriber to publisher

    videoEncoder.Encode(video);
}
````
- In dotnet they have a baked in delegate type called "EventHandler" so you don't have to make your own, and a generic one "EventHandler<TEventArgs>"
- Saves us from writing our own delegate, better to use
````c#
// this is equivilent to...
public class VideoEncoder
{
    public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
    public event VideoEncodedEventHandler VideoEncoded;
    ...

// this: 
public class VideoEncoder
{
    public event EventHandler<VideoEventArgs> VideoEncoded;
    ...

//or this: 
public class VideoEncoder
{
    public event EventHandler VideoEncoded; //this wouldn't work, it needs object source as first parameter, and plain EventArgs as second (in this case we're using VideoEventArgs)
    ...
````


### Extension Methods
- Allow us to add methods to an existing class without
  - changing its source code 
  - creating a new class that inherits from it 
- i.e. in a situation where we cannot edit or inherit from an existing class
````c#
static void Main(string[] args)
{
    string post = "This is supposed to be a very long blog post blah blah blah...";
    var shortened = post.Shorten(5);
}

public static class StringExtensons
{
    //the first argument "this String str" represents the instance we're applying the method on. So it will work on strings here
    public static string Shorten(this String str, int numberOfWords) //should always be static 
    {
        if (numberOfWords < 0)
            throw new ArgumentOutOfRangeException("number of words should be 0 or more");
        if (numberOfWords == 0)
            return "";

        var words = str.Split(' ');

        if (words.Length <= numberOfWords)
            return str;

        return string.Join("", words.Take(numberOfWords));
    }
}
````
- A key thing to know is that extension methods will only be available under the same namespace
- Because this string class is defined in the "System" namespace, Mosh will make that the namespace for the extension method!
- Can be problematic. If you extend the string class, but the creator of the string class (microsoft) ends up changing the implementation - they may create their own Shorten method with different behaviour. The instance methods take priority over static methods in that case (so your extension method - whch is an instance method - will never be executed). Microsoft says use extension methods only when you really have to. Change the class, or inherit, and only use extension methods when you really have to
- In the real world, you will be using extension methods much more than creating them. 
````c#
IEnumerable<int> numbers = new List<int>() {2, 4, 6, 8 };
Console.WriteLine( numbers.Max() ); //this is an extension method provided by System.Linq
````


### LINQ
- Stands for: Language Integrated Query
- Gives you the capability to query objects:
  - Objects in memory, e.g. collections (LINQ to Objects)
  - Databases (LINQ to Entities)
  - XML (LINQ to XML)
  - ADO.NET Data Sets (LINQ to Data Sets)
- Using LINQ Extension Methods:
````c#
static void Main(string[] args)
{
    var books = new BookRepository().GetBooks();

    //without linq
    //var cheapBooks = new List<Book>();
    //foreach (var book in books)
    //{
    //    if (book.Price < 10)
    //        cheapBooks.Add(book);
    //}

    //with linq
    var cheapBooks = books.Where(b => b.Price < 10).OrderBy(b => b.Title); //can chain linq!

    foreach (var book in cheapBooks)
        Console.WriteLine($"{book.Title}, {book.Price}");
}
````
- Using LINQ Query Operators:
````c#
//LINQ query Operators: 
var cheaperBooks = from b in books
                    where b.Price < 10
                    orderby b.Title
                    select b.Title;
//equivilent to: (the LINQ extension methods .. these are more powerful)
var readerFriendly = books
                      .Where(b => b.Price < 10)
                      .OrderBy(b => b.Title)
                      .Select(b => b.Title);
````
- Good LINQ methods to know, that can all be applied on an IEnumerable:
  - .Where() takes a lambda and returns a list of objects that are true for that lambda
  - .OrderBy() takes a lambda and returns an ordered list according to the lambda
  - .Select() takes a lambda and returns an ordered list based on that lambda (changes the type)

  - more examples here:
  ````c#
  //other LINQ methods
  var single = books.Single(b => b.Title == "Book 3"); //if it can't find, it will crash. It wants one and only one object, if you're not sure better to use...
  Console.WriteLine(single.Title);

  var singleOrDefault = books.SingleOrDefault(b => b.Title == "hmm doesnt exist"); //returns null if it can't find, better to avoid exception crashing
  Console.WriteLine(singleOrDefault == null);

  var first = books.First(); //gives first book 
  var firstWithPredicate = books.First(b => b.Title == "Book 4"); //gives first book with that title, i.e. the one with price as $14.
  Console.WriteLine(firstWithPredicate.Price);

  var firstOrDefault = books.FirstOrDefault(b => b.Title == "Book 08089"); //if nothing matches the lambda condition, it returns null without throwing exception

  var last = books.Last();
  var lastOrDefault = books.LastOrDefault();

  var skip = books.Skip(2).Take(3); //this will skip the first 2, and take the next 3 to the new list.
  Console.WriteLine($"Skip:");
  foreach (var book in skip)
      Console.WriteLine(book.Title);

  var count = books.Count(); //will be 5

  var max = books.Max(b => b.Price); //what does max mean? in this case, highest price.
  Console.WriteLine(max); //this is the price itself.
  var min = books.Min(b => b.Price);
  Console.WriteLine(min);

  var sum = books.Sum(b => b.Price); //sum based on price of books
  Console.WriteLine(sum);

  var averagePrice = books.Average(b => b.Price);
  Console.WriteLine(averagePrice); //float!
  ````


### Nullable Types
- Value types:
  - Cannot be bull
  - `` bool hasAccess = true; //or false``
- Database
  - Customers.Birthday (datetime NULL) - i.e. a user doesn't enter their birthday.
  - If you want to map this to a c# class, this is one of the cases where you'd use nullable types
````c#
DateTime date = null; //this won't work
Nullable<DateTime> date = null; //this will - value type or a null
DateTime? date2 = null; //this is the short hand version


//members of a nullable type:
Console.WriteLine($"get value or default: {date2.GetValueOrDefault()}"); //returns a value if the object has been initialised, or the default for that value type
Console.WriteLine($"hasValue: {date2.HasValue}"); //returns true if value, null if false
//Console.WriteLine($"value: {date2.Value}"); //throws exception if null. better to use "GetValueOrDefault"! 

//======

DateTime? date3 = new DateTime(2014, 1, 1);
DateTime date4 = date3.GetValueOrDefault();
DateTime? date5 = date4;


//===

DateTime? date6 = null;
DateTime date7;

if (date6 != null)
    date7 = date6.GetValueOrDefault();
else
    date7 = DateTime.Today;

Console.WriteLine(date7);

//==
//above written shorter like:
DateTime date8 = date6 ?? DateTime.Today; //"null coalescing operator"
//similar to tertiary operator...
DateTime date9 = (date6 != null) ? date.GetValueOrDefault() : DateTime.Today;
````


### Dynamic
- Programming languages divided into two types:
  - Statically-typed languages: C#, java
  - Dynamically-typed languages: Ruby, Javascript, Python
- Type resolution
  - static languages: at compile time (immediate feedback - it wont compile)
    - Pros: early feedback 
  - dynamic languages: done at runtime
    - Pros: easier and faster to code 
- C# started as static, but dynamic capability has been added
- Static seems to be the heavy preference 
````c#
dynamic name = "Mark";
name = 10;

Console.WriteLine(name);

dynamic a = 10;
dynamic b = 5;
var c = a + b; //var is now "dynamic"

int i = 5;
dynamic d = i;
long l = d; //at runtime d will be an integer, and we can put an integer into a long type (implicit cast)
````
- With dynamic types we need to write more unit tests - they are riskier


### Exception Handling
- We use this do deal with unexpected situations that arise when the program is running
- An exception is essentially a class
- When an exception is thrown, in the console you will see the type of exception and then the stack trace.
  - the stack trace is the sequence of methods that were called until the exception was thrown, the top being the last method called (and the bottom being the first method called - usually something like Program.cs)
  - "sequence of method calls in the reverse order" 
- to handle exceptions use the try catch block
````c#
try
{
    var calculator = new Calculator();
    var result = calculator.Divide(5, 0); //this will cause the program to crash unless in a try-catch block 
}
catch (Exception ex)
{
    var link = (ex.HelpLink != null) ? ex.HelpLink : "no link";
    Console.WriteLine($"Sorry an error occured: {ex.Message}, {link}");
}
````
- As a guideline, you should always have a global exception handling block in your application. I.e. in the main method for a console app...
- You can also have multiple catch blocks. They must be in order of specificity, with the (Exception ex) one being the most generic that must be at the bottom for it to compile
- You can also have a "finally" block at the end, which is always excuted. Can be used to dispose of things etc
````c#
try
{
    var calculator = new Calculator();
    var result = calculator.Divide(5, 0); 
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("You cannot divide by 0.");
}
catch (ArithmeticException ex)
{

}
catch (Exception ex)
{
    var link = ex.HelpLink != null ? ex.HelpLink : "no link";
    Console.WriteLine($"Sorry an error occured: {ex.Message} {link}");
}
finally
{
    Console.WriteLine("finally block");
}
````
- Another example. Because the NullReferenceException is the one being thrown, it will be triggered instead of the Exception block, and then the finally block will run.
````c#
try
{
  throw new NullReferenceException("oops");
}
catch (NullReferenceException ex)
{
  Console.WriteLine($"In null ref exception {ex.Message}");
}
catch (Exception ex)
{
  Console.WriteLine($"In generic exception {ex.Message}");
}
finally
{
  Console.WriteLine("In finally block.");
}
````
- When you want to call the "Dispose()" method, it is recommended to do in the finally block:
````c#
var streamReader = null;
try
{
  steamReader = new StreamReader(@"c:\file.zip");
  streamReader.ReadToEnd();
}
catch (Exception ex)
{
  Console.WriteLine("An error occured");
}
finally
{
  streamReader.Dispose();
}
````
- You can also do the above with the using block, which calls Dispose under the hood and is the preferred method in .net:
````c#
try
{
  using (var streamReader = new StreamReader(@"c:\file.zip"))
  {
    var content = streamReader.ReadToEnd();
  }
}
catch (Exception ex)
{
  Console.WriteLine("An error occured");
}
````
- An example of creating your own custom exception: 
````c#
public class YoutubeException : Exception
{
    public YoutubeException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
public class YoutubeAPI
{
    public List<string> GetVideos(string user)
    {
        try
        {
            throw new Exception("oops");
        }
        catch (Exception ex)
        {
            //a more meaningful custom exception
            throw new YoutubeException("Could not fetch videos from youtube", ex);
        }

        return new List<string>();
    }
}
````


### Asynchronous Programming
- Synchronous Program Execution: 
  - Program is executed line by line, one at a time
  - When a function is called, program execution has to wait until the function returns 
- Asynchronous Program Execution:
  - When a function is called, program execution continues to the next line, WITHOUT waiting for the function to complete
- Asynchronous programming improves the responsiveness of your application
- When to use asynchronous?
  - Accessing the web 
  - Working with files and databases
  - Working with images
- How? We do this using async / await
````c#
//non-async
public void DownloadHtml(string url)
{
    var webClient = new WebClient();
    var html = webClient.DownloadString(url);

    using (var streamWriter = new StreamWriter(@"c:\projects\result.html"))
    {
        streamWriter.Write(html);
    }
}

//async version
public async Task DownloadHtmlAsync(string url) //the convention is to use Async on the end of the name
{
    var webClient = new WebClient();
    var html = await webClient.DownloadStringTaskAsync(url); //returns a Task of type string
    //typically when we download an async task, we need to put await in front 

    using (var streamWriter = new StreamWriter(@"c:\projects\result.html"))
    {
        await streamWriter.WriteAsync(html);
    }
}
````
- Task<string> or task of any type, will return a task type. It represents the state of an async operation, it wont have methods like substring. If you use the await operator, unless you use the await operator. The await operator essentially makes async tasks synchronous 
````c#
public async Task DownloadHtmlAsync(string url)
{
    var webClient = new WebClient();
    //var html = await webClient.DownloadStringTaskAsync(url); //this async method now runs with synchronous behaviour, that is, the program waits until the string is returned before continuing. 

    //could be done as: 
    var htmlTask = webClient.DownloadStringTaskAsynch(url); //the async method fires off
    var html = await htmlTask; //this is when the method is waited for until it returns


    using (var streamWriter = new StreamWriter(@"c:\projects\result.html"))
    {
        await streamWriter.WriteAsync(html);
    }
}
````

---

#### Shortcuts: 
- ctrl + k + c = comments out multiple lines of code
- ctrl + k + u = uncomments out multiple lines of code
- tab or shift + tab = indent multiple lines of code 
- cw + tab = Console.WriteLine()
- ctrl + x = deletes the line the cursor is on
- ctrl + f5 = starts without debugging
- type "try" + tab = creates a try catch block
- To move a class to a new file, put cursor on class name and hit alt + enter and select "Move to Person.cs"
- To declare a constructor in a class, type "ctor" and hit tab
- "try" + tab =  create a try catch block
- "prop" + tab = create a property with get/ set
