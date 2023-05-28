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
        public static void Load(PhoneBook phonebook, string FileName)
        {
            if (File.Exists(FileName))
            {
                string[] book = File.ReadAllLines(FileName);

                foreach (string line in book)
                {
                    string[] components = line.Split(',');
                    if (components.Length == 2)
                    {
                        string name = components[0];
                        string phone = components[1];
                        phonebook.AddContact(new Contact(name, phone));
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл не сущевтсвует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Save(ListBox ContactsList, string FileName)
        {
            StreamWriter streamwriter = new StreamWriter(FileName);

            for (int i = 0; i < ContactsList.Items.Count; i++)
            {
                streamwriter.WriteLine(ContactsList.Items[i]);
            }
            streamwriter.Close();
        }
    }
}
