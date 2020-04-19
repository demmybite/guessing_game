using System;

namespace guessing_game {
    class Program {
        static void Main (string[] args) {
            int secret_number_easy = 9;
            int secret_number_medium = 19;
            int secret_number_hard = 43;

            int guess_limit_easy = 6;
            int guess_limit_medium = 4;
            int guess_limit_hard = 3;

            Console.WriteLine ("WELCOME TO THE GUESSING GAME !!!");
            Console.WriteLine ("What level do you wanna play?");
            Console.Write ("Enter level [ easy or medium or hard ]: ");
            string level = Console.ReadLine ();

            if (level == "easy") {
                Console.WriteLine ("You have 6 guesses in all and your guesses should be between 1 - 10 ");

                int guess_count = 0;
                while (guess_count < guess_limit_easy) {
                    Console.Write ("Guess: ");
                    int guess = int.Parse (Console.ReadLine ());

                    if (guess == secret_number_easy) {
                        Console.WriteLine ("You got it right!");
                        break;

                    }
                    Console.WriteLine ("That was wrong");
                    if (guess_count == 5) {
                        Console.WriteLine ("Game over!");
                        break;
                    }
                    Console.WriteLine ("You have " + (guess_limit_easy - guess_count - 1) + " guesses left");
                    guess_count++;

                }

            } else if (level == "medium") {
                Console.WriteLine ("You have 4 guesses in all and your guesses should be between 1 - 20 ");

                int guess_count = 0;
                while (guess_count < guess_limit_medium) {
                    Console.Write ("Guess: ");
                    int guess = int.Parse (Console.ReadLine ());

                    if (guess == secret_number_medium) {
                        Console.WriteLine ("You got it right!");
                        break;

                    }
                    Console.WriteLine ("That was wrong");
                    if (guess_count == 3) {
                        Console.WriteLine ("Game over!");
                        break;
                    }
                    Console.WriteLine ("You have " + (guess_limit_medium - guess_count - 1) + " guesses left");
                    guess_count++;

                }
            } else if (level == "hard") {
                Console.WriteLine ("You have 3 guesses in all and your guesses should be between 1 - 50 ");

                int guess_count = 0;
                while (guess_count < guess_limit_hard) {
                    Console.Write ("Guess: ");
                    int guess = int.Parse (Console.ReadLine ());

                    if (guess == secret_number_hard) {
                        Console.WriteLine ("You got it right!");
                        break;

                    }
                    Console.WriteLine ("That was wrong");
                    if (guess_count == 2) {
                        Console.WriteLine ("Game over!");
                        break;
                    }
                    Console.WriteLine ("You have " + (guess_limit_hard - guess_count - 1) + " guesses left");
                    guess_count++;

                }

            }
        }
    }
}