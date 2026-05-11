//////using BankAccountEnumExample;
//////using System;
//////using System.Transactions;

//////namespace Lab1
//////{
//////    class Program
//////    {
//////        static void Main(string[] args)
//////        {
//////            // --- Lab Questions (Abstract Classes) ---

//////            // 1. Employee Management System
//////            //Console.WriteLine("--- 1. Employee Management System ---");
//////            //Employee ft = new FullTimeEmployee { Name = "Rabindra" };
//////            //Employee pt = new PartTimeEmployee { Name = "Jadeja" };
//////            //Console.WriteLine($"{ft.Name} Salary: {ft.CalculateSalary()}");
//////            //Console.WriteLine($"{pt.Name} Salary: {pt.CalculateSalary()}");
//////            //Console.WriteLine();

//////            //// 2. Shape Drawing System
//////            //Console.WriteLine("--- 2. Shape Drawing System ---");
//////            //Shape circleObj = new Circle();
//////            //Shape rectObj = new Rectangle();
//////            //circleObj.Display();
//////            //circleObj.Draw();
//////            //rectObj.Display();
//////            //rectObj.Draw();
//////            //Console.WriteLine();

//////            //// 3. Vehicle System
//////            //Console.WriteLine("--- 3. Vehicle System ---");
//////            //Vehicle carObj = new Car();
//////            //Vehicle bikeObj = new Bike();
//////            //carObj.FuelType();
//////            //carObj.Start();
//////            //bikeObj.FuelType();
//////            //bikeObj.Start();
//////            //Console.WriteLine();

//////            //// 4. Banking System
//////            //Console.WriteLine("--- 4. Banking System ---");
//////            //Bank nabil = new NabilBank();
//////            //Bank nepal = new NepalBank();
//////            //Console.WriteLine($"Nabil Bank Interest: {nabil.GetInterestRate()}%");
//////            //Console.WriteLine($"Nepal Bank Interest: {nepal.GetInterestRate()}%");
//////            //Console.WriteLine();

//////            //// 5. Student Grading System
//////            //Console.WriteLine("--- 5. Student Grading System ---");
//////            //Student sc = new ScienceStudent { Name = "Jenish" };
//////            //Student mg = new ManagementStudent { Name = "Binita" };
//////            //sc.ShowDetails();
//////            //Console.WriteLine($"Grade: {sc.GetGrade()}");
//////            //mg.ShowDetails();
//////            //Console.WriteLine($"Grade: {mg.GetGrade()}");
//////            //Console.WriteLine();


//////            //// --- L7 Lab Questions (Interfaces) ---

//////            //// 1. Transport System (Interface)
//////            //Console.WriteLine("--- L7-1. Transport System (Interface) ---");
//////            //IVehicle v1 = new L7_Car();
//////            //IVehicle v2 = new L7_Bike();
//////            //v1.Start();
//////            //v1.Stop();
//////            //v2.Start();
//////            //v2.Stop();
//////            //Console.WriteLine();

//////            //// 2. Online Payment System (Interface)
//////            //Console.WriteLine("--- L7-2. Online Payment System (Interface) ---");
//////            //L7_Checkout checkout = new L7_Checkout();
//////            //IPayment esewa = new L7_EsewaPayment();
//////            //IPayment khalti = new L7_KhaltiPayment();

//////            //checkout.ProcessOrder(esewa, 1500.00);
//////            //Console.WriteLine("---");
//////            //checkout.ProcessOrder(khalti, 2450.50);
//////            //Console.WriteLine();

//////            //// 3. Shape Calculator System (Interface)
//////            //Console.WriteLine("--- L7-3. Shape Calculator System (Interface) ---");
//////            //IShape shape1 = new L7_Circle(5.0);
//////            //IShape shape2 = new L7_Rectangle(10.0, 4.0);

//////            //Console.WriteLine($"Shape: {shape1.GetShapeName()}, Area: {shape1.GetArea():F2}");
//////            //Console.WriteLine($"Shape: {shape2.GetShapeName()}, Area: {shape2.GetArea():F2}");

//////            //Console.WriteLine("\nExecution completed. Press any key to exit...");
//////            //Console.ReadKey();


//////            //Lab 6 1
//////            //Console.WriteLine("Calculaor");
//////            //Calculator calc = new Calculator();

//////            //Console.WriteLine(calc.Add(2, 3));
//////            //Console.WriteLine(calc.Add(1, 2, 3));
//////            //Console.WriteLine(calc.Add(2.5, 3.5));

//////            //Lab6 2
//////            //Student2 s1 = new Student2();
//////            //Student2 s2 = new Student2("Ram");
//////            //Student2 s3 = new Student2("Sita", 20);

//////            //s1.Display();
//////            //s2.Display();
//////            //s3.Display();

//////            //lab6 3

//////            //Console.WriteLine(MathUtility.Square(4));
//////            //Console.WriteLine(MathUtility.Cube(3));

//////            // Creating accounts using enum values
//////            //BankAccount acc1 = new BankAccount("Ram", AccountType.Saving);
//////            //BankAccount acc2 = new BankAccount("Sita", AccountType.Current);
//////            //BankAccount acc3 = new BankAccount("Hari", AccountType.Fixed);

