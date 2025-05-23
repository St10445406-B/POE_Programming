using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

    class UserResponseSystem
    {
        private Dictionary<string, string> questions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        // General questions
        { "how are you", "I am a computer program, I do not have feelings." },
        { "what is your purpose", "I am here to help you learn about cybersecurity." },
        { "what can i ask about you", "You can ask me anything related to cybersecurity." },

        // Password-related
        { "password safety", "Password safety is the practice of keeping your passwords secure and not sharing them with anyone." },
        { "what makes a strong password", "A strong password is at least 12 characters long and includes a mix of uppercase letters, lowercase letters, numbers, and special symbols. Avoid using personal information or common words!" },
        { "should i reuse passwords", "No! Using the same password across multiple sites is risky. If one site is hacked, all your accounts could be compromised. Use a password manager instead." },
        { "how often should i change my password", "Change your passwords regularly, especially if you suspect a security breach. However, using unique, strong passwords is more important than frequent changes." },
        { "what is two factor authentication", "2FA adds an extra layer of security by requiring a second form of verification, like a code sent to your phone. Always enable it for important accounts." },

        // Phishing
        { "phishing", "Phishing attacks are when a hacker tries to trick you into giving them your personal information." },
        { "what is phishing", "Phishing is a cyber attack where scammers trick you into giving personal info by pretending to be a trustworthy source, like your bank or a friend." },
        { "how do i recognize a phishing email", "Look for bad grammar, urgent language, suspicious links, or unexpected attachments. Always verify before clicking!" },
        { "what should i do if i get a phishing message", "Do NOT click any links. Report the message as phishing, delete it, and, if necessary, alert your IT department or bank." },
        { "can phishing happen outside of emails", "Yes! Scammers use phone calls, social media messages, and fake websites. Always double-check links and sender details." },

        // Safe Browsing
        { "safe browsing", "Safe browsing is the practice of only visiting websites that are safe and secure." },
        { "how do i browse safely online", "Use strong passwords, enable 2FA, avoid suspicious links, and only enter personal details on secure (HTTPS) websites." },
        { "what does https mean", "HTTPS means a website is secured with encryption. Always check for 'https://' in the URL before entering sensitive info." },
    };
    // Dictionary for questions that require random responses
    Dictionary<string, List<string>> randomResponses = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
{
    {
        "phishing tips", new List<string>
        {
            "Be cautious of emails asking for personal information. Scammers often disguise themselves as trusted organisations.",
            "Never click links from unknown sources. Always verify the sender.",
            "Look for grammar mistakes and urgent messages — they’re often signs of phishing.",
            "Use spam filters and report suspicious emails to your IT department."
        }
    }
};


    public void ResponseSystem()
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"\nHello {name}, welcome to the cybersecurity awareness program.");
            Console.WriteLine("I am a cybersecurity bot. You may ask me questions based on my knowledge or type ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\"exit\"");
            Console.ResetColor();
            Console.Write(" to quit.\nIf you type ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\"key\"");
            Console.ResetColor();
            Console.WriteLine(" then information regarding data will be displayed.\n");

            string userInput;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{name}: ");
                userInput = Console.ReadLine();
                Console.ResetColor();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("\nBot: You have not written anything. Please refer to the key and ask questions.\n");
                }
                else if (userInput.Equals("key", StringComparison.OrdinalIgnoreCase))
                {
                    DisplayKey();
                }
                else if (questions.ContainsKey(userInput.ToLower()))
                {
                    Console.WriteLine($"\nBot: {questions[userInput.ToLower()]}\n");
                }
                else if (randomResponses.ContainsKey(userInput))
                {
                var responses = randomResponses[userInput];
                Random rnd = new Random();
                int index = rnd.Next(responses.Count);
                Console.WriteLine($"\nBot: {responses[index]}\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{name}: ");
                userInput = Console.ReadLine();
                Console.ResetColor();
                continue; // skip the rest of the loop and prompt again
                }
                else
                {
                bool found = false;
                foreach (var keyword in questions.Keys)
                {
                    if (userInput.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine($"\nBot: {questions[keyword]}\n");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("\nBot: Sorry, I don't have an answer for that.\n");
                }
            }

            } while (!userInput.Equals("exit", StringComparison.OrdinalIgnoreCase));
        }

        private void DisplayKey()
        {
            Console.WriteLine("\nOnly the following things may be searched. Check for spelling and phrasing using the key:\n");
            Console.WriteLine("General:\n - how are you\n - what is your purpose\n - what can I ask about you\n");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Password-related:");
            Console.ResetColor();
            Console.WriteLine(" - password safety\n - what makes a strong password\n - should I reuse passwords\n - how often should I change my password\n - what is two factor authentication\n");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Phishing:");
            Console.ResetColor();
            Console.WriteLine(" - phishing\n - what is phishing\n - how do I recognize a phishing email\n - what should I do if I get a phishing message\n - can phishing happen outside of emails\n");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Safe Browsing:");
            Console.ResetColor();
            Console.WriteLine(" - safe browsing\n - how do I browse safely online\n - what does HTTPS mean\n");
        }
    }
