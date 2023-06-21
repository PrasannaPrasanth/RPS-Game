using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RPS Game");

            Choice user = GetUserInput();
            Choice ai = GetAIInput();
            WinningState state = DetermineWinner(user, ai);
            DisplayRoundResult(user, ai, state);
        }

        public static Choice GetUserInput()
        {
            Console.WriteLine("Please Select Your Choice: 1. Rock, 2. Paper, 3. Scissor");
            int temp = Convert.ToInt32(Console.ReadLine());
            return (Choice)temp;
        }

        public static Choice GetAIInput()
        {
            Random r = new Random();
            int temp = r.Next(1, 4);
            return (Choice)temp;

        }

        public static WinningState DetermineWinner(Choice User, Choice AI)
        {

            WinningState state = WinningState.Draw;
            if (User == AI)
            {
                return state;
            }
            else if (User == Choice.Paper)
            {
                if (AI == Choice.Scissor)
                {
                    state = WinningState.AIWins;
                }
                else
                {
                    state = WinningState.UserWins;
                }
            }
            else if (User == Choice.Rock)
            {
                if (AI == Choice.Paper)
                {
                    state = WinningState.AIWins;
                }
                else
                {
                    state = WinningState.UserWins;
                }
            }
            else if (User == Choice.Scissor)
            {
                if (AI == Choice.Rock)
                {
                    state = WinningState.AIWins;
                }
                else
                {
                    state = WinningState.UserWins;
                }
            }

            return state;
        }


        public static void DisplayRoundResult(Choice user, Choice ai, WinningState state)
        {
            Console.WriteLine("Round Result");
            Console.WriteLine("User Choice is : " + user);
            Console.WriteLine("AI Choice is : " + ai);
            Console.WriteLine("Result is : " + state);
        }

    }

    enum Choice
    {
        Rock = 1,
        Paper = 2,
        Scissor = 3,
    }

    enum WinningState
    {
        Draw = 0,
        UserWins = 1,
        AIWins = 2,
    }
}

