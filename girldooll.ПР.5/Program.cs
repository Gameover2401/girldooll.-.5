Console.WriteLine("Введите значение x (0<=x <1) = ");
double x=double.Parse(Console.ReadLine());
if (x < 0 || x >= 1)
{
    Console.WriteLine("Ошибка, x должно быть в диапозоне [0,1). ");
    return;
}
double f = 1 / (1 - x);
Console.WriteLine($"f(x)=1/(1-x)={f}");

double i = 1;
int d = 10;
for (int n=0; n<d; n++)
{

    i *= (1 + Math.Pow(x, Math.Pow(2, n)));
}
Console.WriteLine($"Эвивалентное произведение(первые {d} членов) : {i}");
