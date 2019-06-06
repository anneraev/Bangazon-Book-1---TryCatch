using System;
using System.Collections.Generic;
namespace Contacts {
    class AddressBook {
        private Dictionary<string, Contact> _dictionary = new Dictionary<string, Contact>();

        public void AddContact(Contact Contact){
            try{
            _dictionary.Add($"{Contact.Email}", Contact);
            } catch(ArgumentException) {
                Console.WriteLine($"{Contact.Email}: This contact is already present");
            }
        }

        public Contact GetByEmail(string Email){
            if (_dictionary.ContainsKey(Email)){
                return _dictionary[Email];
            } else {
                return null;
            }
        }
    }
}