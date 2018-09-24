using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTraining
{
    class DifficultyManager
    {
        public static int SetDifficulty()
        {
            Console.WriteLine("Выберите уровень сложности (от 1 до 5)");
            int selectedDifficulty = Convert.ToInt32(Console.ReadLine());
            int quizDifficulty;

            switch (selectedDifficulty)
            {
                case 1:
                    quizDifficulty = 11;
                    break;

                case 2:
                    quizDifficulty = 21;
                    break;

                case 3:
                    quizDifficulty = 31;
                    break;

                case 4:
                    quizDifficulty = 51;
                    break;

                case 5:
                    quizDifficulty = 101;
                    break;

                default:
                    quizDifficulty = 51;
                    break;
            }
            return quizDifficulty;
        }
    }
}
