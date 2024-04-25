using System;
using static System.Console;
                                                                       ///Вторая практика
namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Первое задание(2 варианта форматированого вывода)
            //Обозначение переменных и их значений
            string fullName, email;
            int age;
            double pointsProg, pointsMath, pointsPhys;
            fullName = "Замятин Илья Сергеевич";
            email = "zxzmarikzxz@gmail.com";
            age = 21;
            pointsProg = 99.5;
            pointsMath = 66;
            pointsPhys = 78.3;
            string example = "5";
            int example2 = int.Parse(example);//Пример преобразования данных(В задании не было решил попробовать для себя)
            int notask = Convert.ToInt32(pointsMath);//Тоже самое что и выше
            //Первый вариант вывода
            WriteLine($"ФИО:{fullName} Возраст: {age} Электронная почта {email}");
            WriteLine($"Баллы по программированию {pointsProg}");
            WriteLine($"Баллы по математике {pointsMath}");
            WriteLine($"Баллы по физике {pointsPhys}");
            //Второй вариант вывода
            WriteLine("ФИО: {0} Возраст {1} Электронная почта: {2} \nБаллы по программированию:{3} \nБаллы по математике: {4} \nБаллы по физике {5}", 
                fullName,
                email,
                age,
                pointsProg,
                pointsMath,
                pointsPhys
                );
            //Второе задание
            double sum = pointsProg + pointsMath + pointsPhys;
            double average = sum / 3;
            WriteLine($"Сумма всех баллов {sum}");
            WriteLine($"Среднее арифмитическое {average.ToString("#.##")}");//Сокращение среднего арифмитического до 2 знаков после запятой
            WriteLine($"Попытка вывода преобразованных данных: {example2} {notask}");
            ReadKey();
        }
    }
}
