using System;

class Program{
    static void Main(string[] args){
        int sum = 0;
        string message = "";
        string input = "";

        while (input != "exit")
        {
            Console.Write("Enter something: ");
            input = Console.ReadLine();

            int number;
            bool VlidNum = int.TryParse(input, out number);

            switch (VlidNum)
            {
                case true:
                    sum += number;
                    Console.WriteLine($"Adding {number} to {sum - number} = {sum}");
                    Console.WriteLine();
                    break;
                case false:
                    message += input;
                    Console.WriteLine($"Current Message is: {message}");
                    Console.WriteLine();
                    break;
            }
        }

        Console.WriteLine("Closing Program...");
    }
}