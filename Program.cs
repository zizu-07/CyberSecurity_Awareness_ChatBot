using System; // Importing the System namespace for basic functionalities
using System.Collections.Generic; // Importing the Collections.Generic namespace for using Dictionary
using ChatBotCyberSecurityApp; // Importing the ChatBotCyberSecurityApp namespace for custom classes

class CyberSecurityChatBot
{
    static void Main() // Main method - entry point of the application
    {
        VoiceMessage voiceMessage = new VoiceMessage(); // Creating an instance of VoiceMessage class
        AsciiTextImage asciiTextImage = new AsciiTextImage(); // Creating an instance of AsciiTextImage class

        Console.Title = "Cybersecurity Awareness Bot"; // Setting the console window title
        Console.ForegroundColor = ConsoleColor.Cyan; // Changing the text color to Cyan
        Console.WriteLine("-------------------------------------------------"); // Printing a separator line
        Console.WriteLine("*   Welcome to CyberSecurity Awarenss ChatBot   *"); // Welcome message
        Console.WriteLine("-------------------------------------------------"); // Printing a separator line
        Console.ResetColor(); // Resetting the console color to default

        string userName = ""; // Initializing userName variable
        while (string.IsNullOrWhiteSpace(userName)) // Loop until a valid name is entered
        {
            Console.Write("Enter your name: "); // Prompting user for their name
            userName = Console.ReadLine()?.Trim(); // Reading and trimming user input
            if (string.IsNullOrWhiteSpace(userName)) // Checking if the input is empty
            {
                Console.ForegroundColor = ConsoleColor.Red; // Changing text color to Red for error message
                Console.WriteLine("Name cannot be empty. Please enter a valid name.\n"); // Error message
                Console.ResetColor(); // Resetting the console color to default
            }
        }

        Console.ForegroundColor = ConsoleColor.Green; // Changing text color to Green
        Console.WriteLine($"\nHello {userName}, how can I assist you today?"); // Greeting the user
        Console.WriteLine("(Type 'exit' to end the conversation)\n"); // Instructions for exiting
        Console.ResetColor(); // Resetting the console color to default

        // Initializing a dictionary to hold predefined responses
        Dictionary<string, string> responses = new Dictionary<string, string>
        {
            {"HOW ARE YOU", "I'm just a bot, but I'm here to help you stay safe online!"}, // Response for 'HOW ARE YOU'
            {"WHAT'S YOUR PURPOSE", "I am here to educate you about cybersecurity and online safety."}, // Response for 'WHAT'S YOUR PURPOSE'
            {"WHAT CAN I ASK YOU ABOUT", "You can ask me about Password Safety, Phishing, and Safe Browsing."}, // Response for 'WHAT CAN I ASK YOU ABOUT'
            {"WHAT IS PASSWORD SAFETY", "Password safety refers to best practices for creating, managing" +
            ", and protecting passwords to prevent unauthorized access to your accounts and systems. " +
            "Good password safety is essential for cybersecurity," +
            " as weak or compromised passwords are a common way hackers gain access to sensitive information"}, // Detailed response for 'WHAT IS PASSWORD SAFETY'
            {"WHAT IS PHISHING", "Phishing is a type of cyber attack where attackers impersonate legitimate entities" +
            " (such as banks, social media platforms, or employers) to trick individuals into revealing sensitive information like passwords," +
            " credit card details, or personal data."}, // Detailed response for 'WHAT IS PHISHING'
            {"WHAT IS SAFE BROWSING", "Safe browsing refers to practices and technologies that help" +
            " protect users from online threats such as malware, phishing, and malicious websites while using the internet." +
            " It ensures that your personal information, devices, and online accounts remain secure."} // Detailed response for 'WHAT IS SAFE BROWSING'
        };

        while (true) // Infinite loop to keep the conversation going
        {
            Console.Write(userName + ": "); // Prompting user for input
            string userInput = Console.ReadLine()?.Trim().ToUpper(); // Reading and processing user input

            if (string.IsNullOrWhiteSpace(userInput)) // Checking if the input is empty
            {
                Console.ForegroundColor = ConsoleColor.Red; // Changing text color to Red for error message
                Console.WriteLine("Invalid input. Please enter a question or command."); // Error message
                Console.ResetColor(); // Resetting the console color to default
                continue; // Continuing to the next iteration of the loop
            }

            if (userInput == "EXIT") // Checking if the user wants to exit
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // Changing text color to Yellow for exit message
                Console.WriteLine("Goodbye! Stay safe online."); // Exit message
                Console.ResetColor(); // Resetting the console color to default
                break; // Breaking the loop to end the program
            }

            if (responses.ContainsKey(userInput)) // Checking if the user input matches any predefined responses
            {
                Console.ForegroundColor = ConsoleColor.Blue; // Changing text color to Blue for bot response
                Console.WriteLine("Bot: " + responses[userInput]); // Displaying the bot's response
                Console.ResetColor(); // Resetting the console color to default
            }
            else // If the input does not match any predefined responses
            {
                Console.ForegroundColor = ConsoleColor.DarkRed; // Changing text color to Dark Red for unrecognized input
                Console.WriteLine("Bot: I didn't quite understand that. Could you rephrase?"); // Prompting user to rephrase
                Console.ResetColor(); // Resetting the console color to default
            }
        }
    }
}


