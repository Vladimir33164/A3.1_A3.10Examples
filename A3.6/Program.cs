//A3.6. В трехзначном числе x зачеркнули его вторую цифру.
//Когда к образованному при этом двузначному числу слева приписали вторую цифру числа x,
//то получилось число n. По заданному n найти число x (значение n вводится с клавиатуры,
//10 ≤ n ≤ 999 и при этом число десятков в n не равно нулю).

const int Hun = 100, Ten = 10;
int n6 = Convert.ToInt32(Console.ReadLine()), x6 = 0;
if ((n6 >= 10) && (n6 <= 999) && (n6 % 100 / 10 != 0))
{
   int firstNumeral = n6 / Hun, lastNumer = n6 % Ten, secondNum = n6 / Ten % Ten;
   x6 = secondNum * Hun + firstNumeral * Ten + lastNumer;
}
Console.WriteLine(x6);







