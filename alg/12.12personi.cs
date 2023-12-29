using System;
class Program
{
    static void Main()
    {
        string sortobraz = "Среднее", sortname = "Петя";
        int sortyear = 2000;
        Person[] persons = new Person[10];
        persons[0] = new Person("Петя", 2000, "Среднее", "Кирова, 10");
        persons[1] = new Person("Вася", 1997, "Высшее", "10 Рабоячая, 5");
        persons[2] = new Person("Даня", 2000, "Среднее", "Кирова, 10");
        persons[3] = new Person("Саня", 2000, "Нет", "Кирова, 10");
        persons[4] = new Person("Таня", 1976, "Высшее", "Харьковская, 10");
        persons[5] = new Person("Маня", 1891, "Нет", "Мира, 10");
        persons[6] = new Person("Петя", 2002, "Высшее", "Кирова, 15");
        persons[7] = new Person("Петя", 2000, "Среднее", "Кирова, 13");
        persons[8] = new Person("Петя", 1988, "Среднее", "Кирова, 12");
        persons[9] = new Person("Петя", 2002, "Высшее", "Кирова, 11");
        Console.WriteLine("Сортировка по образованию типа: " + sortobraz);
        for (int i = 0; i < persons.Length; i++)
        {
            Person person = persons[i];
            if (person.sortByEducation(person, sortobraz) != null)
            {
                Console.WriteLine(person.getPersonInformation(person.sortByEducation(person, sortobraz)));
            }
        }
        Console.WriteLine("Сортировка по году рождения: " + sortyear);
        for (int i = 0; i < persons.Length; i++)
        {
            Person person = persons[i];
            if (person.sortByYear(person, sortyear) != null)
            {
                Console.WriteLine(person.getPersonInformation(person.sortByYear(person, sortyear)));
            }
        }
        Console.WriteLine("Сортировка по имени:" + sortname);
        for (int i = 0; i < persons.Length; i++)
        {
            Person person = persons[i];
            if (person.sortByName(person, sortname) != null)
            {
                Console.WriteLine(person.getPersonInformation(person.sortByName(person, sortname)));
            }
        }
    }
}
    class Person
    {
        private String Name;
        private int Year;
        private String Obraz;
        private String Adres;
        public Person(String Name, int Year, String Obraz, String Adres)
        {
            this.Name = Name;
            this.Year = Year;
            this.Obraz = Obraz;
            this.Adres = Adres;
        }
        public Person sortByName(Person person, String name)
        {
            if (person.Name.Equals(name))
            {
                return person;
            }
            else
            {
                return null;
            }
        }
        public Person sortByYear(Person person, int year)
        {
            if (person.Year == year)
            {
                return person;
            }
            else
            {
                return null;
            }
        }
        public Person sortByEducation(Person person, String obraz)
        {
            if (person.Obraz.Equals(obraz))
            {
                return person;
            }
            else
            {
                return null;
            }
        }
        public String getname(Person person)
        {
            return person.Name;
        }
        public int getYear(Person person)
        {
            return person.Year;
        }
        public String getobraz(Person person)
        {
            return person.Obraz;
        }
        public String getadres(Person person)
        {
            return person.Adres;
        }
        public String getPersonInformation(Person person)
        {
            if (person != null)
            {
                return person.Name + ", " + Convert.ToString(person.Year) + ", " + person.Obraz + ", " + person.Adres;
            }
            else
            {
                return null;
            }
        }
        public void setname(String name)
        {
            this.Name = name;
        }

        public void setyear(int year)
        {
            this.Year = year;
        }

        public void setobraz(String obraz)
        {
            this.Obraz = obraz;
        }

        public void setAdress(String adres)
        {
            this.Adres = adres;
        }
    }