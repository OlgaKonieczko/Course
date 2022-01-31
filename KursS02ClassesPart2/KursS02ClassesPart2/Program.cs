using System;

namespace KursS02ClassesPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string title;
            string text;
            string vote;
            bool end = false;


            var newPost = new Post();

            Console.WriteLine("Wpisz tytuł");
            title = Console.ReadLine();

            Console.WriteLine("Wpisz treść posta");
            text = Console.ReadLine();

            newPost.New(title, text);

            Console.WriteLine("Oto Twój nowy post:");
            for (int i = 0; i < newPost.WholePost.Count; i++)
            {
                Console.WriteLine(newPost.WholePost[i]);
            }



            Console.WriteLine("Aby zaplusować post, wpisz '+', aby zminusować wpisz '-'");

            while (end == false)
            {
                vote = Console.ReadLine();

                if (vote == "+")
                {
                    newPost.voteAdd();
                    Console.WriteLine(newPost.VoteValue);
                }

                else if (vote == "-")
                {
                    newPost.voteMinus();
                    Console.WriteLine(newPost.VoteValue);
                }

                else
                {
                    end = true;
                }

            }

        }
    }
}