//////            //acc1.Display();
//////            //Console.WriteLine();

//////            //acc2.Display();
//////            //Console.WriteLine();

//////            //acc3.Display();

//////            //L51
//////            //ComplexNumber c1 = new ComplexNumber(2, 3);
//////            //ComplexNumber c2 = new ComplexNumber(4, 5);

//////            //ComplexNumber result = c1 + c2;
//////            //result.Display();

//////            //L52
//////            //Point p1 = new Point(2, 3);
//////            //Point p2 = new Point(2, 3);

//////            //Console.WriteLine(p1 == p2);

//////            //l53
//////            //Matrix m = new Matrix(5);
//////            //Matrix result = m * 3;

//////            //result.Display();

//////            //l54
//////            //int x = 10;
//////            //int y = 20;

//////            //Swap(ref x, ref y);

//////            //Console.WriteLine($"x = {x}, y = {y}");

//////            //Lab3_2 objl = new Lab3_2();
//////            //Console.Write("Enter size: ");
//////            //int n = Convert.ToInt32(Console.ReadLine());
//////            //Console.WriteLine();
//////            //int[] arr = new int[n];
//////            //for (int i = 0; i < n; i++)
//////            //{
//////            //    Console.Write("Enter Value: ");
//////            //    arr[i] = Convert.ToInt32(Console.ReadLine());
//////            //    Console.WriteLine();
//////            //}
//////            //objl.reverseThis(arr);

//////            //Lab3_7 mat = new Lab3_7();
//////            //mat.JaggedMaxima();

//////            //ComplexNumber cn = new ComplexNumber(3,6);
//////            //cn.Display();

//////            Matrix mat = new Matrix(3);
//////            mat.Display();

//////        }
//////    }
//////}


//////class Program
//////{
//////    static void Swap(ref int a, ref int b)
//////    {
//////        int temp = a;
//////        a = b;
//////        b = temp;
//////    }

//////    static void Main(string[] args)
//////    {
//////        int x = 10;
//////        int y = 20;
//////        Console.WriteLine("Before Swap: x = " + x + " ,y =  " + y);
//////        Swap(ref x, ref y);
//////        Console.WriteLine("After Swap: x = " + x + " , y = " + y);

//////    }
//////}

////class Program
////{
////    static void ShowValue(out int num)
////    {
////        num = 50;
////    }

////    static void Main()
////    {
////        int x;
////        ShowValue(out x );
////        Console.WriteLine("Write a program that uses out parameters.");
////        Console.WriteLine("Value: " + x);
////    }
////}

////class Program
////{
////    static void Calculate(int l, int w, out int area, out int perimeter)
////    {
////        area = l * w;
////        perimeter = 2 * (l + w);
////    }

////    static void Main()
////    {
////        int area, perimeter;
////        Calculate(5, 4, out area, out perimeter);
////        Console.WriteLine("Write a Program to calculate area and perimeter using out parameter.");
////        Console.WriteLine("Area = " + area);
////        Console.WriteLine("Perimeter =" + perimeter);
////    }
////}

////class Program
////{
////    static void FindMaxMin(int[] arr, out int min, out int max)
////    {
////        min = arr[0];
////        max = arr[0];

////        foreach (int num in arr)
////        {
////            if(num< min) min = num;
////            if(num> max) max = num;
////        }
////    }

////    static void Main()
////    {
////        int[] arr = { 2, 8, 1, 6, 3 };
////        int min, max;
////        FindMaxMin(arr, out min, out max);
////        Console.WriteLine("WAP to find max min using out perimeter.");
////        Console.WriteLine();
////        Console.WriteLine("Min = " + min);
////        Console.WriteLine("Max = " + max);
////    }
////}

////class Program
////{
////    static void RefExample(ref int x)
////    {
////        x = x + 10;
////    }

////    static void OutExample(out int x)
////    {
////        x = 20;
////    }

////    static void inExample(in int x)
////    {
////        Console.WriteLine("Value using in: "+x);
////    }

////    static void Main()
////    {
////        int a = 5;
////        RefExample(ref a);
////        Console.WriteLine("WAP to demonstrate ref, out and in parameters.");
////        Console.WriteLine();
////        Console.WriteLine("After ref: " + a);
////        int b;
////        OutExample(out b);
////        Console.WriteLine("AfterOut: " + b);
////        int c = 30;
////        inExample(in c);
////    }
////}


////namespace CollegeA
////{
////    class Student
////    {
////        public void DisplayInfo()
////        {
////            Console.WriteLine("Student from college A");
////        }
////    }
////}

////namespace CollegeB
////{
////    class Student
////    {
////        public void DisplayInfo()
////        {
////            Console.Write("Student from College B");

////        }
////    }
////}

////class Program
////{
////    static void Main()
////    {
////        CollegeA.Student s1 = new CollegeA.Student();
////        CollegeB.Student s2 = new CollegeB.Student();
////        Console.WriteLine("Using Multiple Namespaces.");
////        Console.WriteLine();
////        s1.DisplayInfo();
////        s2.DisplayInfo();
////    }
////}

