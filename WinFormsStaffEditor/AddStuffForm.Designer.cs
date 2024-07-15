namespace WinFormsStaffEditor
{
    partial class AddStuffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStuffForm));
            panel1 = new Panel();
            panel2 = new Panel();
            eraser = new PictureBox();
            info = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            PositionField = new TextBox();
            EmploymentDateField = new TextBox();
            BirthDateField = new TextBox();
            SnilsField = new TextBox();
            label8 = new Label();
            label7 = new Label();
            PatronymicField = new TextBox();
            SurnameField = new TextBox();
            NameField = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label9 = new Label();
            SaveChangesButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eraser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(237, 197, 171);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 92);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(231, 234, 239);
            panel2.Controls.Add(eraser);
            panel2.Controls.Add(info);
            panel2.Location = new Point(443, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(119, 58);
            panel2.TabIndex = 3;
            // 
            // eraser
            // 
            eraser.Image = (Image)resources.GetObject("eraser.Image");
            eraser.Location = new Point(69, 14);
            eraser.Name = "eraser";
            eraser.Size = new Size(32, 32);
            eraser.SizeMode = PictureBoxSizeMode.AutoSize;
            eraser.TabIndex = 1;
            eraser.TabStop = false;
            // 
            // info
            // 
            info.Image = (Image)resources.GetObject("info.Image");
            info.Location = new Point(16, 14);
            info.Name = "info";
            info.Size = new Size(32, 32);
            info.SizeMode = PictureBoxSizeMode.AutoSize;
            info.TabIndex = 0;
            info.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            label2.Location = new Point(114, 46);
            label2.Name = "label2";
            label2.Size = new Size(85, 18);
            label2.TabIndex = 2;
            label2.Text = "Персонал";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Italic);
            label1.Location = new Point(114, 18);
            label1.Name = "label1";
            label1.Size = new Size(234, 28);
            label1.TabIndex = 1;
            label1.Text = "Создание записи:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PositionField
            // 
            PositionField.Location = new Point(204, 332);
            PositionField.Name = "PositionField";
            PositionField.Size = new Size(195, 23);
            PositionField.TabIndex = 33;
            // 
            // EmploymentDateField
            // 
            EmploymentDateField.Location = new Point(204, 302);
            EmploymentDateField.Name = "EmploymentDateField";
            EmploymentDateField.Size = new Size(195, 23);
            EmploymentDateField.TabIndex = 32;
            // 
            // BirthDateField
            // 
            BirthDateField.Location = new Point(204, 272);
            BirthDateField.Name = "BirthDateField";
            BirthDateField.Size = new Size(195, 23);
            BirthDateField.TabIndex = 31;
            // 
            // SnilsField
            // 
            SnilsField.Location = new Point(204, 243);
            SnilsField.Name = "SnilsField";
            SnilsField.Size = new Size(195, 23);
            SnilsField.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            label8.Location = new Point(84, 304);
            label8.Name = "label8";
            label8.Size = new Size(114, 18);
            label8.TabIndex = 25;
            label8.Text = "Дата приёма:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            label7.Location = new Point(104, 332);
            label7.Name = "label7";
            label7.Size = new Size(94, 18);
            label7.TabIndex = 24;
            label7.Text = "Должность:";
            // 
            // PatronymicField
            // 
            PatronymicField.Location = new Point(204, 213);
            PatronymicField.Name = "PatronymicField";
            PatronymicField.Size = new Size(195, 23);
            PatronymicField.TabIndex = 29;
            // 
            // SurnameField
            // 
            SurnameField.Location = new Point(204, 183);
            SurnameField.Name = "SurnameField";
            SurnameField.Size = new Size(195, 23);
            SurnameField.TabIndex = 28;
            // 
            // NameField
            // 
            NameField.Location = new Point(204, 153);
            NameField.Name = "NameField";
            NameField.Size = new Size(195, 23);
            NameField.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            label5.Location = new Point(70, 272);
            label5.Name = "label5";
            label5.Size = new Size(128, 18);
            label5.TabIndex = 22;
            label5.Text = "Дата рождения:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            label6.Location = new Point(130, 245);
            label6.Name = "label6";
            label6.Size = new Size(68, 18);
            label6.TabIndex = 23;
            label6.Text = "СНИЛС:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            label4.Location = new Point(117, 215);
            label4.Name = "label4";
            label4.Size = new Size(81, 18);
            label4.TabIndex = 21;
            label4.Text = "Отчество:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            label3.Location = new Point(118, 185);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 20;
            label3.Text = "Фамилия:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            label9.Location = new Point(155, 155);
            label9.Name = "label9";
            label9.Size = new Size(43, 18);
            label9.TabIndex = 19;
            label9.Text = "Имя:";
            // 
            // SaveChangesButton
            // 
            SaveChangesButton.BackColor = Color.FromArgb(231, 234, 239);
            SaveChangesButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            SaveChangesButton.Location = new Point(419, 401);
            SaveChangesButton.Name = "SaveChangesButton";
            SaveChangesButton.Size = new Size(153, 37);
            SaveChangesButton.TabIndex = 4;
            SaveChangesButton.Text = "Сохранить";
            SaveChangesButton.UseVisualStyleBackColor = false;
            SaveChangesButton.Click += SaveChangesButton_Click;
            // 
            // AddStuffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(139, 157, 119);
            ClientSize = new Size(584, 450);
            Controls.Add(SaveChangesButton);
            Controls.Add(PositionField);
            Controls.Add(EmploymentDateField);
            Controls.Add(BirthDateField);
            Controls.Add(SnilsField);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(PatronymicField);
            Controls.Add(SurnameField);
            Controls.Add(NameField);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(panel1);
            Name = "AddStuffForm";
            Text = "AddStuffForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eraser).EndInit();
            ((System.ComponentModel.ISupportInitialize)info).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox eraser;
        private PictureBox info;
        private TextBox PositionField;
        private TextBox EmploymentDateField;
        private TextBox BirthDateField;
        private TextBox SnilsField;
        private Label label8;
        private Label label7;
        private TextBox PatronymicField;
        private TextBox SurnameField;
        private TextBox NameField;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label9;
        private Button SaveChangesButton;
    }
}