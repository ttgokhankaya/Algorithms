namespace Armstrong;

public static class Algorithm
{
    /// <summary>
    /// Determines whether the specified number is an Armstrong number.
    /// An Armstrong number is a number that is equal to the sum of its own digits each raised to the power of the number of digits.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns><c>true</c> if the specified number is an Armstrong number; otherwise, <c>false</c>.</returns>
    public static bool IsArmstrongNumber(int number)
    {
        int sum = 0;
        int temp = number;
        int length = number.ToString().Length;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, length);
            temp /= 10;
        }

        return sum == number;
    }
}
