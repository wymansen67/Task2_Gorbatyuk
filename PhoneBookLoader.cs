using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class PhoneBookLoader
    {
        public static void Load(PhoneBook phoneBook, string fileName)
        {
            if (File.Exists(fileName))
            {
                string[] bookLines = File.ReadAllLines(fileName);
                {
                    foreach (string line in bookLines)
                    {
                        string[] chasti = line.Split(';');
                        if (chasti.Length == 2)
                        {
                            string name = chasti[0];
                            string phoneNumber = chasti[1];
                            phoneBook.AddContact(new Contact(name, phoneNumber));
                        }
                    }
                }
            }
        }
        public static void Save(ListBox listbox, string fileName) 
        { 
            StreamWriter streamWriter = new StreamWriter(fileName);
            for (int i = 0; i < listbox.Items.Count; i++)
            {
                streamWriter.WriteLine(listbox.Items[i].ToString());
            }
            streamWriter.Close();
        }
    }
}
