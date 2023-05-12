using System.Text;

namespace task3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Book[] recomendedBooks = {
                            new Book("Микола Хвильовий.		", "\"Я (Романтика)\""),
                            new Book("Юрій Яновський		", "\"Майстер корабля\" "),
                            new Book("Юрій Яновський		", "\"Вершники\""),
                            new Book("Валер’ян Підмогильний	", "\"Місто\""),
                            new Book("Остап Вишня			", "\"Моя автобіографія\""),
                            new Book("Остап Вишня			", "\"Сом\""),
                            new Book("Остап Вишня			", "\"Як варити і їсти суп із дикої качки\""),
                            new Book("Микола Куліш			", "\"Мина Мазайло\""),
                            new Book("Осип Турянський		", "\"Поза межами болю\""),
                            new Book("Іван Багряний			", "\"Тигролови\""),
                            new Book("Олександр Довженко	", "\"Україна в огні\""),
                            new Book("Олександр Довженко	", "\"Зачарована Десна\""),
                            new Book("Ліна Костенко			", "\"Модри Камень\""),
                            new Book("Григір Тютюнник		", "\"Три зозулі з поклоном\""),
                            new Book("Ф. Кафка.				", "“Перевтілення“"),
                            new Book("Камю А.				", "\"Чума\""),
                            new Book("Джордж Оруелл			", "\"Скотоферма\" або \"1984\""),
                            new Book("Бертольт Брехт		", "\"Матінка Кураж та її діти\""),
                            new Book("Генріх Белль			", "\"Подорожній, коли ти прийдеш у СПА…”"),
                            new Book("Пауль Целан			", "\"Фуга смерті\""),
                            new Book("Е. Хемінгуей.			", "“Старий і море“"),
                            new Book("Г. Маркес.			", "\"Стариган із крилами“"),
                            new Book("Ясунарі Кавабата		", "\"Тисяча журавлів\""),
                            new Book("Милорад Павич			", "\"Дамаскин\""),
                            new Book("Милорад Павич			", "\"Скляний равлик\""),
                            new Book("Хуліо Кортасар		", "\"Менади\""),
                            new Book("Таїр Халілов			", "\"До останнього подиху\""),
                            new Book("Джон Майкл Ґрін		", "\"Провина зірок\""),
                            new Book("Маркус Френк Зузак	", "\"Крадійка книжок\""),
                            new Book("Айтматов Ч.			", "\"І понад вік триває день\"	"),
                            new Book("Айтматов Ч.			", "\"Плаха\" "),
                            new Book("Апдайк Дж.			", "\"Кролик розбагатів\""),
                            new Book("Барнз Дж.				", "\"Відчуття закінчення\""),
                            new Book("Беккет С.				", "\"Чекаючи на Годо\""),
                            new Book("Борхес Х.				", "\"Дзеркало і маска\""),
                            new Book("Гасклі О.				", "\"Дивний новий світ\""),
                            new Book("Гашек Я				", "\"Пригоди бравого вояка Швейка\""),
                            new Book("Гемінґвей Е.			", "\"Кішка на дощі\""),
                            new Book("Гессе Г.				", "\"Гра в бісер\""),
                            new Book("Гессе Г.				", "\"Степовий вовк\""),
                            new Book("Ділан Боб.			", "Поезії "),
                            new Book("Джойс Дж				", "\"Джакомо Джойс\""),
                            new Book("Джойс Дж				", "\"Дублінці\""),
                            new Book("Дюрренматт Ф.			", "\"Фізики\""),
                            new Book("Дюрренматт Ф.			", "\"Гостина старої дами\""),
                            new Book("Еко У.				", "\"Ім’я троянди\""),
                            new Book("Еліот Т. С.			", "Поезії"),
                            new Book("Елюар П.				", "Поезії "),
                            new Book("Зюскінд П.			", "\"Голуб\""),
                            new Book("Йонеско Е.			", "\"Голомоза співачка\", \"Носороги\" (1 твір за вибором учителя)"),
                            new Book("Ільф І. А., Петров Є. ", "П.\"Дванадцять стільців\""),
                            new Book("Кавабата Я.			", "\"Німий\""),
                            new Book("Кафка Ф.				", "Притчі."),
                            new Book("Кафка Ф.				", "\"Лист до батька\""),
                            new Book("Кіз Д.				", "\"Квіти для Елджернона\""),
                            new Book("Кізі К				", "\"Політ над гніздом зозулі\""),
                            new Book("Кініллі Т.			", "\"Список Шиндлера\""),
                            new Book("Кобо Абе				", "\"Людина-коробка\""),
                            new Book("Кобо Абе				", "\"Жінка в пісках\" "),
                            new Book("Кортасар Х.			", "\"Поза часом\""),
                            new Book("Кундера М.			", "\"Нестерпна легкість буття\""),
                            new Book("Ле Ґуїн У.			", "\"Ті, хто покидають Омелас\""),
                            new Book("Лем С.				", "\"Соляріс\""),
                            new Book("Манн Т.				", "\"Маріо і чарівник\""),
                            new Book("Маркес Ґ.				", "\"Сто років самотності\""),
                            new Book("Муракамі Х.			", "\"Хроніка заводного птаха\""),
                            new Book("Муракамі Х.			", "\"Норвезький ліс\""),
                            new Book("Муракамі Х.			", "\"1Q84\""),
                            new Book("Муракамі Х.			", "\"Підземка\" "),
                            new Book("Павич М.				", "\"Хозарський словник\""),
                            new Book("Павич М.				", "\"Зоряна мантія\""),
                            new Book("Павич М.				", "\"Дамаскин\""),
                            new Book("Памук О.				", "\"Мене називають Червоний\""),
                            new Book("Райнсмар К.			", "\"Останній світ\""),
                            new Book("Саган Ф.				", "\"Привіт, смутку\""),
                            new Book("Саган Ф.				", "\"Трохи сонця в холодній воді\""),
                            new Book("Фаулз Дж.				", "\"Маг\" (\"Волхв\")"),
                            new Book("Фаулз Дж.				", "\"Хмара\""),
                            new Book("Фріш М.				", "\"Андорра\""),
                            new Book("Фріш М.				", "\"Біографія\""),
                            new Book("Фріш М.				", "\"Санта-Крус\""),
                            new Book("Хайнлайн Р.			", "Фантастичні твори"),
                            new Book("Чапек К.				", "\"Війна з саламандрами\"")};

            BookList blist = new BookList(recomendedBooks);


            //blist.Print();
            //blist.AddBook(new Book("author6", "name6", 1234));
            //blist.Print();
            // blist.RemoveBook(0);
            // blist.Print();
            //int count = 5;
            // while(count > 0)
            // {
            //     // Console.WriteLine("Введите индекс книги:");
            //     // int ind = Convert.ToInt32(Console.ReadLine());
            //     // Console.WriteLine(blist[ind]);
            //     Console.WriteLine("Введите название/автора книги:");
            //     string str;
            //     str =Console.ReadLine();
            //     str.Trim();
            //     Console.WriteLine(blist[str]);
            //     --count;
            // }
            while (true)
            {
                Console.Clear();
                PrintMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                Book? b = null;
                switch (choice)
                {
                    case 1:
                        blist.Print();
                        break;
                    case 2:
                        Console.WriteLine("Введите имя автора: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите название книги: ");
                        string title = Console.ReadLine();
                        Book tempB = new Book(name, title);
                        blist.AddBook(tempB);
                        break;
                    case 3:
                        Console.WriteLine("Введите индекс книги: ");
                        int ind = Convert.ToInt32(Console.ReadLine());
                        blist.RemoveBook(ind);
                        break;
                    case 4:
                        Console.WriteLine("Введите индекс книги: ");
                        int ind1 = Convert.ToInt32(Console.ReadLine());
                        b = blist.FindBook(ind1);
                        if (b != null)
                            Console.WriteLine(b);
                        else
                            Console.WriteLine("такая книга в списке отсутствует.");
                        break;
                    case 5:
                        Console.WriteLine("Введите ключевое слово для поиска книги: ");
                        string tempStr = Console.ReadLine();
                        b = blist.FindBook(tempStr);
                        if (b != null)
                            Console.WriteLine(b);
                        else
                            Console.WriteLine("такая книга в списке отсутствует.");
                        break;
                    case 6:
                    default:
                        return;
                }
                Console.ReadLine();
            }


        }
        static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Распечатать список книг");
            Console.WriteLine("2. Добавить книгу");
            Console.WriteLine("3. Удалить книгу");
            Console.WriteLine("4. Найти книгу по индексу");
            Console.WriteLine("5. Найти книгу по ключевому слову");
            Console.WriteLine("6. Выход");
        }
    }



    internal class BookList
    {
        int length;
        public int Length
        {
            get
            {
                return length;
            }
            private set
            {
                length = value;
            }
        }
        int size;
        public int Size
        {
            get { return size; }
            private set { size = value; }
        }

        Book[] list;

        /*
        public BookList(int length) 
        { 
            this.length = length;
            this.size = length + 10;
            list = new Book[size];
            for(int i = 0; i < length; i++) 
                list[i] = new Book();     
        }
        */

        public BookList(Book[] list)
        {
            this.size = list.Length + 10;
            length = list.Length;
            this.list = new Book[size];
            for (int i = 0; i < length; i++)
            {
                this.list[i] = list[i];
            }
        }

        public bool AddBook(Book? b)
        {
            if (b is null)
                return false;
            EnlargeList();

            list[length] = b;
            length++;
            return true;
        }

        public Book? RemoveBook(int ind)
        {
            if (--ind >= 0)
            {
                Book temp = list[ind];
                for (int i = ind; i < length - 1; i++)
                {
                    list[i] = list[i + 1];
                    //list[i].BookIndex = list[i].BookIndex - 1;
                    --list[i].BookIndex;
                }
                list[length - 1] = null;
                --length;
                return temp;
            }
            return null;

        }

        public Book? this[string str]
        {
            get
            {
                str = str.Trim().ToUpper();
                for (int i = 0; i < length; i++)
                {
                    if (list[i].Title.ToUpper().IndexOf(str) != -1 || list[i].AuthorName.ToUpper().IndexOf(str) != -1)
                        return list[i];
                }
                return null;
            }
            private set
            {
                ;
            }
        }

        public Book? this[int ind]
        {
            get
            {
                if (ind >= 0 && ind < length)
                    return list[ind];
                return null;
            }
            private set
            {
                ;
            }
        }
        private void EnlargeList()
        {
            if (IsListFull())
            {
                size = length + 10;
                Book[] temp = new Book[size];
                for (int i = 0; i < length; i++)
                {
                    temp[i] = list[i];
                }
                list = temp;
            }
        }

        public Book? FindBook(string str)
        {
            return this[str];
        }

        public Book? FindBook(int ind)
        {
            return this[ind];
        }

        private bool IsListFull()
        {
            return length == size;
        }
        public void Print()
        {
            foreach (Book book in list)
            {
                Console.WriteLine(book);
            }
        }
    }


    internal class Book
    {
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public long BookIndex { get; set; }

        public static long index { get; set; }


        static Book()
        {
            index = 1;
        }
        public Book()
        {
            AuthorName = string.Empty;
            Title = string.Empty;
            BookIndex = 0;
        }
        public Book(string authorName, string title)
        {
            this.AuthorName = authorName;
            Title = title;
            this.BookIndex = Book.index++;
        }

        public override string ToString()
        {
            return string.Format("\n{0}.\tАвтор: {1}\n\tНазвание: {2}", BookIndex, AuthorName, Title);
        }


    }
}