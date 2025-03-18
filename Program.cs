using System;
using System.Collections.Generic;
using ChatBotCyberSecurityApp;


class CyberSecurityChatBot
{
    static void Main()

    {
        VoiceMessage voiceMessage = new VoiceMessage();
        AsciiTextImage asciiTextImage = new AsciiTextImage();

        Console.Title = "Cybersecurity Awareness Bot";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("*   Welcome to CyberSecurity Awarenss ChatBot   *");
        Console.WriteLine("-------------------------------------------------");
        Console.ResetColor();



        string userName = "";
        while (string.IsNullOrWhiteSpace(userName))
        {
            Console.Write("Enter your name: ");
            userName = Console.ReadLine()?.Trim();
            if (string.IsNullOrWhiteSpace(userName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Name cannot be empty. Please enter a valid name.\n");
                Console.ResetColor();
            }
        }



        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nHello {userName}, how can I assist you today?");
        Console.WriteLine("(Type 'exit' to end the conversation)\n");
        Console.ResetColor();

        Dictionary<string, string> responses = new Dictionary<string, string>
        {
            {"HOW ARE YOU", "I'm just a bot, but I'm here to help you stay safe online!"},
            {"WHAT'S YOUR PURPOSE", "I am here to educate you about cybersecurity and online safety."},
            {"WHAT CAN I ASK YOU ABOUT", "You can ask me about Password Safety, Phishing, and Safe Browsing."},
            {"WHAT IS PASSWORD SAFETY", "Password safety refers to best practices for creating, managing" +
            ", and protecting passwords to prevent unauthorized access to your accounts and systems. " +
            "Good password safety is essential for cybersecurity," +
            " as weak or compromised passwords are a common way hackers gain access to sensitive information"},
            {"WHAT IS PHISHING", "Phishing is a type of cyber attack where attackers impersonate legitimate entities" +
            " (such as banks, social media platforms, or employers) to trick individuals into revealing sensitive information like passwords," +
            " credit card details, or personal data."},
            {"WHAT IS SAFE BROWSING", "Safe browsing refers to practices and technologies that help" +
            " protect users from online threats such as malware, phishing, and malicious websites while using the internet." +
            " It ensures that your personal information, devices, and online accounts remain secure."}
        };

        while (true)
        {
            Console.Write(userName + ": ");
            string userInput = Console.ReadLine()?.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a question or command.");
                Console.ResetColor();
                continue;
            }

            if (userInput == "EXIT")
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Goodbye! Stay safe online.");
                Console.ResetColor();
                break;
            }

            if (responses.ContainsKey(userInput))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Bot: " + responses[userInput]);

                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Bot: I didn't quite understand that. Could you rephrase?");

                Console.ResetColor();
            }
        }
    }
}

