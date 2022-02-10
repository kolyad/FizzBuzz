namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string? inputStr;
            do
            {
                Console.WriteLine("Input number or word 'end' to exit");
                inputStr = Console.ReadLine();
                if (inputStr == "end")
                {
                    break;
                }

                if (!int.TryParse(inputStr, out var number))
                {
                    Console.WriteLine("Wrong number. Try again!");
                    continue;
                }

                bool isDividedByThree = number % 3 == 0;
                bool isDividedByFive = number % 5 == 0;

                var answer = "";

                if (isDividedByThree)
                {
                    answer = "Fizz";
                }

                if (isDividedByFive)
                {
                    answer += "Buzz";
                }

                if (!isDividedByThree && !isDividedByFive)
                {
                    answer = inputStr;
                }

                Console.WriteLine($"The answer is {answer}");
            }
            while (true);

            Console.WriteLine("End of game!");
        }
    }
}