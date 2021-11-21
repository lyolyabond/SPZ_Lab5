using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SPZ_Lab5.Model
{
    [DataContract]
    [KnownType(typeof(Group))]
    class Student
    {
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public  string FirstName { get; set; }
        [DataMember]
        public Group Group{ get; set; }
        static Random random = new Random();

        private static string[] lastNamesArray = new string[] { "Бондаренко", "Петренко", "Шевченко", "Носик", "Токарь", 
                                                                 "Кротенко", "Рыженко", "Зубенко", "Чепурных", "Титаренко",
                                                                  "Нотич", "Стадник", "Смит", "Грей", "Паркер", "Скотт"};
        private static string[] firstNamesArray = new string[] { "Александр","Максим", "Даниил", "Иван", "Сергей", "Адам",
                                                                 "Михаил", "Карл","Кристиан", "Джон", "Лукас","Кристиан",
                                                                  "Ольга", "Оливия", "Мария", "Анна", "Татьяна",
                                                                  "Алиса", "Ева", "Полина", "Сабрина", "Хлоя", "Эшли"};
        public Student()
        {
            LastName = lastNamesArray[random.Next(0, lastNamesArray.Length)];
            FirstName = firstNamesArray[random.Next(0, firstNamesArray.Length)];
            Group = new Group(random);
        }
        public Student(string lastName, string firstName, string groupNumber)
        {
            LastName = lastName;
            FirstName = firstName;
            Group = new Group(groupNumber);
        }
    }
}
