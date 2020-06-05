using System;

namespace BuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EmailBuilder emailBuilder = new EmailBuilder();
            emailBuilder.SetFirstName("fahim").SetLastName("abrar")
                .SetEmail("mail@fahimabrar.com");
            Console.WriteLine(emailBuilder.Build().EmailAddress);
        }
    }
    class Email
    {
        public string EmailAddress{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string SMTP{get;set;}
        public int Port{get;set;}
    }
    class EmailBuilder
    {
        private Email _email;
        public EmailBuilder()
        {
            _email = new Email();
        }
        public EmailBuilder SetFirstName(string firsname)
        {
            _email.FirstName = firsname;
            return this;
        }
        public EmailBuilder SetLastName(string lastname)
        {
            _email.LastName = lastname;
            return this;
        }
        public EmailBuilder SetEmail(string email)
        {
            _email.EmailAddress = email;
            return this;
        }
        public Email Build()
        {
            return this._email;
        }
    }
}
