//A3.9. В трехзначном числе x зачеркнули его последнюю цифру.
//Когда в оставшемся двузначном числе переставили цифры,
//а затем приписали к ним слева последнюю цифру числа x,
//то получилось число 654. Найти число x.


Console.WriteLine("Ответ: {0}", a % 10 * 100 + a % 100 / 10 * 10 + a / 100);
Console.WriteLine();