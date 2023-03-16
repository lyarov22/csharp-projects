char x = 'x';
Console.WriteLine("Количество переменных = ");
int d = int.Parse(Console.ReadLine());

Console.WriteLine("Знак +/-");
string z = Console.ReadLine();
double[] ns = new double[d];
double[] cs = new double[d];
string[] count = new string[d];
string[] count1 = new string[d];

for (int i = 0; i < ns.Length; i++)
{
    Console.WriteLine("Степень " + i);
    ns[i] = double.Parse(Console.ReadLine());
}
for (int i = 0; i < ns.Length; i++)
{
    Console.WriteLine("Коэфф " + i);
    cs[i] = double.Parse(Console.ReadLine());
}
for (int j = 0; j < count.Length; j++)
{
    if (j == 0)
    {
        Console.Write("f(x)' = ");
    }
    if (cs[j] < 0)
    {
        count1[j] = "0";
    }
    else if (ns[j] == 1)
    {
        count[j] = cs[j] + " ";
        Console.Write(count[j]);
    }
    else
    {
        count[j] = (ns[j] * cs[j]) + "" + x + "^" + (ns[j] - 1);
        Console.Write(count[j] + z);
    }

}

for (int k = 0; k < count1.Length; k++)
{

    if (k == 0)
    {
        Console.Write(Environment.NewLine + "f(x)'' = ");
    }
    if (cs[k] < 0)
    {
        count1[k] = "0";
        Console.Write(count1[k]);
    }/*else if (ns[k] == 1) 
    { 
        count1[k] = cs[k]+""; 
        Console.Write(count1[k]); 
    }*/
    else
    {
        count1[k] = (ns[k] * (ns[k] - 1)) * cs[k] + "" + x + "^" + (ns[k] - 2);
        Console.Write(count1[k] + z);
    }

}