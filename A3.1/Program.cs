//A3.1. Из трехзначного числа x вычли его последнюю цифру.
//Когда результат разделили на 10, а к частному слева приписали последнюю цифру числа x,
//то получилось число 237. Найти число x.

int n = 237;
int t = n / 100;
n %= 100;
n *= 10;
int x = n + t;
Console.WriteLine("Число х = " + x);


























































