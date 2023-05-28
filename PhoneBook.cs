using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class PhoneBook
    {
        List<Contact> Contacts;

        public PhoneBook()
        {
            Contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public bool CheckContainsContact(Contact VerifableContact)
        {
            bool NotFound = true;

            foreach (Contact Contact in Contacts)
            {
                if (Contact.Phone.Contains(VerifableContact.Phone))
                {
                    NotFound = false;
                    break;
                }
            }
            return NotFound;
        }

        public List<Contact> GetContacts() { return Contacts; }

        public List<Contact> SearchContact(PhoneBook phonebook, string c)
        {
            bool search = false;
            List<Contact> searchResults = new List<Contact>();
            foreach (Contact contact in phonebook.GetContacts())
            {
                if (contact.Name.Contains(c) || contact.Phone.Contains(c))
                {
                    searchResults.Add(contact);
                    search = true;
                }
            }

            if (search == false)
            {
                MessageBox.Show("Не найдено.");
            }

            return searchResults;
        }

        public void RemoveContact(PhoneBook phonebook, string name, string phone)
        {
            foreach (Contact contact in phonebook.GetContacts().ToList())
            {
                if (contact.Name.Contains(name) && contact.Phone.Contains(phone))
                {
                    Contacts.Remove(contact);
                }
            }
        }
    }
}
