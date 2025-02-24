using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _01._2025
{
    internal class Program
    {
        public class Letter
        {
            /// <summary>
            /// Идентификатор
            /// </summary>
            public int Id { get; set; }

            /// <summary>
            /// Заголовок
            /// </summary>
            public string Title { get; set; }

            /// <summary>
            /// Тело письма
            /// </summary>
            public string Body { get; set; }

            /// <summary>
            /// Новое ли письмо
            /// </summary>
            public bool IsNew { get; set; }

            /// <summary>
            /// Во сколько письмо было получено
            /// </summary>
            public DateTime Received { get; set; }
        }
        public class Mail
        {
            public Mail(string email)
            {
                Email = email;
                Letters = new List<Letter>();
            }

            public string Email { get; set; }

            public List<Letter> Letters { get; set; }

            public void CreateRandomLetters(int count)
            {
                var currentCount = Letters.Count;

                for (int i = currentCount; i < currentCount + count; i++)
                {
                    Letters.Add(new Letter
                    {
                        Id = i,
                        Title = $"Title {i}",
                        Body = $"Body {i}",
                        IsNew = i % 2 == 0,
                        Received = DateTime.Now.AddMinutes(i % 2 > 0 ? i : -i)
                    });
                }
            }

            public List<int> GetNewLetterIds_Classic()
            {
                var res = new List<int>();
                for (int i = 0; i < Letters.Count; i++)
                {
                    if (Letters[i].IsNew)
                        res.Add(Letters[i].Id);
                }
                return res;
            }

            public List<int> GetNewLetterIds_Linq()
            {
                // TODO: Задание 1. напишите здесь linq запрос
                var adults = from res in Letters
                             where res.IsNew == true
                             select res.Id;
                return adults.ToList();
            }

            public void SortByRecived_Classic()
            {
                for (int i = 0; i < Letters.Count - 1; i++)
                {
                    for (int j = i + 1; j < Letters.Count; j++)
                    {
                        if (Letters[i].Received > Letters[j].Received)
                        {
                            Letter temp = Letters[i];
                            Letters[i] = Letters[j];
                            Letters[j] = temp;
                        }
                    }
                }
            }

            public void SortByRecived_Linq()
            {
                // TODO: Задание 2. напишите здесь linq запрос
                Letters = Letters.OrderBy(letter => letter.Received).ToList();
            }
        }
        static HashSet<string> GetNGrams(string text, int n)
        {
            var ngrams = new HashSet<string>();
            var words = text.Split(new[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i <= words.Length - n; i++)
            {
                var ngram = string.Join(" ", words.Skip(i).Take(n));
                ngrams.Add(ngram.ToLower());
            }

            return ngrams;
        }

        static double CalculateJaccardCoefficient(HashSet<string> set1, HashSet<string> set2)
        {
            var intersectionCount = set1.Intersect(set2).Count();
            var unionCount = set1.Union(set2).Count();

            return (double)intersectionCount / unionCount;
        }
        static void Main(string[] args)
        {
            // почтовый ящик пользователя
            var mail = new Mail("user1@mail.com");
            var mail2 = new Mail("user2@mail.com");
            var mail3 = new Mail("user3@mail.com");
            var mail4 = new Mail("user4@mail.com");
            var mail5 = new Mail("user5@mail.com");
            mail.CreateRandomLetters(10);
            mail2.CreateRandomLetters(10);
            mail3.CreateRandomLetters(10);
            mail4.CreateRandomLetters(10);
            mail5.CreateRandomLetters(10);

            // Получение количества новых писем
            var countNewLetters_classic = mail.GetNewLetterIds_Classic();
            Console.WriteLine($"Количество новых писем (Classic): {countNewLetters_classic.Count}");

            var countNewLetters_linq = mail.GetNewLetterIds_Linq();
            Console.WriteLine($"Количество новых писем (Linq): {countNewLetters_linq.Count}");

            // Сортировка писем по дате получения
            // TODO: Задание 2. для mail вызовите метод SortByRecived_Linq и выведите полученные письма
            mail.SortByRecived_Linq();
            mail4.SortByRecived_Linq();
            foreach (var i in mail.Letters)
            {
                Console.Write($"{i} {i.Id} полученно  ");
                Console.Write($"{i.Received}\n");
            }
            //B
            Console.WriteLine("Старые письма:");
            mail4.Letters.Where(j => !j.IsNew).ToList().ForEach(j => Console.WriteLine("Письмо новое? {" + j.IsNew + "} получено " + j.Received));

            var newestEmailTime = mail4.Letters.Where(j => j.IsNew == true).OrderBy(j => j.Received).FirstOrDefault()?.Received;

            Console.WriteLine($"\nСамое новое письмо пришло в: {newestEmailTime}");
            //C
            string text1 = "Hello, how are you? I am fine.";
            string text2 = "Hi there! How are you doing? I am good.";
            int n = 2; // Размер N-грамм

            var ngrams3 = GetNGrams(text1, n);
            var ngrams4 = GetNGrams(text2, n);

            int distinctNGrams3 = ngrams3.Count;
            int distinctNGrams4 = ngrams4.Count;
            double jaccardCoefficient = CalculateJaccardCoefficient(ngrams3, ngrams4);

            Console.WriteLine($"Количество N-грамм в первом тексте: {distinctNGrams3}");
            Console.WriteLine($"Количество N-грамм во втором тексте: {distinctNGrams4}");
            Console.WriteLine($"Коэффициент Жаккара для текстов: {jaccardCoefficient}");
        }
    }
}
