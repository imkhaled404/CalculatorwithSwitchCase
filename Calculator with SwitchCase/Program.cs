using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
namespace CalculatorApp {  
    class Program {
         //Addition  
        public static int Addition(int n1, int n2) {  
            int result = n1 + n2;  
            return result;  
        } 

        //Method overloading
        public static int Addition(int n1, int n2,int n3) {  
            int result = n1 + n2 + n3;  
            return result;  
        } 

        //Substraction  
        public static int Subtraction(int n1 , int n2) {  
            int result = n2 + n1;  
            return result;  
        } 
        
        //Multiplication  
        public static int Multiplication(int n1, int n2) {  
            int result = n1 * n2;  
            return result;  
        }  

        //Division  
        public static int Division(int n1, int n2) {  
            int result = n1 / n2;  
            return result;  
        }

        public static int Modulus(int n1, int n2) {  
            int result = n1 % n2;  
            return result;  
        }

        static void Main(string[] args) {  
           /* Console.WriteLine("Enter the action to be performed");  
            Console.WriteLine("Press 1 for Addition");  
            Console.WriteLine("Press 2 for Subtraction");  
            Console.WriteLine("Press 3 for Multiplication");  
            Console.WriteLine("Press 4 for Division");  
            Console.WriteLine("Press 5 for Modulus \n"); */  
            //int action = Convert.ToInt32(Console.ReadLine()); 
            
            Console.WriteLine("Enter 1st input");  //user input 
            int n1 = Convert.ToInt32(Console.ReadLine()); //input from the keyboard and store it in the variable 
            Console.WriteLine("Enter 2nd input");  
            int n2 = Convert.ToInt32(Console.ReadLine());
            //int n3 = 10;
            int result = 0;
            result = Addition(n1,n2); 
            result = Addition(10,12,20); 

            /*switch (action) {  
                case 1: {  
                    result = Addition(n1, n2);  
                    break;  
                }  
                case 2: {  
                    result = Subtraction(n1, n2);  
                    break;  
                }  
                case 3: {  
                    result = Multiplication(n1, n2);  
                    break;  
                }  
                case 4: {  
                    result = Division(n1, n2);  
                    break;  
                } 
                case 5: {  
                    result = Modulus(n1, n2);  
                    break;  
                }  
                default:  
                    Console.WriteLine("Wrong action!! try again");  
                    break;  
            }*/  
            Console.WriteLine("The result is {0}", result); 
            Console.WriteLine("The result is {0}", result1); 
            Console.ReadKey();  
        }  
         
    }  
}  
