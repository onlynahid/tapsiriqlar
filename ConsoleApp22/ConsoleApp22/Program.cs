// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
int [] numbers = {1, 2, 3, 4, 5, 6, 7,8 };
int tekededler = 0;
int cutededler = 0;
string tekdir = "tekededdir";
string cutdur = "cutdur";
for (int i = 0; i < numbers.Length;i++)
{
if (numbers[i] % 2 == 0)
    {
    cutededler +=numbers[i];
}
else
    { 
tekededler += numbers[i];
    }
    }
Console.WriteLine(tekededler);
Console.WriteLine(cutededler);


////////////////////////////////////////////





int[] ededler = {1,2,3,4,5,6,7,8};
int tekler = 0;
int cutler = 0;
 
for (int i = 0; i < ededler.Length; i++)
{
if (ededler[i] % 2 == 0)
        {
 cutler += ededler[i];
}
else
{
tekler += ededler[i];
}
}
int sum = tekler - cutler;

Console.WriteLine(tekler); 
Console.WriteLine(cutler); 
Console.WriteLine(sum);




//////// ////////////////////////////////////////
int[] reqemler = { 1, 2, 3, 4, 5, 6, 7, 8 };
for (int i = 0; i < reqemler.Length; i++)
{
int count = 0;
    for (int j = 0; j< reqemler.Length; j++)
    {
if(reqemler[j] == reqemler[i])
        {
 count++;
}
        if( count == 1)
        {
 Console.WriteLine(reqemler[i]);
 }
}
}













