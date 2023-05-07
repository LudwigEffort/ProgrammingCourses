using System.Net.Mail;
using System.Net.Http;
using System;

namespace classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            //? class = A bundle of related code.
            //?       = Can be used as a blueprint to create objects (OOP)

            Message.Hello();
            Message.Waiting();
            Message.Bye();
        }

    }
}
