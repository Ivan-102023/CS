// Напишите программу, которачя будет выдавать название дня недели по заданному номеру.
// 3 -> Среда;
// 5 -> Пятница;

//  Первый вариант решения

// System.Console.WriteLine("Введите номер дня недели ");
// int day = Convert.ToInt32(Console.ReadLine());
// if(day == 1) {
//     System.Console.WriteLine("Пн");
// }
// else if(day == 2) {
//     System.Console.WriteLine("Вт");
// }
// else if(day == 3) {
//     System.Console.WriteLine("Ср");
// }else if(day == 4) {
//     System.Console.WriteLine("Чт");
// }else if(day == 5) {
//     System.Console.WriteLine("Пт");
// }else if(day == 6) {
//     System.Console.WriteLine("Сб");
// }else if(day == 7) {
//     System.Console.WriteLine("Вс");
// }else  {
//     System.Console.WriteLine("Такого дня недели нет");
// }

// Второй вариант решения 
System.Console.WriteLine("Введите номер дня недели ");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
 {
    case 1:
        System.Console.WriteLine("Пн");
        break;
    case 2:
        System.Console.WriteLine("Вт");
        break;
    case 3:
        System.Console.WriteLine("Ср");
        break;
    case 4:
        System.Console.WriteLine("Чт");
        break;
    case 5:
        System.Console.WriteLine("Пт");
        break;
    case 6:
        System.Console.WriteLine("Сб");
        break;
    case 7:
        System.Console.WriteLine("Вс");
        break;
    default:
    System.Console.WriteLine("Такого дня недели нет");
    break;
}