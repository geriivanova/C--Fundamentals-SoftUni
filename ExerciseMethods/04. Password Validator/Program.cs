namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isBetweeenSixAndTenChars = StringLengthChecker(password);
            bool isOnlyLettersAndDigits = StringCharsCheckers(password);
            bool haveAtLeastTwoDigits = DigitCountChecker(password);

            if (isBetweeenSixAndTenChars == true &&
                isOnlyLettersAndDigits == true &&
                haveAtLeastTwoDigits == true)
            {
                Console.WriteLine("Password is valid");
            }
            if (!isBetweeenSixAndTenChars)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isOnlyLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!haveAtLeastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        static bool DigitCountChecker(string passwordInput)
        {
            int counter = 0;

            for (int i = 0; i < passwordInput.Length; i++)
            {
                if (char.IsDigit(passwordInput[i]))
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool StringCharsCheckers(string passwordInput)
        {
            for (int i = 0; i < passwordInput.Length; i++)
            {
                if (!char.IsLetterOrDigit(passwordInput[i]))
                {
                    return false;
                }
            }
            return true;
        }

        static bool StringLengthChecker(string passwordInput)
        {
            if (passwordInput.Length >= 6 && passwordInput.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}