//namespace DrawingShapes
//{
//    class Circle
//    {
//        public void Draw()
//        {
//            Console.WriteLine("Drawing Circle..");
//        }
//    }
//}

//namespace DrawingTools
//{
//    class Pencil
//    {
//        public void UseTool()
//        {
//            Console.WriteLine("Using Pencil.");
//            Console.WriteLine();
//        }
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        DrawingShapes.Circle c = new DrawingShapes.Circle();
//        DrawingTools.Pencil p = new DrawingTools.Pencil();

//        Console.WriteLine("Using different namespaces for different usecases..");
//        Console.WriteLine();
//        p.UseTool();
//        c.Draw();
//    }
//}

// Write a C# program using enum to represent different account types
// such as Saving, Current, and Fixed account.

//using System;

//enum AccountType
//{
//    Saving,
//    Current,
//    Fixed
//}

//class Program
//{
//    static void Main()
//    {
//        AccountType acc1 = AccountType.Saving;
//        AccountType acc2 = AccountType.Current;

//        Console.WriteLine("First Account Type: " + acc1);
//        Console.WriteLine("Second Account Type: " + acc2);
//    }
//}

// Create a student result processing system where a custom delegate
// takes marks as input and triggers multiple methods using a multicast
// delegate to calculate grade, check pass or fail, and display a
// formatted result, while also using a Predicate to filter only
// passed students from a list.

//using System;
//using System.Collections.Generic;

//delegate void ResultDelegate(int marks);

//class Student
//{
//    public string Name { get; set; }
//    public int Marks { get; set; }
//}

//class Program
//{
//    static void CalculateGrade(int marks)
//    {
//        if (marks >= 80)
//            Console.WriteLine("Grade: A");
//        else if (marks >= 60)
//            Console.WriteLine("Grade: B");
//        else if (marks >= 40)
//            Console.WriteLine("Grade: C");
//        else
//            Console.WriteLine("Grade: F");
//    }

//    static void CheckPassFail(int marks)
//    {
//        if (marks >= 40)
//            Console.WriteLine("Status: Pass");
//        else
//            Console.WriteLine("Status: Fail");
//    }

//    static void DisplayResult(int marks)
//    {
//        Console.WriteLine("Marks Obtained: " + marks);
//    }

//    static void Main()
//    {
//        ResultDelegate result;

//        result = CalculateGrade;
//        result += CheckPassFail;
//        result += DisplayResult;

//        result(75);

//        List<Student> students = new List<Student>()
//        {
//            new Student{Name="Ram", Marks=80},
//            new Student{Name="Hari", Marks=30},
//            new Student{Name="Sita", Marks=65}
//        };

//        Predicate<Student> passed = s => s.Marks >= 40;

//        List<Student> passedStudents = students.FindAll(passed);

//        Console.WriteLine("\nPassed Students:");

//        foreach (Student s in passedStudents)
//        {
//            Console.WriteLine(s.Name);
//        }
//    }
//}

// Design a smart calculator application where a custom delegate
// is used to perform arithmetic operations selected at runtime,
// and additionally use Func to return calculation results and
// Action to display outputs in different formats.

//using System;

//delegate int Calculator(int a, int b);

//class Program
//{
//    static int Add(int a, int b)
//    {
//        return a + b;
//    }

//    static int Subtract(int a, int b)
//    {
//        return a - b;
//    }

//    static void Main()
//    {
//        Calculator calc;

//        calc = Add;

//        Console.WriteLine("Addition: " + calc(10, 5));

//        calc = Subtract;

//        Console.WriteLine("Subtraction: " + calc(10, 5));

//        Func<int, int, int> multiply = (x, y) => x * y;

//        int result = multiply(4, 5);

//        Action<string> display = msg =>
//        {
//            Console.WriteLine("Result = " + msg);
//        };

//        display(result.ToString());
//    }
//}

// Develop a notification management system where a multicast delegate
// is used to send alerts through multiple channels such as email,
// SMS, and app notification, and use Action delegates to log each
// notification activity.

//using System;

//delegate void Notify(string msg);

//class Program
//{
//    static void Email(string msg)
//    {
//        Console.WriteLine("Email: " + msg);
//    }

//    static void SMS(string msg)
//    {
//        Console.WriteLine("SMS: " + msg);
//    }

//    static void Main()
//    {
//        Notify n = Email;
//        n += SMS;

//        n("Order Delivered");

//        Action<string> log =
//            x => Console.WriteLine("Log: " + x);

//        log("Notification Sent");
//    }
//}

using System;

class Program
{
    static void Main()
    {
        CheckoutSystem cs = new CheckoutSystem();

        Checkout c = cs.Total;
        c += cs.Discount;

        c(7000);

        Func<double, double, double> total =
            (p, q) => p * q;

        Console.WriteLine("Computed: " + total(1000, 2));

        Predicate<double> eligible =
            x => x >= 5000;

        Console.WriteLine("Eligible: " + eligible(7000));
    }
}