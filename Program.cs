using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_4
{
    class Program
    {
        /// <summary>
        /// Общий интерфейс
        /// </summary>
        public interface IDB
        {
            /// <summary>
            /// Создает БД
            /// </summary>
            void Create_DB();
            /// <summary>
            /// Добавляет таблицу
            /// </summary>
            void Add_table();
            /// <summary>
            /// Добавляет представление
            /// </summary>
            void Add_view();
            /// <summary>
            /// Добавляет синоним
            /// </summary>
            void Add_synonym();
            /// <summary>
            /// Добавляет процедуру
            /// </summary>
            void Add_procedure();
            /// <summary>
            /// Изменяет таблицу
            /// </summary>
            void Alter_table();
            /// <summary>
            /// Удаляет таблицу
            /// </summary>
            void Delete_table();
            /// <summary>
            /// Удаляет представление
            /// </summary>
            void Delete_view();
            /// <summary>
            /// Удаляет синоним
            /// </summary>
            void Delete_synonym();
            /// <summary>
            /// Удаляет процедуру
            /// </summary>
            void Delete_procedure();

        }

        /// <summary>
        /// Класс для Oracle
        /// </summary>
        class Oracle : IDB
        {
            public void Create_DB()
            {
                Console.WriteLine("Oracle: creating DB.");
            }
            public void Add_table()
            {
                Console.WriteLine("Oracle: adding a table.");
            }
            public void Add_view()
            {
                Console.WriteLine("Oracle: adding a view.");
            }
            public void Add_synonym()
            {
                Console.WriteLine("Oracle: adding a synonym.");
            }
            public void Add_procedure()
            {
                Console.WriteLine("Oracle: adding a procedure.");
            }
            public void Alter_table()
            {
                Console.WriteLine("Oracle: altering a table.");
            }
            public void Delete_table()
            {
                Console.WriteLine("Oracle: deleting a table.");
            }
            public void Delete_view()
            {
                Console.WriteLine("Oracle: deleting a view.");
            }
            public void Delete_synonym()
            {
                Console.WriteLine("Oracle: deleting a synonym.");
            }
            public void Delete_procedure()
            {
                Console.WriteLine("Oracle: deleting a procedure.");
            }
        }

        /// <summary>
        /// Класс для MySQL
        /// </summary>
        class MySQL : IDB
        {
            public void Create_DB()
            {
                Console.WriteLine("MySQL: creating DB.");
            }
            public void Add_table()
            {
                Console.WriteLine("MySQL: adding a table.");
            }
            public void Add_view()
            {
                Console.WriteLine("MySQL: adding a view.");
            }
            public void Add_synonym()
            {
                Console.WriteLine("MySQL: adding a synonym.");
            }
            public void Add_procedure()
            {
                Console.WriteLine("MySQL: adding a procedure.");
            }
            public void Alter_table()
            {
                Console.WriteLine("MySQL: altering a table.");
            }
            public void Delete_table()
            {
                Console.WriteLine("MySQL: deleting a table.");
            }
            public void Delete_view()
            {
                Console.WriteLine("MySQL: deleting a view.");
            }
            public void Delete_synonym()
            {
                Console.WriteLine("MySQL: deleting a synonym.");
            }
            public void Delete_procedure()
            {
                Console.WriteLine("MySQL: deleting a procedure.");
            }
        }

        /// <summary>
        /// Класс для PostgreSQL
        /// </summary>
        class PostgreSQL : IDB
        {
            public void Create_DB()
            {
                Console.WriteLine("PostgreSQL: creating DB.");
            }
            public void Add_table()
            {
                Console.WriteLine("PostgreSQL: adding a table.");
            }
            public void Add_view()
            {
                Console.WriteLine("PostgreSQL: adding a view.");
            }
            public void Add_synonym()
            {
                Console.WriteLine("PostgreSQL: adding a synonym.");
            }
            public void Add_procedure()
            {
                Console.WriteLine("PostgreSQL: adding a procedure.");
            }
            public void Alter_table()
            {
                Console.WriteLine("PostgreSQL: altering a table.");
            }
            public void Delete_table()
            {
                Console.WriteLine("PostgreSQL: deleting a table.");
            }
            public void Delete_view()
            {
                Console.WriteLine("PostgreSQL: deleting a view.");
            }
            public void Delete_synonym()
            {
                Console.WriteLine("PostgreSQL: deleting a synonym.");
            }
            public void Delete_procedure()
            {
                Console.WriteLine("PostgreSQL: deleting a procedure.");
            }
        }

        /// <summary>
        /// Класс для работы с клиентом
        /// </summary>
        class DB_Client
        {
            private IDB db;
            /// <summary>
            /// Конструктор класса
            /// </summary>
            /// <param name="db"></param>
            public DB_Client(IDB db)
            {
                this.db = db;
            }

            /// <summary>
            /// Метод вызывающий метод Create_DB интерфейса IDB
            /// </summary>
            public void Create_DB()
            {
                db.Create_DB();
            }
            /// <summary>
            /// Метод вызывающий метод Add_table интерфейса IDB
            /// </summary>
            public void Add_table()
            {
                db.Add_table();
            }
            /// <summary>
            /// Метод вызывающий метод Add_view интерфейса IDB
            /// </summary>
            public void Add_view()
            {
                db.Add_view();
            }
            /// <summary>
            /// Метод вызывающий метод Add_synonym интерфейса IDB
            /// </summary>
            public void Add_synonym()
            {
                db.Add_synonym();
            }
            /// <summary>
            /// Метод вызывающий метод Add_procedure интерфейса IDB
            /// </summary>
            public void Add_procedure()
            {
                db.Add_procedure();
            }
            /// <summary>
            /// Метод вызывающий метод Alter_table интерфейса IDB
            /// </summary>
            public void Alter_table()
            {
                db.Alter_table();
            }
            /// <summary>
            /// Метод вызывающий метод Delete_table интерфейса IDB
            /// </summary>
            public void Delete_table()
            {
                db.Delete_table();
            }
            /// <summary>
            /// Метод вызывающий метод Delete_view интерфейса IDB
            /// </summary>
            public void Delete_view()
            {
                db.Delete_view();
            }
            /// <summary>
            /// Метод вызывающий метод Delete_synonym интерфейса IDB
            /// </summary>
            public void Delete_synonym()
            {
                db.Delete_synonym();
            }
            /// <summary>
            /// Метод вызывающий метод Delete_procedure интерфейса IDB
            /// </summary>
            public void Delete_procedure()
            {
                db.Delete_procedure();
            }
        }

        static void Main(string[] args)
        {
            DB_Client c_db;
            string name;
            string list;
            Regex regex = new Regex(@"\w+");
            Console.WriteLine("Введите название СУБД (Oracle, MySQL, PostgreSQL): ");

            try
            {
                name = Console.ReadLine();
                switch (name)
                {
                    case "Oracle":
                        c_db = new DB_Client(new Oracle());
                        break;
                    case "MySQL":
                        c_db = new DB_Client(new MySQL());
                        break;
                    case "PostgreSQL":
                        c_db = new DB_Client(new PostgreSQL());
                        break;
                    default: 
                        Console.WriteLine("Неверное название!");
                        Console.ReadKey();
                        return;
                }

                Console.WriteLine("Введите список действий (Create_DB, Add_table, Add_view, Add_synonym, Add_procedure, Alter_table,\n    Delete_table, Delete_view, Delete_synonym, Delete_procedure): ");
                list = Console.ReadLine();
                MatchCollection matches = regex.Matches(list);
                foreach (Match op in matches)
                {
                    switch (op.ToString())
                    {
                        case "Create_DB":
                            c_db.Create_DB();
                            break;
                        case "Add_table":
                            c_db.Add_table();
                            break;
                        case "Add_view":
                            c_db.Add_view();
                            break;
                        case "Add_synonym":
                            c_db.Add_synonym();
                            break;
                        case "Add_procedure":
                            c_db.Add_procedure();
                            break;
                        case "Alter_table":
                            c_db.Alter_table();
                            break;
                        case "Delete_table":
                            c_db.Delete_table();
                            break;
                        case "Delete_view":
                            c_db.Delete_view();
                            break;
                        case "Delete_synonym":
                            c_db.Delete_synonym();
                            break;
                        case "Delete_procedure":
                            c_db.Delete_procedure();
                            break;
                        default:
                            Console.WriteLine("Неверное название!");
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.ReadKey();
        }
    }
}
