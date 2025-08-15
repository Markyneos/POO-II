internal class Program
{
    static void Main(string[] args)
    {
        List<int> A = new List<int>();
        List<int> B = new List<int>();
        List<int> C = new List<int>();
        List<int> D = new List<int>();
        List<int> E = new List<int>();
        int count = 0;

        do
        {
            Console.WriteLine("Insert your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 1 && age < 16)
            {
                A.Add(age);
            }
            else if (age >= 16 && age < 31)
            {
                B.Add(age);
            }
            else if (age >= 31 && age < 46)
            {
                C.Add(age);
            }
            else if (age >= 46 && age < 61)
            {
                D.Add(age);
            }
            else if (age >= 61)
            {
                E.Add(age);
            }
            else
            {
                break;
            }
            count++;
        }
        while (true);

        Console.WriteLine($"Porcentagem de A: {(A.Count() / (double)count) * 100:F2}%");
        Console.WriteLine($"Porcentagem de B: {(B.Count() / (double)count) * 100:F2}%");
        Console.WriteLine($"Porcentagem de C: {(C.Count() / (double)count) * 100:F2}%");
        Console.WriteLine($"Porcentagem de D: {(D.Count() / (double)count) * 100:F2}%");
        Console.WriteLine($"Porcentagem de E: {(E.Count() / (double)count) * 100:F2}%");
    }
}
