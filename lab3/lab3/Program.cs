using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{

    class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone();// new содает объект указанного класса
            int a = 2;
            a = 3;
            phone1.Id = 4;
            int num = 100;
            int num_1 = -100;
            int num_2;
            Console.WriteLine(phone1.raschet_balanca(ref num,out num_2));
            Console.WriteLine(phone1.raschet_balanca(ref num_1,out num_2));

            Phone[] phone2_arr = new Phone[3];
            phone2_arr[0] = new Phone("Кирилл", "Почта", "Ул.Пономаренко", 31231231, 30, 20, +375, 0);
            phone2_arr[1] = new Phone("Вася", "Мурен", "Ул.Василькова", 2991561, 20, 10, +375, 1);
            phone2_arr[2] = new Phone("Макс", "Пупсин", "Ул.Васькипа", 31231, 5, 20, +375, 0);


           
            
       
            for (int i=0;i<phone2_arr.Length;i++)
            {

                if (phone2_arr[i].international_communication == 0)
                    Console.WriteLine("user uses international_communication");
                if (phone2_arr[i].international_communication == 1)
                    Console.WriteLine("user does not uses international_communication");
            } 


          
            for(int i = 0;i<phone2_arr.Length;i++)
            {
                phone2_arr[i].Name = "polsovatel "+i;
                phone2_arr[i].time_of_citys_talks= i ;
            }




            Console.WriteLine("у этих пользователей нет проблем");
            for (int i = 0; i < phone2_arr.Length; i++)
            {
                if(phone2_arr[i].time_of_citys_talks>1 && phone2_arr[i].time_of_citys_talks<4)
                {
                    Console.WriteLine(phone2_arr[i].Name);
                }

            }
            Phone.info_of_object();
        }
    }
}
