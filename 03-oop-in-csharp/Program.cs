/*
// ============================================================
//              OOP - CLASS, OBJECT, FIELDS & METHODS
// ============================================================
using System;
//Class definition
class Student
{
    //properties of Student class
    public string name; 
    public int age;                       
    //functionality of Student class
    public void ShowInfo()
    {
        Console.WriteLine("Name : {0}, Age:{1}",name,age);
    }
}
class Program
{
    // object oriented programming
    // student management System
    // Student - Name,Roll no,Marks,Courses - Properties
    // Registration,Course Enrollment,Quiz,contest - functionality

    public static void Main()
    {
        //object define
        Student student = new Student();
        student.name = "Dipto";
        student.age = 24;
        student.ShowInfo();
      
    }
}
*/
/*
// Instead of assigning values separately:
// student.name = "Dipto";
// student.age = 24;

// We can pass the values directly through the constructor:
// Student student = new Student("Dipto", 24);
using System; 
class Student 
{ 
    public string name;  
    public int age;
    // public Student(string namep,int agep)
    // {
    //     name = namep;
    //     age = agep;
    // }  
    //Another way to declare constructor                   
    public Student(string name,int age)
    {
        this.name = name;
        this.age = age;
    }       
    public void ShowInfo() 
    { 
        Console.WriteLine("Name : {0}, Age:{1}",name,age); 
    } 
} 
class Program 
{ 
    
    public static void Main() 
    { 
        
        Student student = new Student("dipto",27); 
        student.ShowInfo(); 
       
    } 
}

*/

/*
// ============================================================
//          OOP - ENCAPSULATION USING PRIVATE FIELDS
// ============================================================
using System; 
public class Student 
{ 
    private string name;  
    private int age;                   
    public Student(string name,int age)
    {
        this.name = name;
        this.age = age;
    }       
    public void ShowInfo() 
    { 
        Console.WriteLine("Name : {0}, Age:{1}",name,age); 
    } 
} 
class Program 
{ 
    
    public static void Main() 
    { 
        
        Student student = new Student("dipto",27); //// After removing 'student.name', the constructor value will be displayed.
        student.name = "Prmanik";//'student.name' is inaccessible due to its protection level
        student.ShowInfo(); 
       
    } 
}
*/

/*
// ============================================================
//       OOP - ENCAPSULATION USING SETTERS AND GETTERS
// ============================================================
//
// Private data is accessed and modified through public
// setter and getter methods.
//
// Setter → Used to set/update private data
// Getter → Used to read/access private data
//
// ============================================================
using System; 
public class Student 
{ 
    private string name;  
    private int age;                   
    public void SetName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return this.name;
    }
    public void SetAge(int age)
    {
        this.age = age;
    }
    public int GetAge()
    {
        return this.age;
    }
    public void ShowInfo() 
    { 
        Console.WriteLine("Name : {0}, Age:{1}",name,age); 
    } 
} 
class Program 
{ 
    
    public static void Main() 
    { 
        
        Student student = new Student(); 
        student.SetName("Pramanik");
        student.SetAge(27);
        Console.WriteLine("Name : {0},Age : {1}",student.GetName(),student.GetAge());
       
    } 
}
*/

/*
// ============================================================
//       OOP - ENCAPSULATION: BENEFITS OF GETTERS & SETTERS
// ============================================================
//
// Getter and Setter methods provide controlled access to
// private data.
//
// Benefits:
// 1. Data hiding
// 2. Controlled access
// 3. Validation / Authentication
// 4. Better security
//
// ============================================================
using System; 
// If IsAuthenticated() returns false,
// the user is not authenticated and private data will not be updated.
//
// Output:
// You are not authenticated
//
// If it returns true, the data will be updated successfully.
public class Auth
{
    public bool IsAuthenticated()
    {
        return true;
    }
}
public class Student 
{ 
    private string name;  
    private int age;   
    Auth auth = new Auth();                
    public void SetName(string name)
    {
        if(auth.IsAuthenticated())
        {
            this.name = name;
        }
        else
        {
            Console.WriteLine("You are not authenticated");
        }
        
    }
    public string GetName()
    {
        return this.name;
    }
    public void SetAge(int age)
    {
        if(auth.IsAuthenticated())
        {
            this.age = age;
        }
        else
        {
            Console.WriteLine("You are not authenticated");
        }
    }
    public int GetAge()
    {
        return this.age;
    }
    public void ShowInfo() 
    { 
        Console.WriteLine("Name : {0}, Age:{1}",name,age); 
    } 
} 
class Program 
{ 
    
    public static void Main() 
    { 
        
        Student student = new Student(); 
        student.SetName("John");
        student.SetAge(20);
        student.ShowInfo();
       
    } 
}
*/

/*
// ============================================================
//          OOP - CODE DUPLICATION BEFORE INHERITANCE
// ============================================================
//
// Problem:
// Student, JIPCStudent and CPStudent contain common
// properties and methods such as name, age and ShowInfo().
//
// This causes code duplication.
//
// Solution:
// Use Inheritance to reuse common properties and methods.
//
// ============================================================
using System; 
public class Student 
{ 
    public string name;  
    public int age;   
    public void ShowInfo() 
    { 
        Console.WriteLine("Name: " + name); 
        Console.WriteLine("Age: " + age);
    } 
} 

public class JIPCStudent
{
    public string name;
    public int age;
    public void ShowInfo() 
    { 
        Console.WriteLine("Name: " + name); 
        Console.WriteLine("Age: " + age);
    } 
    public void GiveQuiz()
    {
        Console.WriteLine("Give Quiz");
    }
}
public class CPStudent
{
    public string name;
    public int age;
    public void ShowInfo() 
    { 
        Console.WriteLine("Name: " + name); 
        Console.WriteLine("Age: " + age);
    } 
    public void GiveContest()
    {
        Console.WriteLine("Give Contest");
    }
}
class Program 
{ 
    
    public static void Main() 
    { 
        
        Student student = new Student(); 
        
        
       
    } 
}
*/

