using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpreUserRegi
{
    internal class LambdaRegix
    {
        public static string Regex_Email = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public static string Regex_mobilenum = "^[0-9]{2}[ ]?[6-9][0-9]{9}$";
        public static string pattern = "^[A-Z][a-z]{2,}$";
        public static string Regex_password = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$";

        public bool validateFirstName(string Name)
        {
            Regex name = new Regex(pattern);
            bool Fn = name.IsMatch(Name);
            return Fn;
        }
        public bool validateLastName(string Name)
        {
            Regex name = new Regex(pattern);
            bool Fn = name.IsMatch(Name);
            return Fn;
        }
       
        public bool validateEmail(string Email)
        {
            Regex mail = new Regex(Regex_Email);
            bool email = mail.IsMatch(Email);
            return email;
        }
        /// Validates the mobilenum.
        public bool validateMobilenum(string Mobile)
        {
            Regex Mob = new Regex(Regex_mobilenum);
            bool mobile = Mob.IsMatch(Mobile);
            return mobile;
        }
        /// Validates the password.
        public bool validatePassword(string Pass)
        {
            Regex pass = new Regex(Regex_password);
            bool password = pass.IsMatch(Pass);
            return password;
        }

        public static Func<string, bool> validateuserLname = Name => Regex.IsMatch(Name, pattern);
        public static Func<string, bool> validateuserFname = Name => Regex.IsMatch(Name, pattern);
        public static Func<string, bool> validateUserEmail = Email => Regex.IsMatch(Email, Regex_Email);
        public static Func<string, bool> validateuserMobile = Mobile => Regex.IsMatch(Mobile, Regex_mobilenum);
        public static Func<string, bool> validateuserpassword = Pass => Regex.IsMatch(Pass, Regex_password);
    }
}

