//A3.4. В трехзначном числе x зачеркнули первую цифру. Когда полученное число умножили на 10,
//а произведение сложили с первой цифрой числа x, то получилось число n.
//По заданному n найти число x (значение n вводится с клавиатуры, 1 ≤ n ≤ 999).

Console.WriteLine("Введите трёхзначное число");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 999)
{
    Console.WriteLine("Введите другое число");
    n = Convert.ToInt32(Console.ReadLine());
}
int x = (n % 10) * 100 + n / 10;
Console.WriteLine(x);











