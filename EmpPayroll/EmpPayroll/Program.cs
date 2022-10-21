class Program
{
    static void Main(string[] args)
    {
        //Uc2
        Random random = new Random();
        var value=random.Next(1,3);

        int empHr;
        if (value == 1)
        {
            empHr = 8;
        }
        else
        {
            empHr = 0;
        }
        Console.WriteLine(empHr);
    }
}