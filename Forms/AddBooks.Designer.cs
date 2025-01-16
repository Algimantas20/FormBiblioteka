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
            ExitButton = new Button();
            SuspendLayout();
            // 
            // TitleTextBox
            // 
            TitleTextBox.BackColor = SystemColors.ButtonHighlight;
            TitleTextBox.BorderStyle = BorderStyle.FixedSingle;
            TitleTextBox.Location = new Point(247, 157);
            TitleTextBox.Margin = new Padding(3, 4, 3, 4);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(295, 27);
            TitleTextBox.TabIndex = 0;
            // 
            // TitleTextLabel
            // 
            TitleTextLabel.AutoSize = true;
            TitleTextLabel.Font = new Font("Segoe UI", 12F);
            TitleTextLabel.Location = new Point(192, 157);
            TitleTextLabel.Name = "TitleTextLabel";
            TitleTextLabel.Size = new Size(53, 28);
            TitleTextLabel.TabIndex = 1;
            TitleTextLabel.Text = "Title:";
            // 
            // AuthorTextLabel
            // 
            AuthorTextLabel.AutoSize = true;
            AuthorTextLabel.Font = new Font("Segoe UI", 12F);
            AuthorTextLabel.Location = new Point(170, 196);
            AuthorTextLabel.Name = "AuthorTextLabel";
            AuthorTextLabel.Size = new Size(77, 28);
            AuthorTextLabel.TabIndex = 3;
            AuthorTextLabel.Text = "Author:";
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(247, 196);
            AuthorTextBox.Margin = new Padding(3, 4, 3, 4);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(295, 27);
            AuthorTextBox.TabIndex = 2;
            // 
            // ReleaseDateTextLabel
            // 
            ReleaseDateTextLabel.AutoSize = true;
            ReleaseDateTextLabel.Font = new Font("Segoe UI", 12F);
            ReleaseDateTextLabel.Location = new Point(123, 235);
            ReleaseDateTextLabel.Name = "ReleaseDateTextLabel";
            ReleaseDateTextLabel.Size = new Size(126, 28);
            ReleaseDateTextLabel.TabIndex = 5;
            ReleaseDateTextLabel.Text = "Release Date:";
            // 
            // ReleaseDateTextBox
            // 
            ReleaseDateTextBox.Location = new Point(247, 235);
            ReleaseDateTextBox.Margin = new Padding(3, 4, 3, 4);
            ReleaseDateTextBox.Name = "ReleaseDateTextBox";
            ReleaseDateTextBox.Size = new Size(295, 27);
            ReleaseDateTextBox.TabIndex = 4;
            // 
            // PageCountTextLabel
            // 
            PageCountTextLabel.AutoSize = true;
            PageCountTextLabel.Font = new Font("Segoe UI", 12F);
            PageCountTextLabel.Location = new Point(135, 273);
            PageCountTextLabel.Name = "PageCountTextLabel";
            PageCountTextLabel.Size = new Size(116, 28);
            PageCountTextLabel.TabIndex = 7;
            PageCountTextLabel.Text = "Page Count:";
            // 
            // PageCountTextBox
            // 
            PageCountTextBox.Location = new Point(247, 273);
            PageCountTextBox.Margin = new Padding(3, 4, 3, 4);
            PageCountTextBox.Name = "PageCountTextBox";
            PageCountTextBox.Size = new Size(295, 27);
            PageCountTextBox.TabIndex = 6;
            // 
            // AmountTextLabel
            // 
            AmountTextLabel.AutoSize = true;
            AmountTextLabel.Font = new Font("Segoe UI", 12F);
            AmountTextLabel.Location = new Point(161, 312);
            AmountTextLabel.Name = "AmountTextLabel";
            AmountTextLabel.Size = new Size(87, 28);
            AmountTextLabel.TabIndex = 9;
            AmountTextLabel.Text = "Amount:";
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(247, 312);
            AmountTextBox.Margin = new Padding(3, 4, 3, 4);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(295, 27);
            AmountTextBox.TabIndex = 8;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 24F);
            HeaderLabel.Location = new Point(107, 77);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(238, 54);
            HeaderLabel.TabIndex = 10;
            HeaderLabel.Text = "Add a book:";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(731, 519);
            SubmitButton.Margin = new Padding(3, 4, 3, 4);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(151, 47);
            SubmitButton.TabIndex = 11;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButtonClick;
            // 
            // BackButton
            // 
            BackButton.AllowDrop = true;
            BackButton.Font = new Font("Arial", 16F);
            BackButton.Location = new Point(9, 9);
            BackButton.Margin = new Padding(0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(55, 55);
            BackButton.TabIndex = 12;
            BackButton.Text = "<";
            BackButton.UseVisualStyleBackColor = true;
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
            // ExitButton
            // 
            ExitButton.AllowDrop = true;
            ExitButton.Font = new Font("Arial", 12F);
            ExitButton.Location = new Point(827, 9);
            ExitButton.Margin = new Padding(0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(55, 55);
            ExitButton.TabIndex = 14;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ButtonLogic.ExitButtonClick;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(896, 581);
            Controls.Add(ExitButton);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Button ExitButton;
    }
}