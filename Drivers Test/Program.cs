using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivers_Test
{
    class Program
    {
        static void Main()
        {   
            //introduction
            Console.WriteLine("Welcome to Driver's License Exam program") ;
            Console.WriteLine("You must anwser 15 questions correctly to pass") ;
            Console.WriteLine("Press any key to start");
            Console.ReadKey() ;

            //variable declorations 
            string[] questions = {"Question 1", "Question 2", "Question 3",
                "Question 4", "Question 5", "Question 6","Question 7",
                "Question 8", "Question 9","Question 10", "Question 11",
                "Question 12", "Question 13","Question 14", "Question 15",
                "Question 16", "Question 17", "Question 18", "Question 19",
                "Question 20" };
            string[] answerKey = {"B", "D", "A", "A", "C", "A", "B", "A", "C", "D",
            "B", "C", "D", "A", "D", "C", "C", "B", "D", "A"} ;

            string[] userAnswer = new string[20] ;

            int x ;

            int correctHolder =0 ;

            int incorrectHolder = 0 ;

            int PASS_SCORE = 15; //constant
            string entry = "" ; 

            //main loop
            for (x = 0; x < questions.Length; x++)
            {
                Console.WriteLine(questions[x]) ;
                userAnswer[x] = Console.ReadLine().ToUpper() ;
                while (userAnswer[x] != "A" && userAnswer[x] != "B" && userAnswer[x] != "C" && userAnswer[x] != "D" )
                {
                    Console.WriteLine("Please enter a character A-D") ;
                    userAnswer[x] = Console.ReadLine().ToUpper() ;
                }
                if (userAnswer[x] == answerKey[x])
                {
                    correctHolder = correctHolder + 1 ;
                }
                else
                {
                    incorrectHolder = incorrectHolder + 1 ;
                }
            } ;
            //questions correct and incorrect
            Console.WriteLine("You got " + correctHolder + " Correct") ;
            Console.WriteLine("And " + incorrectHolder + " Incorrect") ;
            if (correctHolder >= PASS_SCORE)
            {
                Console.WriteLine("YOU PASSED") ;
            }
            //ask to repeat
            Console.WriteLine("Would you like to enter another test? (Y/N)") ;
            entry = Console.ReadLine().ToUpper() ;
            while (entry != "Y" && entry != "N")
            {
                Console.WriteLine("Please enter Y or N");
                entry = Console.ReadLine().ToUpper();
            }
                if (entry == "N")
            {
                Console.WriteLine("Thanks for using the Driver's License Exam program!") ;
                Console.WriteLine("press any key to exit") ;
                Console.ReadKey() ;
                   ;
                //END OF PROGRAM
            }
            else
            {
                Console.Clear() ;
                Main() ;
            }
        }
    }
}
