using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace taskk14.Extension
{
    internal class Helper
    {

        public static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public static bool HasdDigit(string name)
        {
           for (int i = 0; i < name.Length; i++) 
            {
             if (char.IsDigit(name[i]) )
                {
                    return true;
                }
            }
           return false;
        }

        public static bool CheckPassword(string password)
        {
        if (password.Length>=8)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsDigit(password[i]))
                    {
                        for (int j = 0; j < password.Length; j++)
                        {
                            if(char.IsLower(password[j]))
                            {
                                for (int k = 0; k < password.Length; k++)
                                {
                                    if(char.IsUpper(password[k]))
                                    {
                                        return true;
                                    }

                                }
                            }
                        }
                          
                    }
                   
                }               
            }
            Console.WriteLine("passwordun uzunlugu 8 ve minimum 1 reqem,1 kicik herf ,1 de boyuk herf olmalidir");
            return false;
        }

        public static string Capitalize(string text) 
        {
            return text.Substring(0, 1).ToUpper()+text.Substring(1).ToLower();
        
        }
            
        //IsOdd() - int deyerler üçün həmin obyektin tək ədəd olub olmadığını geri qaytaran(true/false) method
        //IsEven() - int deyerler  üçün həmin obyektin cüt ədəd olub olmadığını geri qaytaran(true/false) method
        //HasDigit() - string deyerler  üçün həmin obyektin daxilində digit character olub olmamasını geri qaytaran(true/false) metod
        //CheckPassword() - string deyerlerini yoxluyub true/false qaytarir Password-da en azi bir boyuk bir kicik herf ve en azi 1 reqem olamilidir.Uzunlugu 8-den kicik olmamalidir.
        //Capitalize() - String-lər üçün Capitalize adlı extention metod yaradırsınız.Bu metod string dəyərini capitalaize edib geri
    }
}
