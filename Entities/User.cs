using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Wallet___Bank_System_OOP_Mini_Project__.Entities
{
    public class User
    {
        public User(string fullName, string email, string phoneNumber)
        {
            Id = _identity++;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public int Id { get; private set; }
        private string _fullName;
        private string _email;
        private string _phoneNumber;
        public string FullName 
        {
          get { return _fullName; }
          set {
                if (value.Length < 10 || value.Length > 50)
                    throw new Exception("Please write your full name between 10 and 50 characters.");
                else
                    _fullName = value;
          }
        }
        public string Email {
            get { return _email; }
            set {
                if (!value.Contains("@") || !value.Contains("."))
                    throw new Exception("Enter a valid Email. ");
                _email = value;
            } 
        }
        public string PhoneNumber {
            get => _phoneNumber;
            set {if (value.Length != 11)
                    throw new Exception("please enter a valid Phone Number.");
            _phoneNumber = value;
                    }
        }

        private static int _identity = 1; 

        //check
        public void RegisterUserProfile(string fullName , string email ,string phoneNumber) {
            Id = _identity++;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

    }
}
