using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ProgPOE
{
    class UserResponseSystem
    {
        public void ResponseSystem()
        {
            //stores all the values of the questions and answers
            Dictionary<string, string> questions = new Dictionary<string, string>
            {

        { "how are you", "I am a computer program, I do not have feelings" },
        { "what is your purpose", "I am here to help you learn about cybersecurity" },
        { "what can i ask about you", "You can ask me anything about cybersecurity" },

        {"password saftey", "Password safety is the practice of keeping your passwords secure and not sharing them with anyone" },
        {"what makes a strong password","A strong password is at least 12 characters long and includes a mix of uppercase letters, lowercase letters, numbers, and " +
        "special symbols. Avoid using personal information or common words!" },
        {"should i reuse passwords","No! Using the same password across multiple sites is risky. If one site is hacked, all your accounts could be compromised. " +
        "Use a password manager instead" },
        {"how often should i change my password","Change your passwords regularly, especially if you suspect a security breach. However, using unique, " +
        "strong passwords is more important than frequent changes."},
        {"what is two factor authentication","2FA adds an extra layer of security by requiring a second form of verification, " +
        "like a code sent to your phone. Always enable it for important accounts" },

        {"phinshing", "Phishing attacks are when a hacker tries to trick you into giving them your personal information" },
        {"what is phishing","Phishing is a cyber attack where scammers trick you into giving personal info by pretending to be a trustworthy source, " +
        "like your bank or a friend." },
        {"how do i recognize a phishing email","Look for bad grammar, urgent language, suspicious links, or unexpected attachments. Always verify before clicking!"},
        {"what should i do if i get a phishing message","Do NOT click any links. Report the message as phishing, delete it, and, if necessary, " +
        "alert your IT department or bank." },
        {"can phishing happen outside of emails","Yes! Scammers use phone calls, social media messages, and fake websites. " +
        "Always double-check links and sender details." },

        {"safe browsing", "Safe browsing is the practice of only visiting websites that are safe and secure" },
        {"how do i browse safely online","Use strong passwords, enable 2FA, avoid suspicious links, and only enter personal details on secure (HTTPS) websites" },
        {"what does https mean","HTTPS means a website is secured with encryption. Always check for \"https://\" in the URL before entering sensitive info." },
            };



            Console.WriteLine("hello, what is your name");
            String name = Console.ReadLine();


            Console.Write($"\nHello {name} welcome to the cybersecurity awareness program");


            String UserInput;

            //Greets you with the name you entered and uses colors for user readablity
            Console.Write($"\nI am a cyber security bot\nyou may ask me questions based on my knowledge or type ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\"exit\"");
            Console.ResetColor();

            Console.Write("to quit\nif you type ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\"key\"");
            Console.ResetColor();

            Console.Write(" then information regarding data will be displayed\n");

            //makes user input green for more readability
            Console.ForegroundColor = ConsoleColor.Green;
            UserInput = Console.ReadLine();
            Console.ResetColor();

            do
            {
                //checks if user did not input anything
                if (String.IsNullOrEmpty(UserInput))
                {
                    Console.WriteLine("\nBot: you have not written anything please refer to the key ask questions\n");
                }
                //pulls up a key for the user to view potential questions
                else if (UserInput == "key" || UserInput == "Key")
                {
                    Key();
                }
                //outputs answers to the users based on what they inputted from the key
                else if (questions.ContainsKey(UserInput.ToLower()))
                {
                    Console.WriteLine($"\nBot: {questions[UserInput.ToLower()]}\n");
                }
                //if the user inputted something that is not in the key
                else
                {
                    Console.WriteLine("\nBot: I do not understand that question. plese refer to the key or check spelling\n");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{name}: ");
                UserInput = Console.ReadLine();
                Console.ResetColor();


            } while (UserInput != "exit");


        }
        //guides the user on what they can ask
        public void Key()
        {
            Console.WriteLine("Only the following things may be searched check for spelling and phrasing using the key\n");
            Console.WriteLine($"Key\n" +
                "how are you\n" +
                "What is your purpose\n" +
                "what can i ask about you\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("password saftey\n");
            Console.ResetColor();
            Console.WriteLine(
                "-What makes a strong password\n" +
                "-Should I reuse passwords\n" +
                "-How often should I change my password\n" +
                "-What is two factor authentication\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("phinshing\n");
            Console.ResetColor();
            Console.WriteLine(
            "-What is phishing\n" +
                "-How do I recognize a phishing email\n" +
                "-What should I do if I get a phishing message\n" +
                "-Can phishing happen outside of emails\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("safe browsing\n");
            Console.ResetColor();
            Console.WriteLine(
                "-How do I browse safely online\n" +
                "-What does HTTPS mean");
        }

    }
}

