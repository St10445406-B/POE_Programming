using ProgrammingPOE;

namespace ProgrammingPOE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            visual v = new visual();
            UserResponseSystem response = new UserResponseSystem();

            //main calling the methods
            v.logo();
            v.Audio();
            response.ResponseSystem();

            Console.WriteLine("Thank you for using the program");

            Console.ReadLine();
        }

        //references
        //stackflow
        // youtbe video Nelson, 2022 URLhttps://www.bing.com/videos/riverview/relatedvideo?q=youtube+video+explaining+how+to+add+audio
    }
}

