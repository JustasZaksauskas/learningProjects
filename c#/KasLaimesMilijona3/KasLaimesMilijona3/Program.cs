using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasLaimesMilijona3
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game() { Questions = QuestionHelpers.GetGameQuestions() };

            game.Questions = QuestionHelpers.GetGameQuestions();
            game.PlayGame();
        }
    }
}
 
