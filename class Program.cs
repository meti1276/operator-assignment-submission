class Program
{
    static void Main(string[] args)
    {
        MathMethod mathMethod = new MathMethod(); //Instantiate

    }
}


class MathMethod
{
    public void Operator()
    {
        int num1 = 6;
        int num2 = 9;
    }
    public void Output(int number1, int number2)
    {
        int value = 
    }


// out - means that parameter will be passed out of method
public void Output(int number1, int number2, out int result)
{
    result = number1 + number2;
}
public void AddNumbers()
{
    int ret; // Need to define variable to hold the result
    Output(2, 5, out ret); // Actual call. Note the out keyword

    Console.WriteLine("2 + 5 = " + ret);
}