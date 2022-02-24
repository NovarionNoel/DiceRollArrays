Random die = new Random();

double[] dtotal = new double[11];
double ave = 0;
int a;
int d1;
int d2;
int d3;

Console.WriteLine("Today we're going to roll some dice. How many times would you like to roll the dice?");
a = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    d1 = die.Next(1, 7);
    d2 = die.Next(1, 7);
    d3 = d1 + d2;

    dtotal[d3 - 2]++;
}

Console.WriteLine("The number of times each total was rolled is:");

for (int i = 0; i < dtotal.Length; i++)
{
    Console.WriteLine((i+2) + " : " + dtotal[i]);
}
for (int i = 0; i < dtotal.Length; i++)
{
    dtotal[i] = dtotal[i] * (i + 2);
    ave = dtotal[i] + ave;
}
ave = ave /(double) a;

Console.Write("The average value of the dice rolls is : " + ave);
Console.ReadKey();