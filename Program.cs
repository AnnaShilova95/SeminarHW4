/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
//Задаем метод, считающий число a в степени b

void Stepen(int a, int b){
     int result=1;
     for (int curr = 1; curr <= b; curr++){
         result *= a;
     }
     Console.WriteLine($"Число {a} в степени {b} = {result}");
     }

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Stepen (a,b);



//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//Цикл for без счетчика и итератора, в котором выполняются вычисления, пока 
int SumNumber(int num){
  int result = 0;

    for (; num > 0; ){
      result= result + num %10; //Выбираем последнюю цифру и плюсуем ее к результату 
      num = num/10; //Выкидываем последнюю цифру из числа и идем обратно в цикл, пока при делении без остатка не получим 0
    }
    return result; 
  }

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);


*/
//Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.

int[] myNum = new int[8]; //Создание массива
for (int i = 0; i < myNum.Length; i++) //Заполнение
    {
    Console.Write("Введите одну цифру [" + i + "]:\t");
    myNum [i]  = int.Parse(Console.ReadLine());
    }
for (int i = 0; i < myNum.Length; i++) //И вывод на экран
    {
    Console.Write(myNum[i] + "");
    }


