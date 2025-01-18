using FormBiblioteka.Modules;

namespace FormBiblioteka
{
    partial class HeroPage
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
            AddBookButton = new Button();
            TakeReturnFormButton = new Button();
            ListOfBooksButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            CartButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddBookButton
            // 
            AddBookButton.BackColor = SystemColors.ControlLight;
            AddBookButton.FlatStyle = FlatStyle.Popup;
            AddBookButton.Font = new Font("Times New Roman", 16F);
            AddBookButton.Location = new Point(50, 225);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(175, 50);
            AddBookButton.TabIndex = 2;
            AddBookButton.Text = "Add a Book";
            AddBookButton.UseVisualStyleBackColor = false;
            AddBookButton.Click += AddBookButtonClick;
            // 
            // TakeReturnFormButton
            // 
            TakeReturnFormButton.BackColor = SystemColors.ControlLight;
            TakeReturnFormButton.FlatStyle = FlatStyle.Popup;
            TakeReturnFormButton.Font = new Font("Times New Roman", 16F);
            TakeReturnFormButton.Location = new Point(550, 225);
            TakeReturnFormButton.Name = "TakeReturnFormButton";
            TakeReturnFormButton.Size = new Size(175, 50);
            TakeReturnFormButton.TabIndex = 0;
            TakeReturnFormButton.Text = "Take/Return";
            TakeReturnFormButton.UseVisualStyleBackColor = false;
            TakeReturnFormButton.Click += TakeReturnFormButtonClick;
            // 
            // ListOfBooksButton
            // 
            ListOfBooksButton.BackColor = SystemColors.ControlLight;
            ListOfBooksButton.FlatStyle = FlatStyle.Popup;
            ListOfBooksButton.Font = new Font("Times New Roman", 16F);
            ListOfBooksButton.Location = new Point(301, 225);
            ListOfBooksButton.Name = "ListOfBooksButton";
            ListOfBooksButton.Size = new Size(175, 50);
            ListOfBooksButton.TabIndex = 1;
            ListOfBooksButton.Text = "List of Books";
            ListOfBooksButton.UseVisualStyleBackColor = false;
            ListOfBooksButton.Click += ListOfBooksButtonClick;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(50, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 78);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Times New Roman", 32F);
            label1.Location = new Point(-2, -2);
            label1.Name = "label1";
            label1.Size = new Size(676, 77);
            label1.TabIndex = 0;
            label1.Text = "Biblioteka";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CartButton
            // 
            CartButton.BackColor = SystemColors.ControlLight;
            CartButton.FlatStyle = FlatStyle.Popup;
            CartButton.Font = new Font("Times New Roman", 16F);
            CartButton.Location = new Point(301, 298);
            CartButton.Name = "CartButton";
            CartButton.Size = new Size(175, 50);
            CartButton.TabIndex = 4;
            CartButton.Text = "View Cart";
            CartButton.UseVisualStyleBackColor = false;
            CartButton.Click += CheckCartFormButtonClick;
            // 
            // HeroPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 411);
            Controls.Add(CartButton);
            Controls.Add(panel1);
            Controls.Add(ListOfBooksButton);
            Controls.Add(TakeReturnFormButton);
            Controls.Add(AddBookButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HeroPage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteka";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button AddBookButton;
        private Button TakeReturnFormButton;
        private Button ListOfBooksButton;
        private Panel panel1;
        private Label label1;
        private Button CartButton;
    }
}
