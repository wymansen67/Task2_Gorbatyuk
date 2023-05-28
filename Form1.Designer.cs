namespace WindowsFormsApp1
{
    partial class FormContacts
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBoxContacts = new System.Windows.Forms.ListBox();
            this.LabelContactsList = new System.Windows.Forms.Label();
            this.TextBoxContactName = new System.Windows.Forms.TextBox();
            this.ButtonSearchContact = new System.Windows.Forms.Button();
            this.ButtonRemoveContact = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonSaveToFile = new System.Windows.Forms.Button();
            this.TextBoxContactPhone = new System.Windows.Forms.TextBox();
            this.LabelContactName = new System.Windows.Forms.Label();
            this.LabelContactPhone = new System.Windows.Forms.Label();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonContactAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxContacts
            // 
            this.ListBoxContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBoxContacts.FormattingEnabled = true;
            this.ListBoxContacts.ItemHeight = 20;
            this.ListBoxContacts.Location = new System.Drawing.Point(14, 32);
            this.ListBoxContacts.Name = "ListBoxContacts";
            this.ListBoxContacts.Size = new System.Drawing.Size(301, 384);
            this.ListBoxContacts.TabIndex = 0;
            // 
            // LabelContactsList
            // 
            this.LabelContactsList.AutoSize = true;
            this.LabelContactsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelContactsList.Location = new System.Drawing.Point(10, 9);
            this.LabelContactsList.Name = "LabelContactsList";
            this.LabelContactsList.Size = new System.Drawing.Size(150, 20);
            this.LabelContactsList.TabIndex = 1;
            this.LabelContactsList.Text = "Список контактов:";
            // 
            // TextBoxContactName
            // 
            this.TextBoxContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxContactName.Location = new System.Drawing.Point(516, 36);
            this.TextBoxContactName.Name = "TextBoxContactName";
            this.TextBoxContactName.Size = new System.Drawing.Size(204, 26);
            this.TextBoxContactName.TabIndex = 2;
            // 
            // ButtonSearchContact
            // 
            this.ButtonSearchContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSearchContact.Location = new System.Drawing.Point(341, 108);
            this.ButtonSearchContact.Name = "ButtonSearchContact";
            this.ButtonSearchContact.Size = new System.Drawing.Size(152, 33);
            this.ButtonSearchContact.TabIndex = 3;
            this.ButtonSearchContact.Text = "Ищи контакт";
            this.ButtonSearchContact.UseVisualStyleBackColor = true;
            this.ButtonSearchContact.Click += new System.EventHandler(this.ButtonSearchContact_Click);
            // 
            // ButtonRemoveContact
            // 
            this.ButtonRemoveContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRemoveContact.Location = new System.Drawing.Point(545, 167);
            this.ButtonRemoveContact.Name = "ButtonRemoveContact";
            this.ButtonRemoveContact.Size = new System.Drawing.Size(152, 33);
            this.ButtonRemoveContact.TabIndex = 5;
            this.ButtonRemoveContact.Text = "Удалить контакт";
            this.ButtonRemoveContact.UseVisualStyleBackColor = true;
            this.ButtonRemoveContact.Click += new System.EventHandler(this.ButtonRemoveContact_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExit.Location = new System.Drawing.Point(610, 381);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(87, 38);
            this.ButtonExit.TabIndex = 6;
            this.ButtonExit.Text = "Выход";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonSaveToFile
            // 
            this.ButtonSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSaveToFile.Location = new System.Drawing.Point(341, 159);
            this.ButtonSaveToFile.Name = "ButtonSaveToFile";
            this.ButtonSaveToFile.Size = new System.Drawing.Size(152, 49);
            this.ButtonSaveToFile.TabIndex = 7;
            this.ButtonSaveToFile.Text = "Сохранить в файл";
            this.ButtonSaveToFile.UseVisualStyleBackColor = true;
            this.ButtonSaveToFile.Click += new System.EventHandler(this.ButtonSaveToFile_Click);
            // 
            // TextBoxContactPhone
            // 
            this.TextBoxContactPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxContactPhone.Location = new System.Drawing.Point(516, 65);
            this.TextBoxContactPhone.Name = "TextBoxContactPhone";
            this.TextBoxContactPhone.Size = new System.Drawing.Size(204, 26);
            this.TextBoxContactPhone.TabIndex = 8;
            // 
            // LabelContactName
            // 
            this.LabelContactName.AutoSize = true;
            this.LabelContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelContactName.Location = new System.Drawing.Point(326, 39);
            this.LabelContactName.Name = "LabelContactName";
            this.LabelContactName.Size = new System.Drawing.Size(118, 20);
            this.LabelContactName.TabIndex = 9;
            this.LabelContactName.Text = "Имя контакта:";
            // 
            // LabelContactPhone
            // 
            this.LabelContactPhone.AutoSize = true;
            this.LabelContactPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelContactPhone.Location = new System.Drawing.Point(326, 71);
            this.LabelContactPhone.Name = "LabelContactPhone";
            this.LabelContactPhone.Size = new System.Drawing.Size(183, 20);
            this.LabelContactPhone.TabIndex = 10;
            this.LabelContactPhone.Text = "Телефончик контакта:";
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.ButtonRefresh.Location = new System.Drawing.Point(330, 372);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(53, 44);
            this.ButtonRefresh.TabIndex = 11;
            this.ButtonRefresh.Text = "⟳";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ButtonContactAdd
            // 
            this.ButtonContactAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonContactAdd.Location = new System.Drawing.Point(545, 108);
            this.ButtonContactAdd.Name = "ButtonContactAdd";
            this.ButtonContactAdd.Size = new System.Drawing.Size(152, 33);
            this.ButtonContactAdd.TabIndex = 12;
            this.ButtonContactAdd.Text = "Добавить контакт";
            this.ButtonContactAdd.UseVisualStyleBackColor = true;
            this.ButtonContactAdd.Click += new System.EventHandler(this.ButtonContactAdd_Click);
            // 
            // FormContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 426);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonContactAdd);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.LabelContactPhone);
            this.Controls.Add(this.LabelContactName);
            this.Controls.Add(this.TextBoxContactPhone);
            this.Controls.Add(this.ButtonSaveToFile);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonRemoveContact);
            this.Controls.Add(this.ButtonSearchContact);
            this.Controls.Add(this.TextBoxContactName);
            this.Controls.Add(this.LabelContactsList);
            this.Controls.Add(this.ListBoxContacts);
            this.Name = "FormContacts";
            this.Text = "Мои контакты";
            this.Load += new System.EventHandler(this.FormContacts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxContacts;
        private System.Windows.Forms.Label LabelContactsList;
        private System.Windows.Forms.TextBox TextBoxContactName;
        private System.Windows.Forms.Button ButtonSearchContact;
        private System.Windows.Forms.Button AddContact;
        private System.Windows.Forms.Button ButtonRemoveContact;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonSaveToFile;
        private System.Windows.Forms.TextBox TextBoxContactPhone;
        private System.Windows.Forms.Label LabelContactName;
        private System.Windows.Forms.Label LabelContactPhone;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Button ButtonContactAdd;
    }
}