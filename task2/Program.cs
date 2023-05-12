namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Shop demoShop1 = new Shop("Демонстрационный магазин 1", "Ул. Пушкина, дом колотушкина, квартира 7", 135790, "demoshop@gmail.com", "Продажа воздуха и геля в шариках уникальной формы, размера, цвета.", 10);
                Shop cloneDemoShop1 = new Shop("Демонстрационный магазин 1", "Ул. Пушкина, дом колотушкина, квартира 7", 135790, "demoshop@gmail.com", "Продажа воздуха и геля в шариках уникальной формы, размера, цвета.", 10);
                Console.WriteLine(demoShop1);
                Console.WriteLine(cloneDemoShop1);
                Console.WriteLine("магазин 1 = магазинуклону: {0}", demoShop1 == cloneDemoShop1);
                demoShop1 = (demoShop1 + 2);
                Console.WriteLine(demoShop1);
                Console.WriteLine("магазин 1 = магазинуклону: {0}", demoShop1 == cloneDemoShop1);
                Console.WriteLine("магазин 1 != магазинуклону: {0}", demoShop1 != cloneDemoShop1);
                Console.WriteLine("магазин 1 > магазин-клона: {0}", demoShop1 > cloneDemoShop1);

                Shop sh2 = new Shop("тестовый магазин");
                Console.WriteLine(sh2);
                Console.WriteLine(sh2.GetHashCode());
                Shop sh3 = new Shop("тестовый магазин");
                Console.WriteLine(sh3.Equals(sh2));                 // хотя не все поля инициализированы, но экземпляры класса идентичны
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        internal class Shop
        {
            // uint length;
            public uint? Square { get; set; }
            //{
            //get { return length * length; }
            // set { length = value; }

            // }
            public string Name
            {
                get; private set;
            }
            public string Address
            { get; set; }

            public string? Description
            { get; set; }

            public uint Telephone
            { get; set; }

            public string Email
            { get; set; }
            public Shop()
            {

            }
            public Shop(string name) => Name = name;

            public Shop(string name, string address, uint telephone, string email, string? description, uint? square)
            {
                this.Init(name, address, description, telephone, email, square);
            }

            public void Init(string name, string address, string? description, uint telephone, string email, uint? square)
            {
                Name = name;
                Address = address;
                Description = description;
                Telephone = telephone;
                Email = email;
                Square = square;
            }

            public void Print() => Console.WriteLine("\n\tНазвание магазина: {0}\n\n\tАдрес магазина: {1}\n\n\tОписание профиля магазина: {2}\n\n\tКонтактный телефон: {3}\n\n\tКонтактный e-mail: {4}\n\n\tПлощадь магазина: {5}",
                                                    Name, Address, Description, Telephone, Email, Square);
            public override string ToString()
            {
                return string.Format("***********\n\tНазвание магазина: {0}\n\n\tАдрес магазина: {1}\n\n\tОписание профиля магазина: {2}\n\n\tКонтактный телефон: {3}\n\n\tКонтактный e-mail: {4}\n\n\tПлощадь магазина: {5}",
                                                    Name, Address, Description, Telephone, Email, Square);
            }
            public static Shop operator +(Shop sh1, int number)
            {
                if (sh1 != null)
                {
                    if (sh1.Square + number > 0)
                        return new Shop(sh1.Name, sh1.Address, sh1.Telephone, sh1.Email, sh1.Description, (uint)(sh1.Square + number));
                }
                return sh1;
            }
            public static Shop operator -(Shop sh1, int number)
            {
                if (sh1 != null)
                {
                    if (sh1.Square - number > 0)
                        return new Shop(sh1.Name, sh1.Address, sh1.Telephone, sh1.Email, sh1.Description, (uint)(sh1.Square - number));
                }
                return sh1;
            }

            public static bool operator ==(Shop? sh1, Shop? sh2)
            {
                if (sh1 is null || sh2 is null)
                    return false;
                return sh1.Square == sh2.Square;
            }
            public static bool operator !=(Shop? sh1, Shop? sh2)
            {
                if (sh1 is null && sh2 is null)
                    return true;
                return !(sh1 == sh2);

            }

            public static bool operator >(Shop? sh1, Shop? sh2)
            {
                if (sh1 is null || sh2 is null)
                {
                    Console.Write("один из сравниваемых объектов не инициализирован.");
                    return false;
                }
                return sh1.Square > sh2.Square;

            }

            public static bool operator <(Shop? sh1, Shop? sh2)
            {
                if (sh1 is null || sh2 is null)
                {
                    Console.Write("один из сравниваемых объектов не инициализирован.");
                    return false;
                }
                return sh1.Square < sh2.Square;

            }

            public override bool Equals(object? obj)
            {

                if (obj is Shop && obj is null == false)
                {
                    Shop sh1 = (Shop)obj;
                    return this.Square == sh1.Square && isEqual(this.Name, sh1.Name) && isEqual(this.Email, sh1.Email) && isEqual(this.Address, sh1.Address) && isEqual(this.Description, sh1.Description) && this.Telephone == sh1.Telephone;
                }
                return false;
            }
            public override int GetHashCode()
            {
                int ret = 0;
                if (!string.IsNullOrEmpty(this.Name))
                    ret += Name.GetHashCode();
                if (!string.IsNullOrEmpty(this.Email))
                    ret += Email.GetHashCode();
                if (!string.IsNullOrEmpty(this.Address))
                    ret += Address.GetHashCode();
                if (!string.IsNullOrEmpty(this.Description))
                    ret += Description.GetHashCode();
                return ret + Square.GetHashCode() + Telephone.GetHashCode();
            }
            private bool isEqual(string? a, string? b)
            {
                if (a is null || b is null)
                    return a is null && b is null;

                return a.Equals(b);
            }
        }
    }
}
