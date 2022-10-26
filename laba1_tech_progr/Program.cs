using System;

namespace laba1_tech_progr
{
    class Menu
    {
        public bool menuu;
        public  Menu(bool menuu)
        {
            this.menuu = menuu;
        }
         public void Menu_1()
        {
            if (menuu == false)
                System.Environment.Exit(1);
             

        }

        
    }
    class Record
    {
        public string surname;
        public string name;
        public string patronymic;
        public string brand;
        public string kindofwork;
        public  int price;

        public Record(string surname, string name, string patronymic, string brand, string kindofwork, int price)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.brand = brand;
            this.kindofwork = kindofwork;
            this.price = price;
        }

        
        

    }
    class Menu1: Menu
    {
        public bool print_record;

        public Menu1( bool print_record, bool menuu = false) : base(menuu)
        {
            this.print_record = print_record;
        }
        public void Menu_1()
        {
            if(print_record==false)
                System.Environment.Exit(1);

        }


    }

    class Print_Ticket : Record
    {
        public Print_Ticket(string surname, string name, string patronymic, string brand, string kindofwork, int price) : base(surname, name, patronymic, brand, kindofwork, price)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.brand = brand;
            this.kindofwork = kindofwork;
            this.price = price;
        }

        public void Print()
        {
            Console.WriteLine("КВИТАНЦИЯ");
            Console.WriteLine($"Фамилия: {surname}");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Отчество: {patronymic}");
            Console.WriteLine($"Вид работы: {kindofwork}");
            Console.WriteLine($"Стоимость работ: {price}");
            Console.WriteLine($"Дата: {DateTime.Today}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string Surname, Name, Patronymic, Kindofwork, Brand;
            int Price, menu_choose, menu_choose1;
            bool menuu=true, print_record=true;
            Console.WriteLine("Для того, чтобы сделать запись, введите 1, для закрытия программы введите 0");
            menu_choose= Convert.ToInt32 (Console.ReadLine());
            if (menu_choose == 0)
                menuu = false;

             
            Menu menu1 = new Menu(menuu);
            menu1.Menu_1();
            Console.WriteLine("Фамилия ");
            Surname = Console.ReadLine();
            Console.WriteLine("Имя ");
            Name = Console.ReadLine();
            Console.WriteLine("Отчество ");
            Patronymic = Console.ReadLine();
            Console.WriteLine("Марка ");
            Brand = Console.ReadLine();
            Console.WriteLine("Вид работы ");
            Kindofwork = Console.ReadLine();
            Console.WriteLine("Стоимость");
            Price = Convert.ToInt32(Console.ReadLine());
            Record rec1 = new Record(Surname, Name, Patronymic, Brand, Kindofwork, Price);
            Console.WriteLine("Для того, чтобы вывести квитанцию, введите 1, для закрытия программы введите 0");
            menu_choose1 = Convert.ToInt32(Console.ReadLine());
            if (menu_choose1 == 0)
                print_record = false;
            Menu1 menu2 = new Menu1(print_record);
            menu2.Menu_1();

            Print_Ticket print =  new Print_Ticket(Surname, Name, Patronymic, Brand, Kindofwork, Price);
            print.Print();
        }
    }
}
