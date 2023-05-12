using System.Text;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            try
            {
                Magazine mag = new Magazine("Burda", 1950);
                mag.CountEmployee = 3;
                Console.WriteLine(mag);
                mag = mag + 2;
                Console.WriteLine(mag);
                mag = mag - 2;
                Console.WriteLine(mag);
                Magazine mag1 = new Magazine("Burda", 1950);
                mag1.CountEmployee = 3;
                Console.WriteLine("Демонстрация метода магазин1.Equals(магазин2): {0}", mag1.Equals(mag));
                Console.WriteLine("Хэш-код магазина 1: {0}", mag.GetHashCode());
                Console.WriteLine("Хэш-код магазина 1: {0}", mag1.GetHashCode());
                mag1 = mag - 1;
                Console.WriteLine(mag.GetHashCode() == mag1.GetHashCode());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }
    }

    internal class Magazine
    {
        uint countEmployee;
        public uint CountEmployee
        {
            get { return countEmployee; }
            set
            {
                if (value >= 0)
                    countEmployee = value;
            }
        }
        public string Name
        {
            get; private set;
        }
        public ushort Year
        { get; private set; }

        public string Description
        { get; set; }

        public uint Telephone
        { get; set; }

        public string Email
        { get; set; }

        public Magazine(string name, ushort year)
        {
            Name = name;
            Year = year;
        }
        public Magazine(string name, ushort year, uint telephone, string email, string description = "Описание отсутствует.")
        {
            this.Init(name, year, description, telephone, email);
        }

        public void Init(string name, ushort year, string description, uint telephone, string email)
        {
            Name = name;
            Year = year;
            Description = description;
            Telephone = telephone;
            Email = email;
        }

        public void Print() => Console.WriteLine("\n********\n\tНазвание журнала: {0}\n\n\tГод основания: {1}\n\n\tОписание журнала: {2}\n\n\tКонтактный телефон: {3}\n\n\tКонтактный e-mail: {4} \n\n\tКоличество работников: {5}",
                                                Name, Year, Description, Telephone, Email, CountEmployee);
        public override string ToString()
        {
            return String.Format("\n********\n\tНазвание журнала: {0}\n\n\tГод основания: {1}\n\n\tОписание журнала: {2}\n\n\tКонтактный телефон: {3}\n\n\tКонтактный e-mail: {4}\n\n\tКоличество работников: {5}",
                                                Name, Year, Description, Telephone, Email, CountEmployee);
        }
        public static Magazine operator +(Magazine mag, int number)
        {
            if (mag.CountEmployee + number >= 0)
            {
                Magazine ret = new Magazine(mag.Name, mag.Year, mag.Telephone, mag.Email, mag.Description);
                ret.countEmployee = (uint)(mag.CountEmployee + number);
                return ret;
            }
            throw new ArgumentException("не удалось прибавить " + number);
        }

        public static Magazine operator -(Magazine mag, int number)
        {
            if (mag.CountEmployee - number >= 0)
            {
                Magazine ret = new Magazine(mag.Name, mag.Year, mag.Telephone, mag.Email, mag.Description);
                ret.countEmployee = (uint)(mag.CountEmployee - number);
                return ret;
            }
            throw new ArgumentException("не удалось отнять " + number);
        }

        public static bool operator ==(Magazine mag1, Magazine mag2)
        {
            return mag1.CountEmployee == mag2.CountEmployee;
        }

        public static bool operator !=(Magazine mag1, Magazine mag2)
        {
            return !mag1.Equals(mag2);
        }
        public static bool operator >(Magazine mag1, Magazine mag2)
        {
            return mag1.CountEmployee > mag2.CountEmployee;
        }
        public static bool operator <(Magazine mag1, Magazine mag2)
        {
            return mag1.CountEmployee < mag2.CountEmployee;
        }

        public override int GetHashCode()
        {
            int hash = 0;
            if (!string.IsNullOrEmpty(Name))
                hash += Name.GetHashCode();
            if (!string.IsNullOrEmpty(Email))
                hash += Email.GetHashCode();
            if (!string.IsNullOrEmpty(Description))
                hash += Description.GetHashCode();
            return HashCode.Combine(Year, Telephone, countEmployee);
           // return hash + Year.GetHashCode() + Telephone.GetHashCode() + countEmployee.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Magazine && obj != null)
            {
                Magazine m = (Magazine)obj;
                return isEqual(this.Name, m.Name) && isEqual(this.Email, m.Email) && this.CountEmployee == m.CountEmployee && isEqual(this.Description, m.Description) && this.Year == m.Year && this.Telephone == m.Telephone;

            }
            return false;
        }
        private bool isEqual(string? a, string? b)
        {
            if (a is null || b is null)
                return a is null && b is null;

            return a.Equals(b);
        }
    }
}