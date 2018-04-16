using System;

namespace task5
{
    class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private DateTime registerDate;

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.firstName = name;
            this.lastName = surname;
            this.age = age;
            registerDate = DateTime.Now;
        }
        public override string  ToString()
        {
            return "Login: " + login + " \nname: " + firstName + "\nsurname: " + lastName + "\nage: " + age + " \nDate of reistration: " + registerDate.ToString();
        }
    }
}
