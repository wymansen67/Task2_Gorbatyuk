using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private PhoneBook phoneBook = new PhoneBook();        
        static string CheckName (string name)
        {
            string message = "";

            if ( name == "" )
            {
                message = "Поле для ввода имени не может быть пустым.";
            }
            else
            {
                foreach ( char symbol in name )
                {
                    if ( !char.IsLetter(symbol) && symbol != ' ' )
                    {
                        message = "Поле имя может содержать только буквы.";
                        break;
                    }
                }
            }

            return message;
        }
        static string CheckPhone (string phoneNumber)
        {
            string message = "";

            if ( phoneNumber == "" )
            {
                message = "Поле для ввода номера телефона не может быть пустым.";
            }
            else
            {
                if ( message == "" )
                {
                    foreach ( char symbol in phoneNumber )
                    {
                        if ( !char.IsDigit(symbol) && symbol != '+' && symbol != '-')
                        {
                            message = "Поле для ввода номера телефона может содержать только цифры и знак +.";
                            break;
                        }
                    }
                }

                if ( message == "" )
                {                   
                        if ( phoneNumber.Length < 13 || phoneNumber.Length > 13 )
                        {
                            message = "Некорректное количество символов в номере телефона для сохранения.";
                        }                    
                }
            }

            return message;
        }
        public Form1()
        {
            InitializeComponent();            
        }

        //ListBox fill method
        public void refreshList()
        {
            listBox1.Items.Clear();
            foreach (Contact contact in phoneBook.GetContacts())
            {
                listBox1.Items.Add(contact);
            }
        }
        private void ImportPhoneBook (string filename)
        {
            try
            {
                PhoneBookLoader.Load(phoneBook, filename);
            }
            catch ( Exception ex )
            {
                MessageBox.Show("При загрузке книги произошла ошибка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      
        private void Form1_Load(object sender, EventArgs e)
        {            
            ImportPhoneBook("contacts.csv");
            refreshList();
        }
        private void SearchContact_Click(object sender, EventArgs e)
        {
            if (CheckName(textBox1.Text) != "" && CheckPhone(textBox2.Text) != "")
            {
                if (CheckName(textBox1.Text) != "") MessageBox.Show(CheckName(textBox1.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (CheckPhone(textBox2.Text) != "") MessageBox.Show(CheckPhone(textBox2.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckName(textBox1.Text) != "" && CheckPhone(textBox2.Text) == "")
            {
                List<Contact> searchRez = phoneBook.FindContact(textBox1.Text);
                listBox1.Items.Clear();
                foreach (Contact contact in searchRez)
                {
                    listBox1.Items.Add(contact);
                }                
            }
            else if (CheckName(textBox1.Text) == "" && CheckPhone(textBox2.Text) != "")
            {
                List<Contact> searchRezNumber = phoneBook.FindNumber(textBox2.Text);
                listBox1.Items.Clear();
                foreach (Contact contact in searchRezNumber)
                {
                    listBox1.Items.Add(contact);
                }  
            }
            else if (CheckName(textBox1.Text) == "" && CheckPhone(textBox2.Text) == "")
            {
                List<Contact> searchRez = phoneBook.FindContact(textBox1.Text);
                listBox1.Items.Clear();
                foreach (Contact contact in searchRez)
                {
                    listBox1.Items.Add(contact);
                }
                List<Contact> searchRezNumber = phoneBook.FindNumber(textBox2.Text);
                foreach (Contact contact in searchRezNumber)
                {
                    listBox1.Items.Add(contact);
                }
            }
        }
        private void AddContact_Click(object sender, EventArgs e)
        {
            foreach (Contact contact in phoneBook.GetContacts())
            {
                if (CheckName(textBox1.Text) == "" && CheckPhone(textBox2.Text) == "")
                {
                    if (!contact.Name.Contains(textBox1.Text) || !contact.Phone.Contains(textBox2.Text))
                    {
                        phoneBook.AddContact(new Contact(textBox1.Text, textBox2.Text));
                        MessageBox.Show("Контакт успешно добавлен", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("Такой контакт уже существует", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }
                }
                else if (CheckName(textBox1.Text) != "" || CheckPhone(textBox2.Text) != "")
                {
                    if (CheckName(textBox1.Text) != "") MessageBox.Show(CheckName(textBox1.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (CheckPhone(textBox2.Text) != "") MessageBox.Show(CheckPhone(textBox2.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }
        private void DeleteContact_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string SelectedContact = listBox1.SelectedItem.ToString();
                phoneBook.RemoveContactByName(SelectedContact);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            PhoneBookLoader.Save(listBox1,"contact.txt");
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SaveToFile_Click(object sender, EventArgs e)
        {
            PhoneBookLoader.Save(listBox1,"contact.csv");
        }
        private void Refresh_Click(object sender, EventArgs e)
        {
            refreshList();
        }                
    }
}
