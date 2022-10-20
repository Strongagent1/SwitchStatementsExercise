namespace SwitchStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What is your favorite subject in school?");

            string userInput = Console.ReadLine();

            FavSub(userInput);
        }

        public static void FavSub(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is mine too!");
                    break;
                case "science":
                    Console.WriteLine("Teacher's pet.");
                    break;
                case "recess":
                    Console.WriteLine("You have a lot in common with a 1st grader.");
                    break;
                case "english":
                    Console.WriteLine("Snooze.");
                    break;
                case "lunch":
                    Console.WriteLine("Hmmmm, I'm hungry now.");
                    break;
                default:
                    Console.WriteLine("I wasn't very good at that.");
                    break;
            }
        }
    }

}
    

