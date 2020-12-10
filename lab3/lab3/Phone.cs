using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
     partial class Phone
    {

        public int raschet_balanca(ref int add,out int num_2)
        {
            
            num_2 = add+balance;

            return num_2;
        }
    }
    partial class  Phone
    {
        
        int id;
        private string name;
        public string Lname;
        public string adres;
        public int number_of_card;
        public int time_of_citys_talks;
        public int balance;
        public const int pref_number= +375;
        public readonly  int year=2020;
        public static int numbers_of_object=0;
        public int international_communication;
        public int a;

        public int privet = 2;

        public static  void info_of_object()
        {
            Console.WriteLine("Количество объектов " + numbers_of_object);
        }

        public override bool Equals(object obj)
        {
            return obj is Phone phone &&
                   a == phone.a;
        }

        public override int GetHashCode()
        {
            return -1757793268 + a.GetHashCode();
        }

        public Phone()
        {
            name = "no";
            Lname = "no";
            adres = "no";
            time_of_citys_talks = 0;
            number_of_card = 0;
            balance = 0;
            international_communication=-1;
            numbers_of_object++;
        }
        public Phone(int balance=2)
        {
            numbers_of_object++;
        }

        public Phone(string name,string Lname,string adres,int number_of_card,int time_of_citys_talks,int balance,int pref_number,int international_communication)
        {
            this.name = name;
            this.Lname = Lname;
            this.adres = adres;
            this.number_of_card = number_of_card;
            this.time_of_citys_talks = time_of_citys_talks;
            this.balance = balance;
            pref_number = +375;
            this.international_communication = international_communication;
            numbers_of_object++;
        }
        static Phone()
        {
            Console.WriteLine("добавлен новый пользователь");
        }
        
        public string LNAME
        {
            get { return this.Lname; }
            set { this.Lname = value; }
        }
        public string ADRES
        {
            get { return this.adres; }
            set { this.adres = value; }
        }
        public int Number_of_card
        {
            get { return this.number_of_card; }
            set { this.number_of_card = value; }
        }
        public int Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
       

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get//проверка безопастности 
            {
                return id;
            }
            set
            {
                if (Convert.ToBoolean(value)) { id = value; }
            }
        }

    }
}
