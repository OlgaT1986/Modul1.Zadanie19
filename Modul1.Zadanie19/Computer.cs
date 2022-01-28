using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie19
{
    class Computer
    {
        //код компьютера
        public int CodeComputer { get; set; }
        //марка компьютера
        public string NameComputer { get; set; }
        //тип процессора
        public string TypeProcessor { get; set; }
        // частота процессора
        public double FrequencyProcessor { get; set; }
        // объем оперативной памяти
        public int VolumeOperational { get; set; }
        // объем жесткого диска
        public int VolumeHardDrive { get; set; }
        // объем памяти видеокарты
        public int VolumeVideoCard { get; set; }
        // стоимость компьютера
        public int CostComputer { get; set; }
        // количество в наличии
        public int QuantityExemplar { get; set; }  
    }
}

