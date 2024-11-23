



int Division(int dividend, int divisor)
{
    if (dividend > 100 | dividend <= 0)
        throw new ArgumentOutOfRangeException("Dividend must be between 0 and 100");
    
    if (dividend % divisor != 0)
        throw new Exception("Quotient is not an integer");

    int result = dividend / divisor;
    return result;
}
