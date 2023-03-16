using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

string s; double a;

StreamWriter f = new StreamWriter("C:\\Users\\dyudy\\Desktop\\projects c#\\workToFilesConsole\\text.txt");

for (a = -2; a <= 2; a = a + 0.571)
{
    s = Convert.ToString(a);
    f.WriteLine(s);
}
f.Close();