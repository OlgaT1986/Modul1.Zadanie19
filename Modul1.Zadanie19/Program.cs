using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie19
{
    class Program
    {
        static void Main(string[] args)
        {
            // группа моделей компьютера
            List<Computer> computers = new List<Computer>() 
            {
                new Computer(){CodeComputer=1, NameComputer="MSI", TypeProcessor="Core i7", FrequencyProcessor=2.9, VolumeOperational=32, VolumeHardDrive=256, VolumeVideoCard=6, CostComputer=150000, QuantityExemplar=11},
                new Computer(){CodeComputer=2, NameComputer="Apple", TypeProcessor="Core i3", FrequencyProcessor=2.6, VolumeOperational=8, VolumeHardDrive=256, VolumeVideoCard=6, CostComputer=70000, QuantityExemplar=30},
                new Computer(){CodeComputer=3, NameComputer="HP", TypeProcessor="Core i7", FrequencyProcessor=2.5, VolumeOperational=16, VolumeHardDrive=512, VolumeVideoCard=4, CostComputer=89000, QuantityExemplar=6},
                new Computer(){CodeComputer=4, NameComputer="ASUS", TypeProcessor="Core i5", FrequencyProcessor=2.6, VolumeOperational=16, VolumeHardDrive=512, VolumeVideoCard=6, CostComputer=130000, QuantityExemplar=13},
                new Computer(){CodeComputer=5, NameComputer="MSI", TypeProcessor="Core i5", FrequencyProcessor=2.5, VolumeOperational=8, VolumeHardDrive=512, VolumeVideoCard=4, CostComputer=90000, QuantityExemplar=80},
                new Computer(){CodeComputer=6, NameComputer="Sony", TypeProcessor="Core i7", FrequencyProcessor=2.9, VolumeOperational=16, VolumeHardDrive=512, VolumeVideoCard=8, CostComputer=110000, QuantityExemplar=5},
                new Computer(){CodeComputer=7, NameComputer="DNS", TypeProcessor="Core i5", FrequencyProcessor=2.3, VolumeOperational=32, VolumeHardDrive=512, VolumeVideoCard=8, CostComputer=140000, QuantityExemplar=12},
                new Computer(){CodeComputer=8, NameComputer="AMD", TypeProcessor="Core i5", FrequencyProcessor=2.9, VolumeOperational=8, VolumeHardDrive=256, VolumeVideoCard=6, CostComputer=65000, QuantityExemplar=10},
            };
            // 1. Определить все компьютеры с указанным процессором. Название процессора запросить у пользователя
            //Console.WriteLine("Введите название процессора-");
            //string typeProcessor = Console.ReadLine();
            //List<Computer> computers1 = computers.Where(x => x.TypeProcessor == typeProcessor).ToList(); // выбор из списка с совпадающим введенным, х-переменная, с типом employ
            //Print(computers1);// вывод результата

            // 2. Определить все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя
            //Console.WriteLine("Введите объем оперативной памяти-");
            //int volumeOperational = Convert.ToInt32(Console.ReadLine());
            //List<Computer> computers2 = computers.Where(x => x.VolumeOperational >= volumeOperational).ToList();
            //Print(computers2);

            // 3. Вывести весь список, отсортированный по увеличению стоимости
            //List<Computer> computers3 = computers.OrderBy(x => x.CostComputer).ToList();
            //Print(computers3);

            // 4. Вывести весь список, сгруппированный по типу процессора
            //IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.TypeProcessor);
            //foreach (IGrouping<string, Computer> gr in computers4) // перебираем
            //{
            //    Console.WriteLine(gr.Key); // выводим список,Key-общий параметр
            //    foreach (Computer e in gr)
            //    {
            //        Console.WriteLine($"\nКод компьютера- {e.CodeComputer} \nМарка компьютера- {e.NameComputer} \nТип процессора- {e.TypeProcessor} \nЧастота процессора в Гц- {e.FrequencyProcessor} \nОбъем оперативной памяти в Мб- {e.VolumeOperational} \nОбъем жесткого диска в Мб- {e.VolumeHardDrive} \nОбъем памяти видеокарты- {e.VolumeVideoCard} \nСтоимость компьютера в руб.: {e.CostComputer} \nКоличество в наличии- {e.QuantityExemplar}");
            //    }
            //}

            // 5. Найти самый дорогой компьютер
            //Computer computers5 = computers.OrderByDescending(x => x.CostComputer).FirstOrDefault(); // сортируем по убыванию и берем самую верхнюю запись
            //Console.WriteLine($"\nКод компьютера- {computers5.CodeComputer} \nМарка компьютера- {computers5.NameComputer} \nТип процессора- {computers5.TypeProcessor} \nЧастота процессора в Гц- {computers5.FrequencyProcessor} \nОбъем оперативной памяти в Мб- {computers5.VolumeOperational} \nОбъем жесткого диска в Мб- {computers5.VolumeHardDrive} \nОбъем памяти видеокарты- {computers5.VolumeVideoCard} \nСтоимость компьютера в руб.- {computers5.CostComputer} \nКоличество в наличии- {computers5.QuantityExemplar}");

            // 6. Найти самый бюджетный компьютер
            //Computer computers5 = computers.OrderBy(x => x.CostComputer).FirstOrDefault(); // сортируем по возрастанию и берем самую верхнюю запись
            //Console.WriteLine($"\nКод компьютера- {computers5.CodeComputer} \nМарка компьютера- {computers5.NameComputer} \nТип процессора- {computers5.TypeProcessor} \nЧастота процессора в Гц- {computers5.FrequencyProcessor} \nОбъем оперативной памяти в Мб- {computers5.VolumeOperational} \nОбъем жесткого диска в Мб- {computers5.VolumeHardDrive} \nОбъем памяти видеокарты- {computers5.VolumeVideoCard} \nСтоимость компьютера в руб.- {computers5.CostComputer} \nКоличество в наличии- {computers5.QuantityExemplar}");

            // 7. есть ли хотя бы один компьютер в количестве не менее 30 штук
            if (computers.Any(x => x.QuantityExemplar > 30))
            {
                Console.WriteLine("В наличии компьютеры в количестве не менее 30 штук");
            }
            else
            {
                Console.WriteLine("Нет в наличии компьютеров в количестве не менее 30 штук");
            }
            Console.ReadKey();
        }
        // метод вывода списка на экран
        static void Print(List<Computer> computers)
        {
            foreach (Computer e in computers)
            {
                Console.WriteLine($"\nКод компьютера- {e.CodeComputer} \nМарка компьютера- {e.NameComputer} \nТип процессора- {e.TypeProcessor} \nЧастота процессора в Гц- {e.FrequencyProcessor} \nОбъем оперативной памяти в Мб- {e.VolumeOperational} \nОбъем жесткого диска в Мб- {e.VolumeHardDrive} \nОбъем памяти видеокарты- {e.VolumeVideoCard} \nСтоимость компьютера в руб.- {e.CostComputer} \nКоличество в наличии- {e.QuantityExemplar}");
            }
            Console.WriteLine();
        }
    }
}

