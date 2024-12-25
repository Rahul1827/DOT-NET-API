using std;
using System;

namespace ok;

public class Program
{

    public String Display()
    {
        return "This is a project B";
    
    }

    public static void Main(string[] args) 
    {
    
     Myclass myclass = new Myclass();
        Program program = new Program();
        Console.WriteLine(myclass.GetMessage()); 
        Console.WriteLine(program.Display());   
    }

    

}