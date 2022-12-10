//Напишите программу, которая проверяет число на полиндром

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num/10000;
int num2 = num/1000 - num1*10;
int num4 = num%10;
int num3 = (num%100 - num4)/10;

if (num1 == num4 && num2 == num3)
{
Console.WriteLine("ok");    
}
else
{
Console.WriteLine("vision"  +num3+ " " +num4);    
}


//Напишите программу, которая принимает координаты точек и находит расстояние между ними
// Console.Write("Введите координату х1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double threeD = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + (Math.Pow(z2 - z1, 2)));
// // // Math.Round(число, количество знаков) 
// Console.WriteLine("Расстояние между точками:" 
// + x1 + "," + y1 + "," + x2 + "," + y2 + "," + z1 + "," + z2 + " = " + Math.Round(threeD,3) ); 


//Напишите программу, которая принимает на вход число и выдаёт ряд кубов числ от 1 до N

// Console.Write("Введите число N:");
// int cube = Convert.ToInt32(Console.ReadLine()); 
// int temp = 1; 

// while (temp <= cube)
// {
//     Console.Write(Math.Pow(temp,3) + " ");
//     temp++;
// }

