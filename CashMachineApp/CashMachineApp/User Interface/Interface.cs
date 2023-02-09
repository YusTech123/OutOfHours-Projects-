using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachineApp.User_Interface
{
    public static class Interface
    {
        //Create a Method Called Welcome. I'll encapsulate this to ensure that it never changes. 
        internal static void Welcome()
        {
            //Clear the console screen 
            Console.Clear();
            //Allows me to Set the Title of the Console 
            Console.Title = "WELCOME TO YUSUF CASH MACHINE";
            Console.ForegroundColor = ConsoleColor.White;



            Console.WriteLine("\n \n################### Welcome to My CashMachine App ####################\n \n");
            Console.WriteLine("Please insert your ATM card");
            Console.WriteLine("Please Note:CashMachine will accept and validate a physical card, Please enter the card number and validate it.");
            Utility.PressEnterToContinue();
            
        }

        
    }
    }



