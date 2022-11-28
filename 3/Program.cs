/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/


void FindPolindrom (int number)
{
        int firstNum = number / 10000;
        int ostNum = number % 10;
        if (firstNum == ostNum)
        {
            number = number / 10;
            int secondNum = number / 100;
            int ostNum2 = number % 10;
               if (secondNum == ostNum2)
               {
                Console.WriteLine ("Палиндрром"); 
               }   
        }
        else 
        {
         Console.WriteLine ("не палиндром");   
        }
    }
//FindPolindrom(12521);

Console.Write ("Введите пятизначное число : ");
int number = Convert.ToInt32(Console.ReadLine());
FindPolindrom(number);
