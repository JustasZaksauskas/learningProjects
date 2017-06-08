using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasLaimesMilijona3
{
    class QuestionHelpers
    {
        private const int QuestionsCount = 5;
        private const int AnswersCount = 4;

        public static Question[] GetGameQuestions()
        {
            return new Question[QuestionsCount] {
                new Question()
                {
                    QuestionString = "Kuris mėnesis turi 28 dienas?",
                    Answers = new Answer[AnswersCount] {
                        new Answer() {AnswerString = "1. Vasaris"} ,
                        new Answer() {AnswerString = "2. Kovas"},
                        new Answer() {AnswerString = "3. Gegužė"},
                        new Answer() {AnswerString = "4. Visi"}
                    },
                    CorrectAnswer = "4"
                },
                new Question() {
                    QuestionString = "Kas sukūrė Lietuvos himną?",
                    Answers = new Answer[AnswersCount] {
                        new Answer() {AnswerString = "1. Kristijonas Donelaitis"} ,
                        new Answer() {AnswerString = "2. Vincas Kudirka"},
                        new Answer() {AnswerString = "3. Jonas Biliūnas"},
                        new Answer() {AnswerString = "4. Justinas Marcinkevičius"}
                    },
                    CorrectAnswer = "2"
                },
                new Question() {
                    QuestionString = "Kuri Skandinavijos šalis neturi sienos su Rusija?",
                    Answers = new Answer[AnswersCount] {
                        new Answer() {AnswerString = "1. Švedija"} ,
                        new Answer() {AnswerString = "2. Norvegija"},
                        new Answer() {AnswerString = "3. Danija"},
                        new Answer() {AnswerString = "4. Suomija"}
                    },
                    CorrectAnswer = "1"
                },
                new Question() {
                    QuestionString = "Keliu rūsių uniformas matome per futbolo varžybas aikštėje?",
                    Answers = new Answer[AnswersCount] {
                        new Answer() {AnswerString = "1. dvi"} ,
                        new Answer() {AnswerString = "2. tris"},
                        new Answer() {AnswerString = "3. keturias"},
                        new Answer() {AnswerString = "4. penkias"}
                    },
                    CorrectAnswer = "4"
                },
                new Question() {
                    QuestionString = "Kuri šalis iš išvardintų yra didziausia pagal teritorijos plota?",
                    Answers = new Answer[AnswersCount] {
                        new Answer() {AnswerString = "1. Vokietija"} ,
                        new Answer() {AnswerString = "2. Norvegija"},
                        new Answer() {AnswerString = "3. Ukraina"},
                        new Answer() {AnswerString = "4. Ispanija"}
                    },
                    CorrectAnswer = "3"

                }
            };
        }

    }
}
