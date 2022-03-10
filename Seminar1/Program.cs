/*
//1 задача:
Console.Write("Введите целое число: ");
int value = Convert.ToInt32(Console.ReadLine());
int kvadrat_value = value * value;
Console.WriteLine("Квадрат данного числа равен");
Console.WriteLine(kvadrat_value);


//2 задача:

Console.Write("Введите первое целое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int value2 = Convert.ToInt32(Console.ReadLine());

int kvadrat_value2 = value2 * value2;

if(kvadrat_value2 == value1)
{
    Console.WriteLine("Квадрат второго числа соответсвует первому");
    
}
else
{
    Console.WriteLine("Искомых соответсвий не выявлено");
}



//3 задача

    Console.WriteLine("Введите номер дня недели: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if(number <= 7 && number >= 1)
    {
      if(number == 1)
      {
          Console.WriteLine("Понедельник");

      if(number == 2)   
      {
            Console.WriteLine("Вторник");
      }
      }
    }
    else
    {
        Console.WriteLine("Такого дня недели не существует");
    }

    
    //4 Задача

    Console.WriteLine("Введите натуральное число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int neg_n = n*(-1);

    while(neg_n <= n)
    {
        Console.WriteLine(neg_n);
        neg_n+=3;
    }    
    

    //5 домашняя задание

    Console.WriteLine("Введите первое целое число");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе целое число");
    int b = Convert.ToInt32(Console.ReadLine());
    
    if(a > b)
    {
        Console.WriteLine("Число {a} больше чем {b}");
    }
    else if(a == b)
    {
        Console.WriteLine("Число {a} и {b} равны");
    }
    else
    {
        Console.WriteLine("Число {b} больше чем {a}");
    }
    


    //6 домашнее задание

    Console.WriteLine("Введите первое число");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int b= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число");
    int c = Convert.ToInt32(Console.ReadLine());
    
    if (a >= b && a >= c)
    {
        Console.WriteLine("Максимальное число {a}");
    }
    if (b >= a && b >= c)
    {
        Console.WriteLine("Максимальное число {b}");
    }
    if (c >= a && c >= b)
    {
        Console.WriteLine("Максимальное число{c}");
    }
    */