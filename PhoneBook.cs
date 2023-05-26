using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PhoneBook
    {
        private List<Contact> contacts = new List<Contact> ();    

        public void AddContact (Contact contact)
        {
            contacts.Add (contact);
        }

        public void RemoveContact (Contact contact)
        {
            contacts.Remove (contact);
        }

        public void RemoveContactByName (string name)
        {
            Contact contact = contacts.Find(c =>  c.Name == name);
            if (contact != null)
            {
                contacts.Remove (contact);
            }
        }

        public Contact GetContactByName (string name)
        {
            return contacts.Find(c => c.Name == name);
        }

        public List<Contact> GetContacts () {return contacts;}

        public List<Contact> FindContact (string desiredObject)
        {
            List<Contact> searchResult = new List<Contact>();
            foreach (Contact contact in contacts)
            {
                if (contact.Name.Contains(desiredObject))
                {
                    searchResult.Add (contact);
                }
            }
            return searchResult;
        }

        public List<Contact> FindNumber (string desiredObject)
        {
            List<Contact> searchResult = new List<Contact>();
            foreach (Contact contact in contacts)
            {
                if (contact.Phone.Contains(desiredObject))
                {
                    searchResult.Add (contact);
                }
            }
            return searchResult;
        }
    }
}
