using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MathTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                StartQuiz();
                Console.WriteLine("Продолжить? (да / нет)");
                string i = Console.ReadLine();
                if (i == "нет")
                    break;
            }
            
        }

        

        private static void StartQuiz()
        {
            Random randomizer = new Random();

            int addend1;
            int addend2;
            int correctAnswers = 0;
            List<string> wrongAnswers = new List<string> { };
            int difficulty = DifficultyManager.SetDifficulty();

            Thread counterThread = new Thread(Counter.CountDown);
            counterThread.IsBackground = true;
            counterThread.Start();

            for (int questionNumber = 0; questionNumber < 3; questionNumber++)
            {
                addend1 = randomizer.Next(difficulty * 2);
                addend2 = randomizer.Next(difficulty * 2);
                List<int> numbers = new List<int> { addend1, addend2 };
                string question = string.Format("{0}+{1}=?", addend1, addend2);
                Console.WriteLine(question);
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == numbers.Sum())
                    correctAnswers++;
                else
                    wrongAnswers.Add(question);
            }

            for (int questionNumber = 0; questionNumber < 3; questionNumber++)
            {
                addend1 = randomizer.Next(difficulty);
                addend2 = randomizer.Next(difficulty);
                List<int> numbers = new List<int> { addend1, addend2 };
                string question = string.Format("{0}x{1}=?", addend1, addend2);
                Console.WriteLine(question);
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == numbers.Aggregate((x, y) => x * y))
                    correctAnswers++;
                else
                    wrongAnswers.Add(question);
            }
            counterThread.Abort();
            Console.WriteLine("Вы ответили на {0} вопросов из {1}", correctAnswers, 6);
            if (wrongAnswers.Count > 0)
            {
                Console.WriteLine("Неверные ответы были получены на следующие вопросы:");
                wrongAnswers.ForEach(item => Console.WriteLine(item));
            }
            
        }

        

    }
}
