//QUESTION: How to reverse a string?
using System;

   
    string a,b="";
Console.WriteLine("Reverse edilecek metin giriniz: ");
a = Console.ReadLine();
char[] c = a.ToCharArray();

for (int i = c.Length-1; i > -1; i--)
{
    b = b + c[i];
} 
Console.WriteLine(b);