/*
// ============================================================
//              OOP - INHERITANCE
// ============================================================
//
// Inheritance allows a derived class to reuse the properties
// and methods of a base class.
//
// Student → Base/Parent Class
// JIPCStudent → Derived/Child Class
// CPStudent → Derived/Child Class
//
// Common members:
// name, age, ShowInfo()
//
// JIPCStudent adds:
// GiveQuiz()
//
// CPStudent adds:
// GiveContest()
//
// Benefit:
// Code reusability and avoiding code duplication.
//
// ============================================================
using System; 
public class Student 
{ 
    public string name;  
    public int age;   
    public void ShowInfo() 
    { 
        Console.WriteLine("Name: " + name); 
        Console.WriteLine("Age: " + age);
    } 
} 

public class JIPCStudent : Student 
{
    // public string name;
    // public int age;
    // public void ShowInfo() 
    // { 
    //     Console.WriteLine("Name: " + name); 
    //     Console.WriteLine("Age: " + age);
    // } 
    public void GiveQuiz()
    {
        Console.WriteLine("Give Quiz");
    }
}
public class CPStudent : Student
{
    // public string name;
    // public int age;
    // public void ShowInfo() 
    // { 
    //     Console.WriteLine("Name: " + name); 
    //     Console.WriteLine("Age: " + age);
    // } 
    public void GiveContest()
    {
        Console.WriteLine("Give Contest");
    }
}
class Program 
{ 
    
    public static void Main() 
    { 
        
        JIPCStudent jipcStudent = new JIPCStudent();
        jipcStudent.name = "Dipto";
        jipcStudent.age = 27;
        jipcStudent.ShowInfo();
        jipcStudent.GiveQuiz();
        
        CPStudent cpStudent = new CPStudent();
        cpStudent.name = "pritom";
        cpStudent.age = 27;
        cpStudent.ShowInfo();
        cpStudent.GiveContest();

    } 
}
*/

// ============================================================
//       OOP - INHERITANCE WITH CONSTRUCTOR AND BASE()
// ============================================================
//
// Student → Base/Parent Class
// JIPCStudent, CPStudent → Derived/Child Classes
//
// The child class constructor calls the parent class constructor
// using the base() keyword.
//
// ============================================================
/*
using System; 
public class Student 
{ 
    private string name;  
    private int age;  
    public Student(string name,int age)
    {
        this.name = name;
        this.age = age; 
    }
    public void ShowInfo() 
    { 
        Console.WriteLine("Name: " + name); 
        Console.WriteLine("Age: " + age);
    } 
} 

public class JIPCStudent : Student 
{
    public JIPCStudent(string name,int age) : base(name,age){}
    
    public void GiveQuiz()
    {
        Console.WriteLine("Give Quiz");
    }
}
public class CPStudent : Student
{
    public CPStudent(string name,int age) : base(name,age){}
    public void GiveContest()
    {
        Console.WriteLine("Give Contest");
    }
}
class Program 
{ 
    
    public static void Main() 
    { 
        JIPCStudent jipcStudent = new JIPCStudent("Dipto",27);
        jipcStudent.ShowInfo();

        CPStudent cpStudent = new CPStudent("Pritom",27);
        cpStudent.ShowInfo();
        

    } 
}
*/

/*
// ============================================================
//     OOP - METHOD OVERLOADING = Compile-Time Polymorphism
// ============================================================
//
// Method Overloading means defining multiple methods with
// the same name but different parameters.
//
// Here, Quiz() is overloaded with different parameter lists.
//
// Quiz()                          → 0 parameter
// Quiz(int duration)              → 1 parameter
// Quiz(int startTime, int endTime, int duration) → 3 parameters
//
// Benefit:
// The same method name can be used for different purposes.
//
// ============================================================
using System;

public class JIPCStudent
{
    public void Quiz()
    {
        Console.WriteLine("Quiz for Practice");
    }
    public void Quiz(int duration)
    {
        Console.WriteLine("Quiz for Preparation");
    }
    public void Quiz(int startTime,int endTime,int duration)
    {
        Console.WriteLine("Quiz with Time");
    }

}
class Program
{
    public static void Main()
    {
        JIPCStudent jipc = new JIPCStudent();
        jipc.Quiz();
        jipc.Quiz(10);
        jipc.Quiz(10,10,10);

    }
}
*/

// ============================================================
//          OOP - RUNTIME POLYMORPHISM / METHOD OVERRIDING
// ============================================================
//
// Runtime Polymorphism is achieved through Method Overriding.
//
// Parent Class  → Course
// Child Class   → JIPCCourse
//
// Parent method:
// virtual Quiz()
//
// Child method:
// override Quiz()
//
// The child class provides its own implementation of the
// method defined in the parent class.
//
// ============================================================
using System;

public class Course
{
    public string Title;
    public string Description;
    public void ShowInfo()
    {
        Console.WriteLine("Title: {0}" ,Title);
    }
    public virtual void Quiz()// 'virtual' is used to allow this method to be overridden in the derived/child class.
    {
        Console.WriteLine("Score Quiz");
    }

}

public class JIPCCourse : Course
{
    public override void Quiz()
    {
        int start = 10;
        int end = 100;
        Console.WriteLine("Score JIPC Quiz {0} - {1}",start,end);
    }
}

class Program
{
    public static void Main()
    {
        JIPCCourse course = new JIPCCourse();
        course.Title = "JIPC";
        course.ShowInfo();
        course.Quiz();
    }
}