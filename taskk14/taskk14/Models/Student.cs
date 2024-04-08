using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using taskk14.Extension;

namespace taskk14.Models
{
    internal class Student : Helper
    {
        private static int _count = 1;
        public  static int Id { get; set; }
        private static string _name;
        private static string _surname;

        public string Name 
        {
            get { return _name; }
            set 
            {
              
                    if (isLetter(value))
                    {
                       _name= value;
                    
                    }
                else if (!isLetter(value))
                {
                    Console.WriteLine("adda regem ola bilmez");
                }

            }
        }
        public  string Surname 
        { 
            get { return _surname; } 
            set
            {
                if (isLetter(value))
                {
                    _surname = value;
                }
                else if (!isLetter(value))
                {
                    Console.WriteLine("soy adda regem ola bilmez");
                }
            }
        }

        public Student(string name , string surname)
        {
            Name = Helper.Capitalize( name);
            Surname =Helper.Capitalize( surname);
            Id = _count++;
        }
         
        private static bool isLetter(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public void GetInfo()
        {
            Console.WriteLine($"telebenin adi: {_name}\ntelebenin soy adi:  {_surname}\ntelebenin id: {Id}");
        }
}
}
