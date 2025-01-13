using System.Windows.Forms;
using System.Xml.Linq;
using System.Net.Mime;

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
            SuspendLayout();
            // 
            // TitleTextBox
            // 
            TitleTextBox.BackColor = SystemColors.ButtonHighlight;
            TitleTextBox.Location = new Point(181, 118);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(259, 23);
            TitleTextBox.TabIndex = 0;
            // 
            // TitleTextLabel
            // 
            TitleTextLabel.AutoSize = true;
            TitleTextLabel.Font = new Font("Segoe UI", 12F);
            TitleTextLabel.Location = new Point(133, 118);
            TitleTextLabel.Name = "TitleTextLabel";
            TitleTextLabel.Size = new Size(42, 21);
            TitleTextLabel.TabIndex = 1;
            TitleTextLabel.Text = "Title:";
            // 
            // AuthorTextLabel
            // 
            AuthorTextLabel.AutoSize = true;
            AuthorTextLabel.Font = new Font("Segoe UI", 12F);
            AuthorTextLabel.Location = new Point(114, 147);
            AuthorTextLabel.Name = "AuthorTextLabel";
            AuthorTextLabel.Size = new Size(61, 21);
            AuthorTextLabel.TabIndex = 3;
            AuthorTextLabel.Text = "Author:";
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(181, 147);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(259, 23);
            AuthorTextBox.TabIndex = 2;
            // 
            // ReleaseDateTextLabel
            // 
            ReleaseDateTextLabel.AutoSize = true;
            ReleaseDateTextLabel.Font = new Font("Segoe UI", 12F);
            ReleaseDateTextLabel.Location = new Point(73, 176);
            ReleaseDateTextLabel.Name = "ReleaseDateTextLabel";
            ReleaseDateTextLabel.Size = new Size(102, 21);
            ReleaseDateTextLabel.TabIndex = 5;
            ReleaseDateTextLabel.Text = "Release Date:";
            // 
            // ReleaseDateTextBox
            // 
            ReleaseDateTextBox.Location = new Point(181, 176);
            ReleaseDateTextBox.Name = "ReleaseDateTextBox";
            ReleaseDateTextBox.Size = new Size(259, 23);
            ReleaseDateTextBox.TabIndex = 4;
            // 
            // PageCountTextLabel
            // 
            PageCountTextLabel.AutoSize = true;
            PageCountTextLabel.Font = new Font("Segoe UI", 12F);
            PageCountTextLabel.Location = new Point(83, 205);
            PageCountTextLabel.Name = "PageCountTextLabel";
            PageCountTextLabel.Size = new Size(92, 21);
            PageCountTextLabel.TabIndex = 7;
            PageCountTextLabel.Text = "Page Count:";
            // 
            // PageCountTextBox
            // 
            PageCountTextBox.Location = new Point(181, 205);
            PageCountTextBox.Name = "PageCountTextBox";
            PageCountTextBox.Size = new Size(259, 23);
            PageCountTextBox.TabIndex = 6;
            // 
            // AmountTextLabel
            // 
            AmountTextLabel.AutoSize = true;
            AmountTextLabel.Font = new Font("Segoe UI", 12F);
            AmountTextLabel.Location = new Point(106, 234);
            AmountTextLabel.Name = "AmountTextLabel";
            AmountTextLabel.Size = new Size(69, 21);
            AmountTextLabel.TabIndex = 9;
            AmountTextLabel.Text = "Amount:";
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(181, 234);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(259, 23);
            AmountTextBox.TabIndex = 8;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 24F);
            HeaderLabel.Location = new Point(59, 58);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(193, 45);
            HeaderLabel.TabIndex = 10;
            HeaderLabel.Text = "Add a book:";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(640, 389);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(132, 35);
            SubmitButton.TabIndex = 11;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButtonClick;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(0, 0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(83, 30);
            BackButton.TabIndex = 12;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButtonClick;
            // 
            // ErrorLabel
            // 
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(300, 260);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(140, 23);
            ErrorLabel.TabIndex = 13;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(784, 436);
            Controls.Add(ErrorLabel);
            Controls.Add(BackButton);
            Controls.Add(SubmitButton);
            Controls.Add(HeaderLabel);
            Controls.Add(AmountTextLabel);
            Controls.Add(AmountTextBox);
            Controls.Add(PageCountTextLabel);
            Controls.Add(PageCountTextBox);
            Controls.Add(ReleaseDateTextLabel);
            Controls.Add(ReleaseDateTextBox);
            Controls.Add(AuthorTextLabel);
            Controls.Add(AuthorTextBox);
            Controls.Add(TitleTextLabel);
            Controls.Add(TitleTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBooks";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBooks";
            ResumeLayout(false);
            PerformLayout();
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
    }
}