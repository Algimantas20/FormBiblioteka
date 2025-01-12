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
            BackButton = new Button();
            SubmitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)NumberOfBooksInput).BeginInit();
            SuspendLayout();
            // 
            // OperationTypeInput
            // 
            OperationTypeInput.DropDownStyle = ComboBoxStyle.DropDownList;
            OperationTypeInput.FormattingEnabled = true;
            OperationTypeInput.Items.AddRange(new object[] { "Take", "Return" });
            OperationTypeInput.Location = new Point(185, 121);
            OperationTypeInput.Margin = new Padding(3, 2, 3, 2);
            OperationTypeInput.MaxDropDownItems = 10;
            OperationTypeInput.Name = "OperationTypeInput";
            OperationTypeInput.Size = new Size(133, 23);
            OperationTypeInput.TabIndex = 0;
            // 
            // TitleTextLabel
            // 
            TitleTextLabel.AutoSize = true;
            TitleTextLabel.Font = new Font("Segoe UI", 12F);
            TitleTextLabel.Location = new Point(96, 123);
            TitleTextLabel.Name = "TitleTextLabel";
            TitleTextLabel.Size = new Size(83, 21);
            TitleTextLabel.TabIndex = 2;
            TitleTextLabel.Text = "Operation:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(131, 146);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 4;
            label1.Text = "Book:";
            // 
            // BookInput
            // 
            BookInput.DropDownStyle = ComboBoxStyle.DropDownList;
            BookInput.FormattingEnabled = true;
            BookInput.Location = new Point(185, 146);
            BookInput.Margin = new Padding(3, 2, 3, 2);
            BookInput.Name = "BookInput";
            BookInput.Size = new Size(133, 23);
            BookInput.TabIndex = 3;
            // 
            // NumberOfBooksInput
            // 
            NumberOfBooksInput.BorderStyle = BorderStyle.FixedSingle;
            NumberOfBooksInput.Location = new Point(185, 172);
            NumberOfBooksInput.Margin = new Padding(3, 2, 3, 2);
            NumberOfBooksInput.Name = "NumberOfBooksInput";
            NumberOfBooksInput.Size = new Size(132, 23);
            NumberOfBooksInput.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(110, 172);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 6;
            label2.Text = "Amount:";
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 24F);
            HeaderLabel.Location = new Point(59, 58);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(336, 45);
            HeaderLabel.TabIndex = 11;
            HeaderLabel.Text = "Take or Return a Book:";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(0, 0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(83, 30);
            BackButton.TabIndex = 13;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButtonClick;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(640, 389);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(132, 35);
            SubmitButton.TabIndex = 14;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButtonClick;
            // 
            // Take_ReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 436);
            Controls.Add(SubmitButton);
            Controls.Add(BackButton);
            Controls.Add(HeaderLabel);
            Controls.Add(label2);
            Controls.Add(NumberOfBooksInput);
            Controls.Add(label1);
            Controls.Add(BookInput);
            Controls.Add(TitleTextLabel);
            Controls.Add(OperationTypeInput);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Take_ReturnForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Take_ReturnForm";
            ((System.ComponentModel.ISupportInitialize)NumberOfBooksInput).EndInit();
            Load += TakeReturnFormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox OperationTypeInput;
        private Label TitleTextLabel;
        private Label label1;
        private ComboBox BookInput;
        private NumericUpDown NumberOfBooksInput;
        private Label label2;
        private Label HeaderLabel;
        private Button BackButton;
        private Button SubmitButton;
    }
}