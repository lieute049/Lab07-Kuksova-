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

