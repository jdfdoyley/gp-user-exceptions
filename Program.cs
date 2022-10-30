/******************************************************************************\
* Name: Jason D. F. D'Oyley
* Date: October 30, 2022
* Assignment CIS214 Week 4 GP - User Generated Exceptions
*
* Main application (program) class.
* In this application we will demonstrate the use of exception handling
* to generate exception, allowing the program to continue operating after
* an exception is thrown.
\******************************************************************************/

public class UserExceptions
{
    // demonstrate generating an exception when division by zero is detected
    public static int Quotient(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            // throw an exception with a custom message - generating your own
            // exception allows you to be specific rather than getting an
            // ArithmeticException and assuming the issue is zero denominator
            throw new Exception("Division by zero is not allowed!!");
        }

        // if the exception is thrown, the code will never reach this line,
        // avoiding the system generating an error
        return numerator / denominator;
    }

    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine(
            "\nJason D'Oyley - Week 5 GP - User Generated Exception\n"
        );

        bool cont = true; // loop control variable

        do
        {
            try
            {
                Console.Write("Please enter an integer numerator: ");
                string? val = Console.ReadLine();
                int numerator = Convert.ToInt32(val);

                Console.Write("Please enter an integer denominator: ");
                val = Console.ReadLine();
                int denominator = Convert.ToInt32(val);

                int res = Quotient(numerator, denominator);
                Console.WriteLine(
                    "\nResult: {0} / {1} = {2}", numerator, denominator, res
                );
                cont = false;
            }
            catch (FormatException e)
            {
                // Print the exception that was caught
                Console.WriteLine("\nException: {0}", e);

                // Discard the input so the user can try again
                Console.WriteLine(
                    "You must enter integers. Please try again."
                );
            }
            catch (Exception e)
            {
                // Print the exception that was caught
                Console.WriteLine("\nUser-Generated Exception: {0}", e);
                Console.WriteLine("{0} Please try again.", e.Message);
            }

        } while (cont);
    }
}