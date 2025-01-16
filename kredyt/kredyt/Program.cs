Console.WriteLine("Kwota kredytu:");
int kwota = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Oprocentowanie w skali roku:");
double procent = Convert.ToDouble(Console.ReadLine());
procent = procent / 100;

Console.WriteLine("Ilość rat:");
int raty = Convert.ToInt16(Console.ReadLine());

double stopa = procent / 12;

double R = (kwota * stopa * Math.Pow((1 + stopa), raty)) / (Math.Pow((1 + stopa), raty) - 1);

Console.WriteLine("Miesięczna rata kredytu: {0:0.00}", R);
