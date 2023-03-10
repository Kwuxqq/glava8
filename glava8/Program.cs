using System;
using System.Collections.Generic;
using System.Text;

namespace pr1
{
    struct NOTE
    {
        public string surname_name;
        public int phone_number;
        public int[] birthday;

        public NOTE(string surname_name, int phone_number, int[] birthday)
        {
            this.surname_name = surname_name;
            this.phone_number = phone_number;
            this.birthday = birthday;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            NOTE[] note = new NOTE[3];

            int[] birthday = new int[3];

            for (int i = 0; i <= 2; ++i)
            {
                Console.Write("Введите ФАМИЛИЮ и ИМЯ: ");
                note[i].surname_name = Console.ReadLine();
                Console.Write("Введите ТЕЛЕФОН: ");
                note[i].phone_number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите ДАТУ РОЖДЕНИЯ(ДД/ММ/ГГГГ): ");

                for (int z = 0; z <= 2; z++)
                {
                    birthday[z] = Convert.ToInt32(Console.ReadLine());
                }

            }

            for (int j = 0; j <= 2; ++j)
            {
                Console.WriteLine("{0}\t{1}\t{2}.{3}.{4}", note[j].surname_name, note[j].phone_number, birthday[j], birthday[j], birthday[j]);
            }

            Console.ReadLine();
        }
    }
}