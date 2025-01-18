using System.Windows.Forms;
using System.Xml.Linq;
using System.Net.Mime;
using FormBiblioteka.Modules;

namespace FormBiblioteka
{
    partial class AddBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleTextBox = new TextBox();
            TitleTextLabel = new Label();
            AuthorTextLabel = new Label();
            AuthorTextBox = new TextBox();
            ReleaseDateTextLabel = new Label();
            ReleaseDateTextBox = new TextBox();
            PageCountTextLabel = new Label();
            PageCountTextBox = new TextBox();
            AmountTextLabel = new Label();
            AmountTextBox = new TextBox();
            HeaderLabel = new Label();
            SubmitButton = new Button();
            BackButton = new Button();
            ErrorLabel = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // TitleTextBox
            // 
            TitleTextBox.BackColor = SystemColors.ButtonHighlight;
            TitleTextBox.Location = new Point(213, 17);
            TitleTextBox.Margin = new Padding(3, 4, 3, 4);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(295, 27);
            TitleTextBox.TabIndex = 0;
            // 
            // TitleTextLabel
            // 
            TitleTextLabel.AutoSize = true;
            TitleTextLabel.Font = new Font("Times New Roman", 12F);
            TitleTextLabel.Location = new Point(144, 17);
            TitleTextLabel.Name = "TitleTextLabel";
            TitleTextLabel.Size = new Size(53, 22);
            TitleTextLabel.TabIndex = 1;
            TitleTextLabel.Text = "Title:";
            // 
            // AuthorTextLabel
            // 
            AuthorTextLabel.AutoSize = true;
            AuthorTextLabel.Font = new Font("Times New Roman", 12F);
            AuthorTextLabel.Location = new Point(127, 56);
            AuthorTextLabel.Name = "AuthorTextLabel";
            AuthorTextLabel.Size = new Size(70, 22);
            AuthorTextLabel.TabIndex = 3;
            AuthorTextLabel.Text = "Author:";
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(213, 56);
            AuthorTextBox.Margin = new Padding(3, 4, 3, 4);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(295, 27);
            AuthorTextBox.TabIndex = 2;
            // 
            // ReleaseDateTextLabel
            // 
            ReleaseDateTextLabel.AutoSize = true;
            ReleaseDateTextLabel.Font = new Font("Times New Roman", 12F);
            ReleaseDateTextLabel.Location = new Point(76, 95);
            ReleaseDateTextLabel.Name = "ReleaseDateTextLabel";
            ReleaseDateTextLabel.Size = new Size(121, 22);
            ReleaseDateTextLabel.TabIndex = 5;
            ReleaseDateTextLabel.Text = "Release Date:";
            // 
            // ReleaseDateTextBox
            // 
            ReleaseDateTextBox.Location = new Point(213, 95);
            ReleaseDateTextBox.Margin = new Padding(3, 4, 3, 4);
            ReleaseDateTextBox.Name = "ReleaseDateTextBox";
            ReleaseDateTextBox.Size = new Size(295, 27);
            ReleaseDateTextBox.TabIndex = 4;
            // 
            // PageCountTextLabel
            // 
            PageCountTextLabel.AutoSize = true;
            PageCountTextLabel.Font = new Font("Times New Roman", 12F);
            PageCountTextLabel.Location = new Point(92, 134);
            PageCountTextLabel.Name = "PageCountTextLabel";
            PageCountTextLabel.Size = new Size(105, 22);
            PageCountTextLabel.TabIndex = 7;
            PageCountTextLabel.Text = "Page Count:";
            // 
            // PageCountTextBox
            // 
            PageCountTextBox.Location = new Point(213, 134);
            PageCountTextBox.Margin = new Padding(3, 4, 3, 4);
            PageCountTextBox.Name = "PageCountTextBox";
            PageCountTextBox.Size = new Size(295, 27);
            PageCountTextBox.TabIndex = 6;
            // 
            // AmountTextLabel
            // 
            AmountTextLabel.AutoSize = true;
            AmountTextLabel.Font = new Font("Times New Roman", 12F);
            AmountTextLabel.Location = new Point(120, 172);
            AmountTextLabel.Name = "AmountTextLabel";
            AmountTextLabel.Size = new Size(77, 22);
            AmountTextLabel.TabIndex = 9;
            AmountTextLabel.Text = "Amount:";
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(213, 172);
            AmountTextBox.Margin = new Padding(3, 4, 3, 4);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(295, 27);
            AmountTextBox.TabIndex = 8;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Times New Roman", 32F);
            HeaderLabel.Location = new Point(184, 11);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(278, 61);
            HeaderLabel.TabIndex = 10;
            HeaderLabel.Text = "Add a book";
            HeaderLabel.Click += HeaderLabel_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = SystemColors.ControlLight;
            SubmitButton.FlatStyle = FlatStyle.Popup;
            SubmitButton.Location = new Point(719, 493);
            SubmitButton.Margin = new Padding(3, 4, 3, 4);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(151, 47);
            SubmitButton.TabIndex = 11;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButtonClick;
            // 
            // BackButton
            // 
            BackButton.AllowDrop = true;
            BackButton.BackColor = SystemColors.ControlLight;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Arial", 16F);
            BackButton.Location = new Point(9, 9);
            BackButton.Margin = new Padding(0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(55, 55);
            BackButton.TabIndex = 12;
            BackButton.Text = "<";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButtonClick;
            // 
            // ErrorLabel
            // 
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(343, 347);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(160, 31);
            ErrorLabel.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(HeaderLabel);
            panel1.Location = new Point(157, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 85);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(ReleaseDateTextBox);
            panel2.Controls.Add(TitleTextBox);
            panel2.Controls.Add(TitleTextLabel);
            panel2.Controls.Add(AuthorTextBox);
            panel2.Controls.Add(AuthorTextLabel);
            panel2.Controls.Add(AmountTextLabel);
            panel2.Controls.Add(ReleaseDateTextLabel);
            panel2.Controls.Add(AmountTextBox);
            panel2.Controls.Add(PageCountTextBox);
            panel2.Controls.Add(PageCountTextLabel);
            panel2.Location = new Point(157, 204);
            panel2.Name = "panel2";
            panel2.Size = new Size(615, 216);
            panel2.TabIndex = 15;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(882, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ErrorLabel);
            Controls.Add(BackButton);
            Controls.Add(SubmitButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddBooks";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBooks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label AuthorTextLabel;
        private TextBox TitleTextBox;
        private Label TitleTextLabel;
        private TextBox AuthorTextBox;
        private Label ReleaseDateTextLabel;
        private TextBox ReleaseDateTextBox;
        private Label PageCountTextLabel;
        private TextBox PageCountTextBox;
        private Label AmountTextLabel;
        private TextBox AmountTextBox;
        private Label HeaderLabel;
        private Button SubmitButton;
        private Button BackButton;
        private Label ErrorLabel;
        private Panel panel1;
        private Panel panel2;
    }
}