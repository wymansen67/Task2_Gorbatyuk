namespace WindowsFormsApp1
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchContact = new System.Windows.Forms.Button();
            this.AddContact = new System.Windows.Forms.Button();
            this.DeleteContact = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SaveToFile = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(301, 394);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Контакты. Список";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(464, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 2;
            // 
            // SearchContact
            // 
            this.SearchContact.Location = new System.Drawing.Point(329, 94);
            this.SearchContact.Name = "SearchContact";
            this.SearchContact.Size = new System.Drawing.Size(152, 23);
            this.SearchContact.TabIndex = 3;
            this.SearchContact.Text = "Ищи контакт";
            this.SearchContact.UseVisualStyleBackColor = true;
            this.SearchContact.Click += new System.EventHandler(this.SearchContact_Click);
            // 
            // AddContact
            // 
            this.AddContact.Location = new System.Drawing.Point(516, 94);
            this.AddContact.Name = "AddContact";
            this.AddContact.Size = new System.Drawing.Size(152, 23);
            this.AddContact.TabIndex = 4;
            this.AddContact.Text = "Добавить контакт";
            this.AddContact.UseVisualStyleBackColor = true;
            this.AddContact.Click += new System.EventHandler(this.AddContact_Click);
            // 
            // DeleteContact
            // 
            this.DeleteContact.Location = new System.Drawing.Point(516, 135);
            this.DeleteContact.Name = "DeleteContact";
            this.DeleteContact.Size = new System.Drawing.Size(152, 23);
            this.DeleteContact.TabIndex = 5;
            this.DeleteContact.Text = "Удалить контакт";
            this.DeleteContact.UseVisualStyleBackColor = true;
            this.DeleteContact.Click += new System.EventHandler(this.DeleteContact_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(610, 400);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(52, 38);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SaveToFile
            // 
            this.SaveToFile.Location = new System.Drawing.Point(329, 135);
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.Size = new System.Drawing.Size(152, 23);
            this.SaveToFile.TabIndex = 7;
            this.SaveToFile.Text = "Сохранить в файл";
            this.SaveToFile.UseVisualStyleBackColor = true;
            this.SaveToFile.Click += new System.EventHandler(this.SaveToFile_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(464, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя контакта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Телефончик контакта";
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Refresh.Location = new System.Drawing.Point(329, 387);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(50, 46);
            this.Refresh.TabIndex = 11;
            this.Refresh.Text = "⟳";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SaveToFile);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DeleteContact);
            this.Controls.Add(this.AddContact);
            this.Controls.Add(this.SearchContact);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchContact;
        private System.Windows.Forms.Button AddContact;
        private System.Windows.Forms.Button DeleteContact;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SaveToFile;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Refresh;
    }
}

