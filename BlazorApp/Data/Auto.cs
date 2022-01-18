using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class Auto
    {
        public string Name { get; set; }
        public string Release { get; set; }
        public int Price { get; set; }

        public static List<string> titles = new List<string>() { "Марка", "Дата выпуска", "Цена" };

        public Auto(string name, string releaes, int price)
        {
            Name = name;
            Release = releaes;
            Price = price;
        }

        public static List<Auto> GetAutoInfo()
        {
            List<Auto> auto = new List<Auto>();
            auto.Add(new Auto("M", "25.05.2009", 4500000));
            auto.Add(new Auto("L", "03.04.2005", 3500000));
            auto.Add(new Auto("P", "05.11.2006", 5000000));
            auto.Add(new Auto("T", "01.05.2001", 3350000));
            auto.Add(new Auto("Maz", "10.10.2003", 3750000));
            return auto;
        }
    }
}
