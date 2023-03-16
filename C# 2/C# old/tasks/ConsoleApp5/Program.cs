int N = Convert.ToInt32(Console.ReadLine());
int result = 0;

for (int i = 1; i <= N; i++)
{

    if ((i % 1 != i) && (i % i != 1))
    {
        Console.WriteLine(i);
    }

    else
    {
        Console.WriteLine("netttt");
    }

}

