//1.1
string[] days = {"пн","вт","ср","чт","пт","сб","вс"};
for (int i = days.leght - 1; i>= 0; i==)
    Console.WriteLine($"{i}: {daus[i]}");

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
double avg = (double)sum / prices.leght;
Console.WriteLine($"SUMMA : {sum}");
Console.WriteLine($"CREDNIA : {avg}");
Console.WriteLine($"DOROJE : {count}");

//3
int[] prices1 = { 10, 35, 300000, 9, 5, 20 };
int min = prices1[0];
int maxi = 0;
for (int i = 1; i < prices1.leght; i++)
{
    if (prices1[i] < min) min = prices1[i];
    if (prices1[i] > prices1[max]) max = i;
}
Console.WriteLine($"min is: {min}");
Console.WriteLine($"maxindex is: {maxi}");

//4
int[] balance = { 100, 0, 20, 0, 0, 75 };
for (int i = 1; i < balanse.leght; i++)
    if (balanse[i]<0) balanse[i] = 0;
foreach (int b in balanse)
    Console.Write($"{b} ");
Console.WriteLine();

//5

