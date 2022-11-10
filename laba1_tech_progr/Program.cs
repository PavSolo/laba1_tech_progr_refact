using System;

namespace laba1_tech_progr
{
    //класс, реализующий меню при запуске приложения
    class Menu_First
    {
        public bool menu_choose;
        public  Menu_First(bool menu)
        {
            this.menu_choose = menu;
        }
         public void Menu_1()
        {
            if (menu_choose == false)
                System.Environment.Exit(1);
             

        }

        
    }
    //класс, реализующий запись заявки
    class Write_Record
    {
        public string surname;
        public string name;
        public string patronymic;
        public string brand;
        public string kindofwork;
        public  int price;

        public Write_Record(string surname, string name, string patronymic, string brand, string kindofwork, int price)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.brand = brand;
            this.kindofwork = kindofwork;
            this.price = price;
        }

        
        

    }
    //класс меню, которое вызывается после записи заявки
    class Menu_Second: Menu_First
    {
        public bool menu_sec_choose;

        public Menu_Second( bool menu_sec_choose, bool menuu = false) : base(menuu)
        {
            this.menu_sec_choose = menu_sec_choose;
        }
        public void Menu_1()
        {
            if(menu_sec_choose==false)
                System.Environment.Exit(1);

        }


    }
        //класс, реализирующий вывод квитанции
    class Print_Ticket : Write_Record
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
        //метод класса, выводящий квитанцию
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
            bool menuu = true, print_record = true;
            Console.WriteLine("Для того, чтобы сделать запись, введите 1, для закрытия программы введите 0");
            menu_choose = Convert.ToInt32(Console.ReadLine());
            if (menu_choose == 0)
                menuu = false;
            Menu_First menu1 = new Menu_First(menuu);
            menu1.Menu_1();
            //функция для записи информация клиента
            Write_Customer_Info(out Surname, out Name, out Patronymic, out Kindofwork, out Brand, out Price);
            Write_Record rec1 = new Write_Record(Surname, Name, Patronymic, Brand, Kindofwork, Price);
            Console.WriteLine("Для того, чтобы вывести квитанцию, введите 1, для закрытия программы введите 0");
            menu_choose1 = Convert.ToInt32(Console.ReadLine());
            if (menu_choose1 == 0)
                print_record = false;
            Menu_Second menu2 = new Menu_Second(print_record);
            menu2.Menu_1();
            Print_Ticket print = new Print_Ticket(Surname, Name, Patronymic, Brand, Kindofwork, Price);
            print.Print();
        }

        private static void Write_Customer_Info(out string Surname, out string Name, out string Patronymic, out string Kindofwork, out string Brand, out int Price)
        {
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
        }
    }
}
