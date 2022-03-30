using System;
using System.Collections.Generic;

namespace practice
{
    class Program
    {
        static  void Main(string[] args)
        {  
           //converting data types  
        //    Console.WriteLine("hello");
        //    int x = 50 ;
        //    double y = x;
        //    Console.WriteLine(y);
        //    Console.WriteLine("enetr your name");
        //   string name =  Console.ReadLine();
        
        // Console.WriteLine($"your name is {name}");
        
        // int t1 = 40;
        // t1 += 70; // same as t1 = t1 + 40
        // int t2 = 40;
        // t2 -= 40;
        // Console.WriteLine(t1);
        // Console.WriteLine(t2);

        // string names = "ouma, khachi";
        // int position = names.IndexOf("ouma");
         
        //  bool waether = true;
        //  bool nice = false ;
        //  if (waether == nice){
        //      Console.WriteLine("perfect");
        //  }
        //  else {
        //      Console.WriteLine("not true");
        //  }

        //string schools = "tembe";
    //     Console.WriteLine("enter the school you went to");
    //    string hold =  Console.ReadLine();
    //     switch (hold)
    //     {
    //         case "hanyani thomo" :
    //         Console.WriteLine("hanyani");
    //         break;

    //         case "giyani":
    //         Console.WriteLine("giyani");
    //         break;
    //         default:
    //         Console.WriteLine("no matching school");
    //         break;
    //     }
        bool com = false;
        int number = 9;
        switch (number)
        {
            case 10:
             int test1 = 5;
             if (test1 <= number){
                 Console.WriteLine("you do not qualify");
             }
             else{
                 Console.WriteLine("you have passed");
             }
            break;
           
            case 9:
            int test2 = 2;
            string results = (test2 >= number) ? "good" : "bad" ;   
            Console.WriteLine(results);
            break;

            default:
            bool compare = true;
            bool result = compare && com;
            Console.WriteLine(result);
            break;
        }


        }
    }
}
