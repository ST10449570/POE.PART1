using System;
using System.Media;
using System.Linq;
/*
using System.speech.Synthesis; //for the voice greeting
*/




    class Chatbot
    {

        static void Main()
        {
        //string variable that stores the path of the greeting audio.
        string audioPath = @"Welcome.wav.wav"; //this ensures the program to know where the audio is stored.


        try //try-catch block  is included to prevent the program from crashing if the audio or filepath is not found.
        {

            using (SoundPlayer player = new SoundPlayer(audioPath)) //the soudplayer is initialized with an audio path.
            {
                player.Load();
                player.Play();//playSync is implemented for the program to wait until the audio finishes before continuing.
            }
        }
        catch(Exception ex) //For when an error occurs it handles it and ithe following message is displayed instead of terminating the program
        {
            Console.WriteLine("error playing audio");
        }
         
        //Defining special characters as char variables.
            char comma = ',';
            char openParen = '(';
            char closeParen = ')';
            char backslash = '\\';
            char underscore = '_';
            char pipe = '|';
            char capitalO = 'O';

            // Building and displaying the logo line by line using char variables.
            // Refrence: used ASCII Robot art to design the logo
            Console.WriteLine("CYBERSECURITY AWARNESS BOT");
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ");
            Console.WriteLine("\n     " + comma + "     " + comma);
            Console.WriteLine("    " + openParen + backslash + "____" + backslash + "/)");
            Console.WriteLine("     (_oo_)");
            Console.WriteLine("       (" + capitalO + ")");
            Console.WriteLine("     __" + pipe + pipe + "__    " + backslash + ")");
            Console.WriteLine("  []/______" + backslash + "[] /");
            Console.WriteLine("  / " + backslash + "______/ " + backslash + "/");
            Console.WriteLine(" /    /__" + backslash);
            Console.WriteLine("(" + backslash + "   /____" + backslash);
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ");
            Console.WriteLine("\n     " + comma + "     " + comma);
            Console.WriteLine("Hello!");
            Console.WriteLine("\nPress any key to START...");
            Console.ReadKey();


        //Text based greeting and user interaction
        Console.Write("Please eneter your name:  ");
        string userName = Console.ReadLine();
        Console.WriteLine($"\nhello, {userName}!  I'm here to answer some basic cybersecurity questioins.\n)");

        // basic Response system
        // We'll do a simple loop to stimulate conversation untiul user types 'exit'.
        Console.WriteLine("Type 'exit' to quit at any time. \n");

        bool keepChatting = true;

        //Here i usede a WHILE LOOP to continousley accept user input until the user types 'exit and goes back to default.
        while (keepChatting)
        {
            Console.Write("Ask a question or type 'exit' : ");
            string userInput = Console.ReadLine().Trim().ToLower();

            if (userInput == "exit")
            {
                keepChatting = false;
            }
            else
            {
                //Basic questions for the user to ask.
                switch (userInput) //a switch expression of try-catch as been evaluated for if the users questions match the basic questions
                                   //then the associated block of code is executed.
                {
                    case "What is cybersecurity?":
                    case "meaning of cyubersecurity":
                        Console.WriteLine("Bot:Cybersecurity is the practice of protecting computers networks, aand data from cyber threats.");
                        break;

                    case "how often should I change my password?":
                    case "how often you should change your password":
                        Console.WriteLine("Bot; Chan ge passwords if they are weak, compromised, or reussed acrtoss multiple accounts.");
                        break;

                    case "how do I recognize a phishing email?":
                    case "how you can look out for a phishing email":
                        Console.WriteLine("Bot:Look for urgent language, misspellings, unknown senders, and suspicious links.");
                        break;

                    case "how are you?":
                    case "how are you":
                        Console.WriteLine("Bot:I'm just a simple program, but I'm finctiontiing perfectly!");
                        break;

                    case "what's your purpose?":
                    case "what is your purpose?":
                        Console.WriteLine("Bot:I am here to raise awarness about cybersecurity.");
                        break;

                    case "what do you do?":
                        Console.WriteLine("Bot:I can answer basic cybersecurity questions and greet you with an audio clip");
                        break;

                    case "how  to stay safe online?":
                    case "how do i stay safe online?":
                        Console.WriteLine("Bot:Use strong passwords,enable multi0factor authentication, and avoid suspicious links.");
                        break;

                    default:
                        // ERROR HANDLING/UNRECOGNIZED INPUT
                        Console.WriteLine("Bot: I'm not sure how to respond to that. Try asking to cybersecurity question.");
                        break;


                }

            }
            Console.WriteLine();


        }
        //Goodbye message
        Console.WriteLine("Thank you for chatting with the Cybersecurity Awarness Bot");
        Console.WriteLine("Stay safe online. Goodbye!");




    }

}
