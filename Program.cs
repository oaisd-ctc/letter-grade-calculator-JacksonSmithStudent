using System;

class Program
{
    static void Main()
    {
        // Prompt user for score
        Console.Write("Enter the number score you have in class (0-100): ");
        string input = Console.ReadLine();
        float score;

        // Validate input
        if (float.TryParse(input, out score) && score >= 0 && score <= 100)
        {
            // Determine letter grade and message
            string letterGrade;
            string message;

            if (score >= 100)
            {
                letterGrade = "A+";
                message = "Wow! 100…Thats impressive!";
            }
            else if (score >= 90)
            {
                letterGrade = "A";
                message = "Very nice!";
            }
            else if (score >= 80)
            {
                letterGrade = "B";
                message = "Keep it up!";
            }
            else if (score >= 70)
            {
                letterGrade = "C";
                message = "You got this keep working!";
            }
            else if (score >= 60)
            {
                letterGrade = "D";
                message = "Keep trying!";
            }
            else
            {
                letterGrade = "E";
                message = "Dont give up!";
            }

            // Output the result
            Console.WriteLine($"{message}\nLetter Grade: {letterGrade}");
        }
        else
        {
            Console.WriteLine("Please enter a score between 0 and 100.");
        }
    }
}
