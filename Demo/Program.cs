using System.Linq.Expressions;
using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Format

            //String Format 
            //Equation : Num1 + Num2 = 9
            //int Num1 = 4, Num2 = 5;

            //1. concatnation (+)
            //string Message = "Equation :" + Num1 + " + " + Num2 + " = " + (Num1+Num2);
            //Console.WriteLine(Message);
            //String :  Immutable -> Can't Change After Creation 
            //String Format
            //string Message =  string.Format("Equation : {0} + {1} = {2}", Num1, Num2 , (Num1+ Num2) );
            // Console.WriteLine(Message);
            //string Message = $"Equation : {Num1} + {Num2} = {Num1 + Num2} ";
            //Console.WriteLine(Message); 
            #endregion

            #region Control Statement
            //Control Statement 
            //Control Statement 1. Conditional Statement (If , Switch )
            #region Ex01

            //Using If
            //Console.WriteLine("Enter The Number OF Mounth In The 1st Quarter : ");
            //int MonthNumber = int.Parse(Console.ReadLine());
            //if (MonthNumber == 1)
            //{
            //    Console.WriteLine("Jan");
            //}
            //else if (MonthNumber == 2)
            //{
            //    Console.WriteLine("Feb");

            //}
            //else if (MonthNumber == 3)
            //{
            //    Console.WriteLine("Mar");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Mounth ");
            //}


            //Using Switch
            //Console.WriteLine("Enter The Number OF Mounth In The 1st Quarter : ");
            //int MonthNumber = int.Parse(Console.ReadLine());
            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    default:
            //        Console.WriteLine("Inavalid Mounth");
            //        break;
            //}
            #endregion

            #region Ex02
            // Console.WriteLine("Enter Your Name : ");
            // string Name = Console.ReadLine();
            // if (Name =="khaled" || Name == "Khaled")
            // {
            //     Console.WriteLine($"Hello {Name}");
            // }
            //else if (Name == "Ali" || Name == "ali")
            // {
            //     Console.WriteLine($"Hello {Name}");
            // }
            //else if (Name == "Mai" || Name == "mai")
            // {
            //     Console.WriteLine($"Hello {Name}");
            // }
            // else
            // {
            //     Console.WriteLine("outttttttttttttttttttttt");
            // }


            //using Switch Case

            //Console.WriteLine("Enter Your Name : ");
            //string Name = Console.ReadLine();
            //switch (Name)
            //{
            //    case "khaled":
            //    case "Khaled":
            //        Console.WriteLine($"hi khaled ");
            //        break;
            //    case "Ali ":
            //        Console.WriteLine("hi Ali");
            //        break;
            //    case "Hams":
            //        Console.WriteLine("hi hams");
            //        break;
            //    default:
            //        Console.WriteLine("out ya kalb");
            //        break;
            //}



            #endregion

            #region Ex03
            //Console.WriteLine("Enter Your Age :");
            //int Age = int.Parse(Console.ReadLine());
            //using if
            //if (Age > 18)
            //{
            //    Console.WriteLine("Welcome :)");
            //}
            //else if (Age < 18)
            //{
            //    Console.WriteLine("Bye Bye (:");
            //}
            //else
            //{
            //    Console.WriteLine("Equal !!");
            //}

            //using switch case
            //switch (Age)
            //{
            //    case > 18:
            //        Console.WriteLine("Welcome :)");
            //        break;

            //    case < 18:
            //        Console.WriteLine("Bye Bye (:");
            //        break;
            //    default:
            //        Console.WriteLine("Equal !!");
            //        break;


            //}





            #endregion

            #region C#7

            //object Object = new object();
            //Object = 1;
            ////Object = "khaled";
            //switch(Object)
            //{
            //    case int num when num>0:
            //        Console.WriteLine("is int");
            //        break;
            //       default :
            //        Console.WriteLine("inavalid");
            //        break;
            //}




            #endregion

            #region C#8.0
            // string option = Console.ReadLine();
            //string output =  option switch
            // {
            //     "1" => "option 01" , 
            //     "2" => "option 02 " ,
            //     "3" => "option 02",
            //     "4" => "option 04 ",
            //     _ => "Unspport"

            // };
            //Console.WriteLine(output);


            #endregion



            #region C#9.0
            //string GetCategory(int age) =>
            //age switch
            //{
            //     13 => "Child",
            //    >= 13 and < 20 => "Teenager",
            //    >= 20 and < 65 => "Adult",
            //    >= 65 => "Senior",
            //    _ => "Unknown"

            //};
            #endregion




            #region control loop

            //Control Statement 2. Loop Control Statement(For , For Each , While , Do While)
            //1. For
            //for (/*Statement*/ ; /*Expression*/ ; /*Statement*/ )
            //{
            //    //code
            //}

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 4 };
            ////Foreach
            //foreach (int N in Numbers)
            //{
            //    Console.WriteLine(Numbers[N]);
            //}


            // while 
            //int i = 0;
            //while (i<10)
            //{
            //    Console.WriteLine("hello world");
            //    i++;
            //}

            //do while
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("hello world");
            //    i++;
            //} while ( i < 10 ); 
            #endregion


            //String => Immutable Can't change After creation 

            //string S01;
            // S01 = new string("khaled");
            // S01 = "khaled"; //syntex Sugar
            //StringBuilder so2;
            //so2 = new StringBuilder("khaled");

            //Console.WriteLine("So2" + so2);
            //Console.WriteLine("GetHashCode" + so2.GetHashCode());

            //Console.WriteLine();
            //so2.Append("ali");

            //Console.WriteLine("So2" + so2);
            //Console.WriteLine("GetHashCode" + so2.GetHashCode());
            //string so1 = "ali";
            //so1.Substring(0, 1);
            StringBuilder S01 ;
            S01 =new StringBuilder("khaled") ; //mutable Can Change After Creation 
                                               //S01.Append("khaled"); //insert text + old text
                                               // Console.WriteLine(S01);
            // S01.Replace("khaled" , "ali");
            //Console.WriteLine(S01); 
           

            #endregion
        }
    }
}
