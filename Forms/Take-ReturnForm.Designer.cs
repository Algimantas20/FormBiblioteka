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
            ((System.ComponentModel.ISupportInitialize)NumberOfBooksInput).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // OperationTypeInput
            // 
            OperationTypeInput.DropDownStyle = ComboBoxStyle.DropDownList;
            OperationTypeInput.Font = new Font("Times New Roman", 12F);
            OperationTypeInput.FormattingEnabled = true;
            OperationTypeInput.Items.AddRange(new object[] { "Take", "Return" });
            OperationTypeInput.Location = new Point(142, 42);
            OperationTypeInput.MaxDropDownItems = 10;
            OperationTypeInput.Name = "OperationTypeInput";
            OperationTypeInput.Size = new Size(283, 30);
            OperationTypeInput.TabIndex = 0;
            // 
            // TitleTextLabel
            // 
            TitleTextLabel.AutoSize = true;
            TitleTextLabel.Font = new Font("Times New Roman", 16F);
            TitleTextLabel.Location = new Point(7, 39);
            TitleTextLabel.Name = "TitleTextLabel";
            TitleTextLabel.Size = new Size(129, 31);
            TitleTextLabel.TabIndex = 2;
            TitleTextLabel.Text = "Operation:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F);
            label1.Location = new Point(57, 99);
            label1.Name = "label1";
            label1.Size = new Size(79, 31);
            label1.TabIndex = 4;
            label1.Text = "Book:";
            // 
            // BookInput
            // 
            BookInput.DropDownStyle = ComboBoxStyle.DropDownList;
            BookInput.Font = new Font("Times New Roman", 12F);
            BookInput.FormattingEnabled = true;
            BookInput.Location = new Point(142, 102);
            BookInput.Name = "BookInput";
            BookInput.Size = new Size(283, 30);
            BookInput.TabIndex = 3;
            // 
            // NumberOfBooksInput
            // 
            NumberOfBooksInput.BorderStyle = BorderStyle.FixedSingle;
            NumberOfBooksInput.Font = new Font("Times New Roman", 12F);
            NumberOfBooksInput.Location = new Point(142, 171);
            NumberOfBooksInput.Name = "NumberOfBooksInput";
            NumberOfBooksInput.Size = new Size(283, 30);
            NumberOfBooksInput.TabIndex = 5;
            NumberOfBooksInput.ThousandsSeparator = true;
            NumberOfBooksInput.ValueChanged += NumberOfBooksInput_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16F);
            label2.Location = new Point(27, 167);
            label2.Name = "label2";
            label2.Size = new Size(109, 31);
            label2.TabIndex = 6;
            label2.Text = "Amount:";
            // 
            // HeaderLabel
            // 
            HeaderLabel.Font = new Font("Times New Roman", 24F);
            HeaderLabel.Location = new Point(7, 8);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(445, 50);
            HeaderLabel.TabIndex = 11;
            HeaderLabel.Text = "Take or Return a Book";
            HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            HeaderLabel.Click += HeaderLabel_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = SystemColors.ControlLight;
            SubmitButton.FlatStyle = FlatStyle.Popup;
            SubmitButton.Font = new Font("Times New Roman", 12F);
            SubmitButton.Location = new Point(719, 493);
            SubmitButton.Margin = new Padding(3, 4, 3, 4);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(151, 47);
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
            BackButton.Location = new Point(9, 9);
            BackButton.Margin = new Padding(0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(55, 55);
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
            panel1.Location = new Point(221, 173);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 266);
            panel1.TabIndex = 19;
            // 
            // ErrorMessageBox
            // 
            ErrorMessageBox.Location = new Point(27, 220);
            ErrorMessageBox.Name = "ErrorMessageBox";
            ErrorMessageBox.Size = new Size(398, 31);
            ErrorMessageBox.TabIndex = 7;
            ErrorMessageBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(HeaderLabel);
            panel2.Location = new Point(221, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 67);
            panel2.TabIndex = 20;
            // 
            // Take_ReturnForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(BackButton);
            Controls.Add(SubmitButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Take_ReturnForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Take_ReturnForm";
            Load += TakeReturnFormLoad;
            ((System.ComponentModel.ISupportInitialize)NumberOfBooksInput).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
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
        private Label ErrorMessageBox;
    }
}