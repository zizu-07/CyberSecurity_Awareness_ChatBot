using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotCyberSecurityApp // Defining a namespace for the application
{
    internal class AsciiTextImage // Declaring an internal class named AsciiTextImage
    {
        public AsciiTextImage() // Constructor for the AsciiTextImage class
        {
            string enter = "Tap enter to continue"; // Message prompting the user to press enter
            string title = @"
            
          
░█████╗░██╗░░░██╗██████╗░███████╗██████╗░  ░██████╗██╗░░██╗██╗███████╗██╗░░░░░██████╗░
██╔══██╗╚██╗░██╔╝██╔══██╗██╔════╝██╔══██╗  ██╔════╝██║░░██║██║██╔════╝██║░░░░░██╔══██╗
██║░░╚═╝░╚████╔╝░██████╦╝█████╗░░██████╔╝  ╚█████╗░███████║██║█████╗░░██║░░░░░██║░░██║
██║░░██╗░░╚██╔╝░░██╔══██╗██╔══╝░░██╔══██╗  ░╚═══██╗██╔══██║██║██╔══╝░░██║░░░░░██║░░██║
╚█████╔╝░░░██║░░░██████╦╝███████╗██║░░██║  ██████╔╝██║░░██║██║███████╗███████╗██████╔╝
░╚════╝░░░░╚═╝░░░╚═════╝░╚══════╝╚═╝░░╚═╝  ╚═════╝░╚═╝░░╚═╝╚═╝╚══════╝╚══════╝╚═════╝░
";

            Console.ForegroundColor = ConsoleColor.White; // Setting the console text color to white
            Console.Write(enter); // Displaying the prompt message to the user
            Console.ForegroundColor = ConsoleColor.DarkCyan; // Changing the console text color to dark cyan
            Console.Write(title); // Displaying the ASCII art title
            Console.ReadKey(); // Waiting for a key press from the user
        }
    }
}
