// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// bool polindrom (int num)
// {
//     int PervoeChislo = num / 10000;

//     int PredVtoroeChislo = num / 1000;
//     int VtoroeChislo = PredVtoroeChislo % 10;

//     int PredChetvertoeChislo = num % 100;
//     int ChetvertoeChislo = PredChetvertoeChislo / 10;

//     int PyatoeChislo = num % 10;

//     if(PervoeChislo == PyatoeChislo && VtoroeChislo == ChetvertoeChislo)
//     {
//         return true;
//     }
//     return false;
// }

// Console.WriteLine("Vvedite 5znachChislo = ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 10000 || num >= 100000)
// {
//      Console.WriteLine("Vi vveli ne 5znachnoe chislo, pzhl povtorite vvod");
//      return;
// }

// bool result = polindrom(num);

// Console.WriteLine($"{num} -> {result}");


// ```````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance (double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(zb-za, 2)),2);
// }

// Console.WriteLine("input coord x to a:");
// double xa = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coord y to a:");
// double ya = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coord z to a:");
// double za = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coord x to b:");
// double xb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coord y to b:");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coord z to b:");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between point A with coordinates ({xa},{ya},{za}) and point B with coordinates ({xb}, {yb},{zb}) -> {FindDistance(xa, ya, za, xb, yb, zb)}");


// ```````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// int userInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// void QubN(int n)
// {
//     int count=1;
//     while(count<=n)
//     {
//         Console.WriteLine ($"{count} -> {count*count*count}");
//         count++;
//     }
// }

// int n = userInput("input qub");
// QubN(n);


















