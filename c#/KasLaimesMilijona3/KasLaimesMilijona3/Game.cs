using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasLaimesMilijona3
{
    class Game
    {
        public Question[] Questions { get; set; }

        public void PlayGame()
        {
            string[] pinigai = new string[5] { "100", "1000", "10000", "100000", "1000000" };

            Console.WriteLine("Sveiki atvykę į žaidimą KAS LAIMĖS MILIJONĄ!!!!!");
            Console.WriteLine("Žaidimas labai paprastas. Tau tereikia atsakyti į 5 nesudėtingus klausimus");
            Console.WriteLine("Žinoma, būtinai pasverk riziką, kad klaidingo atsakymo atveju prarasi savo jau laimėtus pinigus");
            Console.WriteLine();
            Console.WriteLine("Jei esi pasiruošęs patikrinti savo žinias spausk ENTER");
            Console.ReadLine();
            Console.Clear();

            foreach (var question in Questions)
            {
                PrintQuestionAndStatus(question);
                Console.WriteLine("Iveskite atsakyma: ");
                var playerAnswer = Console.ReadLine();
                Console.WriteLine();

                if (playerAnswer.ToLower() == question.CorrectAnswer)
                {
                    Console.WriteLine("Atsakymas teisingas! Jūs laimėjote " + pinigai);

                    if (Questions.LastOrDefault() == question)
                    {
                        Console.WriteLine("Sveikiname tapus milionieriumi!");
                        Environment.Exit(0);
                    }
                    AskIfContinue();
                }
                else
                {
                    Console.WriteLine("Atsakymas neteisingas. Zaidimas baigtas");
                    AskIfRepeatGame();
                }
            }

        }


        private void PrintQuestionAndStatus(Question question)
        {
            Console.WriteLine(question.QuestionString);
            foreach (var answer in question.Answers)
            {
                Console.WriteLine(answer.AnswerString);
            }
            Console.WriteLine();
        }

        private void AskIfContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Ar norite tęsti žaidimą? T/N");
            var continueGame = Console.ReadLine();

            if (continueGame.ToLower() == "t")
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Zaidimas baigtas. Jus laimejote: ");
                AskIfRepeatGame();
            }
        }

        private void AskIfRepeatGame()
        {
            Console.WriteLine();
            Console.WriteLine("Ar norite kartoti zaidima? T/N");
            var repeat = Console.ReadLine();
            if (repeat.ToLower() == "t")
            {
                Console.Clear();
                PlayGame();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
