namespace FiboEvenSum;
public class TheFiboEvenSum
{
    public static int fiboLength;
    public int firstNumber;
    public int secondNumber;
    public int sumEven = 0;
    public void GetEvenSum()
    {
        for (int i = 0; i >= 0; i++)
        {
            Console.WriteLine ("Define max length");
            fiboLength = Convert.ToInt32(Console.ReadLine());
            if (fiboLength >= 0 && fiboLength < 4000000)
            {
                break;
            }
            else
            {
                Console.WriteLine ("Invalid Entry");
            
            }
        }
        
            int [] fiboArr = new int [fiboLength];

            Console.WriteLine ("first number");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            fiboArr[0] = firstNumber;

            Console.WriteLine ("second number");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            fiboArr[1] = firstNumber;

            for (int c = 2; c < fiboLength; c++)
            {
                fiboArr[c] = fiboArr[c-1] + fiboArr[c-2];
            }

            for (int e = 0; e < fiboLength; e++)
            {
                if (fiboArr[e] % 2 == 0)
                {
                    sumEven += fiboArr[e];
                }
            }
            Console.Write("The Sum of the Even terms is: " + sumEven);
    }
}