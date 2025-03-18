using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotCyberSecurityApp
{


    internal class AsciiTextImage
    {
        public AsciiTextImage()
        {
           
            string enter = "Tap enter to continue";
            string title = @"
            
          
░█████╗░██╗░░░██╗██████╗░███████╗██████╗░  ░██████╗██╗░░██╗██╗███████╗██╗░░░░░██████╗░
██╔══██╗╚██╗░██╔╝██╔══██╗██╔════╝██╔══██╗  ██╔════╝██║░░██║██║██╔════╝██║░░░░░██╔══██╗
██║░░╚═╝░╚████╔╝░██████╦╝█████╗░░██████╔╝  ╚█████╗░███████║██║█████╗░░██║░░░░░██║░░██║
██║░░██╗░░╚██╔╝░░██╔══██╗██╔══╝░░██╔══██╗  ░╚═══██╗██╔══██║██║██╔══╝░░██║░░░░░██║░░██║
╚█████╔╝░░░██║░░░██████╦╝███████╗██║░░██║  ██████╔╝██║░░██║██║███████╗███████╗██████╔╝
░╚════╝░░░░╚═╝░░░╚═════╝░╚══════╝╚═╝░░╚═╝  ╚═════╝░╚═╝░░╚═╝╚═╝╚══════╝╚══════╝╚═════╝░

";

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(enter);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(title);
                            Console.ReadKey();
        }
    }
}
