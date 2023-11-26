// Напишите программу,которая на ввод принимает одно число (N),
// а на вывод показывает все целые числа в промежутке от -N до N.
// 4 -> "-4;-3;-2;-1;0;1;2;3;4"
// 2 -> "-2;-1;0;1;2"

 System.Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

if(N  > 0)
{
    int i = -N;
    while (i <= N)
    {
        System.Console.WriteLine(i +"");
        i++;   //  i = i + 1; i += 1
    } 
}
else
{
    System.Console.WriteLine("Введено не коректное значение!");
}

