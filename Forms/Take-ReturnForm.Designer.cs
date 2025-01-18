using FormBiblioteka.Modules;

namespace FormBiblioteka
{
    partial class Take_ReturnForm
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
            OperationTypeInput = new ComboBox();
            TitleTextLabel = new Label();
            label1 = new Label();
            BookInput = new ComboBox();
            NumberOfBooksInput = new NumericUpDown();
            label2 = new Label();
            HeaderLabel = new Label();
            SubmitButton = new Button();
            BackButton = new Button();
            panel1 = new Panel();
            ErrorMessageBox = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            BooksLeftLabel = new Label();
            BooksTakenLabel = new Label();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)NumberOfBooksInput).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // OperationTypeInput
            // 
            OperationTypeInput.DropDownStyle = ComboBoxStyle.DropDownList;
            OperationTypeInput.Font = new Font("Times New Roman", 12F);
            OperationTypeInput.FormattingEnabled = true;
            OperationTypeInput.Items.AddRange(new object[] { "Take", "Return" });
            OperationTypeInput.Location = new Point(124, 32);
            OperationTypeInput.Margin = new Padding(3, 2, 3, 2);
            OperationTypeInput.MaxDropDownItems = 10;
            OperationTypeInput.Name = "OperationTypeInput";
            OperationTypeInput.Size = new Size(248, 27);
            OperationTypeInput.TabIndex = 0;
            // 
            // TitleTextLabel
            // 
            TitleTextLabel.AutoSize = true;
            TitleTextLabel.Font = new Font("Times New Roman", 16F);
            TitleTextLabel.Location = new Point(13, 32);
            TitleTextLabel.Name = "TitleTextLabel";
            TitleTextLabel.Size = new Size(105, 25);
            TitleTextLabel.TabIndex = 2;
            TitleTextLabel.Text = "Operation:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F);
            label1.Location = new Point(53, 70);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 4;
            label1.Text = "Book:";
            // 
            // BookInput
            // 
            BookInput.DropDownStyle = ComboBoxStyle.DropDownList;
            BookInput.Font = new Font("Times New Roman", 12F);
            BookInput.FormattingEnabled = true;
            BookInput.Location = new Point(124, 70);
            BookInput.Margin = new Padding(3, 2, 3, 2);
            BookInput.Name = "BookInput";
            BookInput.Size = new Size(248, 27);
            BookInput.TabIndex = 3;
            BookInput.SelectedIndexChanged += DisplayBooksAmounts;
            // 
            // NumberOfBooksInput
            // 
            NumberOfBooksInput.BorderStyle = BorderStyle.FixedSingle;
            NumberOfBooksInput.Font = new Font("Times New Roman", 12F);
            NumberOfBooksInput.Location = new Point(124, 107);
            NumberOfBooksInput.Margin = new Padding(3, 2, 3, 2);
            NumberOfBooksInput.Name = "NumberOfBooksInput";
            NumberOfBooksInput.Size = new Size(248, 26);
            NumberOfBooksInput.TabIndex = 5;
            NumberOfBooksInput.ThousandsSeparator = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16F);
            label2.Location = new Point(30, 108);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 6;
            label2.Text = "Amount:";
            // 
            // HeaderLabel
            // 
            HeaderLabel.Font = new Font("Times New Roman", 24F);
            HeaderLabel.Location = new Point(6, 6);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(389, 38);
            HeaderLabel.TabIndex = 11;
            HeaderLabel.Text = "Take or Return a Book";
            HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = SystemColors.ControlLight;
            SubmitButton.FlatStyle = FlatStyle.Popup;
            SubmitButton.Font = new Font("Times New Roman", 12F);
            SubmitButton.Location = new Point(629, 370);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(132, 35);
            SubmitButton.TabIndex = 14;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButtonClick;
            // 
            // BackButton
            // 
            BackButton.AllowDrop = true;
            BackButton.BackColor = SystemColors.ControlLight;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Times New Roman", 16F);
            BackButton.Location = new Point(8, 7);
            BackButton.Margin = new Padding(0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(48, 41);
            BackButton.TabIndex = 18;
            BackButton.Text = "<";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButtonClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(ErrorMessageBox);
            panel1.Controls.Add(NumberOfBooksInput);
            panel1.Controls.Add(OperationTypeInput);
            panel1.Controls.Add(TitleTextLabel);
            panel1.Controls.Add(BookInput);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(193, 130);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 176);
            panel1.TabIndex = 19;
            // 
            // ErrorMessageBox
            // 
            ErrorMessageBox.Location = new Point(13, 144);
            ErrorMessageBox.Name = "ErrorMessageBox";
            ErrorMessageBox.Size = new Size(359, 23);
            ErrorMessageBox.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(HeaderLabel);
            panel2.Location = new Point(193, 71);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 55);
            panel2.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label5);
            panel4.Location = new Point(-2, -2);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(402, 55);
            panel4.TabIndex = 21;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 24F);
            label5.Location = new Point(6, 6);
            label5.Name = "label5";
            label5.Size = new Size(389, 38);
            label5.TabIndex = 11;
            label5.Text = "Take or Return a Book";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BooksLeftLabel
            // 
            BooksLeftLabel.Font = new Font("Times New Roman", 12F);
            BooksLeftLabel.Location = new Point(-2, 0);
            BooksLeftLabel.Name = "BooksLeftLabel";
            BooksLeftLabel.Size = new Size(195, 51);
            BooksLeftLabel.TabIndex = 7;
            BooksLeftLabel.Text = "Books Left: 0";
            BooksLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BooksTakenLabel
            // 
            BooksTakenLabel.Font = new Font("Times New Roman", 12F);
            BooksTakenLabel.Location = new Point(205, 0);
            BooksTakenLabel.Name = "BooksTakenLabel";
            BooksTakenLabel.Size = new Size(195, 51);
            BooksTakenLabel.TabIndex = 8;
            BooksTakenLabel.Text = "Books Taken: 0";
            BooksTakenLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(BooksLeftLabel);
            panel3.Controls.Add(BooksTakenLabel);
            panel3.Location = new Point(193, 310);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(402, 55);
            panel3.TabIndex = 21;
            // 
            // Take_ReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 411);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(BackButton);
            Controls.Add(SubmitButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Take_ReturnForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Take_ReturnForm";
            Load += TakeReturnFormLoad;
            ((System.ComponentModel.ISupportInitialize)NumberOfBooksInput).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox OperationTypeInput;
        private Label TitleTextLabel;
        private Label label1;
        private ComboBox BookInput;
        private NumericUpDown NumberOfBooksInput;
        private Label label2;
        private Label HeaderLabel;
        private Button SubmitButton;
        private Button BackButton;
        private Panel panel1;
        private Panel panel2;
        private Label BooksLeftLabel;
        private Label BooksTakenLabel;
        private Panel panel4;
        private Label label5;
        private Panel panel3;
        private Label ErrorMessageBox;
    }
}