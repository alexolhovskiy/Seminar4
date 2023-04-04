/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.


//Alex Olhovskiy
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
    //Pow making
    Console.WriteLine("Enter num A");
    int num_a=int.Parse(Console.ReadLine());
    Console.WriteLine("Enter num B (>=0)");
    int num_b=int.Parse(Console.ReadLine());
    Console.WriteLine("Result is "+MyPow(num_a,num_b));
    
    //Digits of a number summation
    Console.WriteLine("Enter num");
    int num=int.Parse(Console.ReadLine());
    Console.WriteLine("Result is "+DigitsSum(num));
    
    //Array making
    MyArray();
  }
  
  public static int MyPow(int num,int num_pow)
  {
    int res=num;
    if(num_pow!=0)
    {
        for(int i=1;i<num_pow;i++)
        {
            res*=num;
        }
    }
    else
    {
        res=1;
    }
    
    return res;
  }
  
  public static int DigitsSum(int num)
  {
    int res=0;
    for(;num>0;num/=10)
    {
        res+=num%10;
    }
    return res;
  }
  
  public static void MyArray()
  {
    int length=8;
    int[]arr=new int[length];
    Random rand=new Random();
    for(int i=0;i<length;i++)
    {
        arr[i]=rand.Next(0,10);
    }
    
    Console.Write("Array is: ");
    for(int i=0;i<length;i++)
    {
        Console.Write(arr[i]+" ");
    }
  }
    
}
