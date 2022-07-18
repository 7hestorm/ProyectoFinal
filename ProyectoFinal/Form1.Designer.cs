namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ListContacts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(11, 34);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(71, 17);
            this.Name.TabIndex = 0;
            this.Name.Text = "First Name";
            this.Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(12, 85);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(70, 17);
            this.email.TabIndex = 1;
            this.email.Text = "Last Name";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(18, 143);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(44, 17);
            this.Phone.TabIndex = 2;
            this.Phone.Text = "Phone";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(88, 26);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(177, 25);
            this.NameTxt.TabIndex = 3;
            this.NameTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(88, 82);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(177, 25);
            this.emailTxt.TabIndex = 4;
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Location = new System.Drawing.Point(88, 140);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(177, 25);
            this.PhoneTxt.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Contact";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ListContacts
            // 
            this.ListContacts.FormattingEnabled = true;
            this.ListContacts.ItemHeight = 17;
            this.ListContacts.Location = new System.Drawing.Point(359, 26);
            this.ListContacts.Name = "ListContacts";
            this.ListContacts.Size = new System.Drawing.Size(337, 395);
            this.ListContacts.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 436);
            this.Controls.Add(this.ListContacts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PhoneTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Name);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Name;
        private Label email;
        private Label Phone;
        private TextBox NameTxt;
        private TextBox emailTxt;
        private TextBox PhoneTxt;
        private Button button1;
        private ListBox ListContacts;
    }
}