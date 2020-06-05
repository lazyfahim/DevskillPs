using System;

namespace PrototypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Email anemail = new Email{
                EmailAddress = "fahimabrar13@gmail.com",
                FirstName = "Fahim",
                LastName = "Abrar",
                Port = 80,
                SMTP = "smtp://mail.fahimabrar.com"
            };
            var anotherEmail = anemail.Clone();
            Console.WriteLine(anotherEmail.EmailAddress);
        }
    }
    class Email
    {
        public string EmailAddress{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string SMTP{get;set;}
        public int Port{get;set;}
        public Email Clone()
        {
            return new Email{
                EmailAddress = this.EmailAddress,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Port = this.Port,
                SMTP = this.SMTP
            };
        }
    }
}
