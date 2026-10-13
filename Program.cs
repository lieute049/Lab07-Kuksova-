//1.1
string[] days = {"пн","вт","ср","чт","пт","сб","вс"};
for (int i = days.Length - 1; i>= 0; i--)
    Console.WriteLine($"{i}: {days[i]}");

//1.2
double[] t = {5,5, -2.9, 3.3, 0.0, -7,5, 24.9, 1000.0};
foreach(double i in t)
    Console.Write($"{i} ");
Console.WriteLine();
 
 //2
int[] prices = { 120, 45, 300, 80, 15, 210 };
int sum = 0, count = 0;

foreach (int p in prices)
{
    sum+= p;
    if (p > 100) count++;
}
double avg = (double)sum / prices.Length;
Console.WriteLine($"SUMMA : {sum}");
Console.WriteLine($"CREDNIA : {avg}");
Console.WriteLine($"DOROJE : {count}");

//3
int[] prices1 = { 10, 35, 300000, 9, 5, 20 };
int min = prices1[0];
int maxi = 0;
for (int i = 1; i < prices1.Length; i++)
{
    if (prices1[i] < min) min = prices1[i];
    if (prices1[i] > prices1[maxi]) maxi = i;
}
Console.WriteLine($"min is: {min}");
Console.WriteLine($"maxindex is: {maxi}");

//4
int[] balanse = { 100, 0, 20, 0, 0, 75 };
for (int i = 1; i < balanse.Length; i++)
    if (balanse[i]<0) balanse[i] = 0;
foreach (int b in balanse)
    Console.Write($"{b} ");
Console.WriteLine();

//5
int[] num = new int[5];
for (int i = 1; i < num.Length; i++)
{
    Console.Write($"number {i + 1}: ");
    num[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("reverse poriadok");
for (int i = 1; i < num.Length - 1; i>=0; i++)
    Console.Write($"{num[i]}");
int even = 0;
foreach (int i in num)
    if (i %2==0) even++;
Console.WriteLine();
Console.WriteLine($"shetnih {even}");