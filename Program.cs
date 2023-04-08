// ЗАДАЧА 2: КАКОЕ ИЗ 2х ЧИСЕЛ БОЛЬШЕ

// Console.Clear();
// Console.WriteLine("Please enter first number: ");
// int firstnumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please enter second number: ");
// int secondnumber = Convert.ToInt32(Console.ReadLine());

// if(firstnumber > secondnumber)
// {
//     Console.WriteLine("First number is bigger");
//     Console.WriteLine(firstnumber);
// }
// else if(secondnumber > firstnumber)
// {
//     Console.WriteLine("Second number is bigger");
//     Console.WriteLine(secondnumber);
// }
// else
// {
//     Console.WriteLine("The numbers are even");
// }

// ЗАДАЧА 4:  МАКСИМАЛЬНОЕ ИЗ 3 ЧИСЕЛ

// Console.Clear();
// Console.WriteLine("Please enter first number: ");
// int firstnumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please enter second number: ");
// int secondnumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please enter third number: ");
// int thirdnumber = Convert.ToInt32(Console.ReadLine());

// int max = firstnumber;

// if(secondnumber > max)
// {
//     max = secondnumber;
// }
// if(thirdnumber > max)
// {
//     max = thirdnumber;
// }

// Console.WriteLine("Maximum = "+ max);

// ЗАДАЧА 6: ЯВЛЯЕТСЯ ЛИ ЧИСЛО ЧЁТНЫМ.

// Console.Clear();
// Console.WriteLine("Please enter number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number % 2 == 0)
// {
//     Console.WriteLine("The number is even");
// }
// else
// {
//     Console.WriteLine("The number is odd");
// }

// ЗАДАЧА 8: ПОКАЗАТЬ ВСЕ ЧЁТНЫЕ ДО ЧИСЛA N

 Console.Clear();
Console.WriteLine("Please enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 2;
while(i <= number)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
        i+=2;
    }
    else
    {
        i++;
    }
}