﻿namespace WinFormsStaffEditor
{
    partial class MainForm
    {



        protected DataGridView MainDataGreed { get; set; }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            topPanel = new Panel();
            topSearhEditPanel = new Panel();
            pictureBox1 = new PictureBox();
            textBoxSearch = new TextBox();
            searchImage = new PictureBox();
            synchronization = new PictureBox();
            staffPicture = new PictureBox();
            staffLabel = new Label();
            dataGridView1 = new DataGridView();
            editorPanel = new Panel();
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
            label2 = new Label();
            editorLabel = new Label();
            editorPicture = new PictureBox();
            panel4 = new Panel();
            SaveChangesButton = new Button();
            EditStuffButton = new Button();
            DeleteStuffButton = new Button();
            NewStuffButton = new Button();
            label9 = new Label();
            topPanel.SuspendLayout();
            topSearhEditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)synchronization).BeginInit();
            ((System.ComponentModel.ISupportInitialize)staffPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            editorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editorPicture).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(237, 197, 171);
            topPanel.Controls.Add(topSearhEditPanel);
            topPanel.Controls.Add(staffPicture);
            topPanel.Controls.Add(staffLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(874, 73);
            topPanel.TabIndex = 0;
            // 
            // topSearhEditPanel
            // 
            topSearhEditPanel.BackColor = Color.FromArgb(231, 234, 239);
            topSearhEditPanel.Controls.Add(pictureBox1);
            topSearhEditPanel.Controls.Add(textBoxSearch);
            topSearhEditPanel.Controls.Add(searchImage);
            topSearhEditPanel.Controls.Add(synchronization);
            topSearhEditPanel.Location = new Point(523, 12);
            topSearhEditPanel.Name = "topSearhEditPanel";
            topSearhEditPanel.Size = new Size(339, 46);
            topSearhEditPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(181, 8);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(150, 32);
            textBoxSearch.TabIndex = 3;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // searchImage
            // 
            searchImage.Image = (Image)resources.GetObject("searchImage.Image");
            searchImage.Location = new Point(143, 8);
            searchImage.Name = "searchImage";
            searchImage.Size = new Size(32, 32);
            searchImage.SizeMode = PictureBoxSizeMode.StretchImage;
            searchImage.TabIndex = 2;
            searchImage.TabStop = false;
            // 
            // synchronization
            // 
            synchronization.Image = (Image)resources.GetObject("synchronization.Image");
            synchronization.Location = new Point(75, 8);
            synchronization.Name = "synchronization";
            synchronization.Size = new Size(32, 32);
            synchronization.SizeMode = PictureBoxSizeMode.StretchImage;
            synchronization.TabIndex = 1;
            synchronization.TabStop = false;
            synchronization.Click += synchronization_Click;
            // 
            // staffPicture
            // 
            staffPicture.Image = (Image)resources.GetObject("staffPicture.Image");
            staffPicture.Location = new Point(153, 20);
            staffPicture.Name = "staffPicture";
            staffPicture.Size = new Size(32, 32);
            staffPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            staffPicture.TabIndex = 1;
            staffPicture.TabStop = false;
            // 
            // staffLabel
            // 
            staffLabel.AutoSize = true;
            staffLabel.Font = new Font("Century Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            staffLabel.Location = new Point(12, 24);
            staffLabel.Name = "staffLabel";
            staffLabel.Size = new Size(135, 28);
            staffLabel.TabIndex = 0;
            staffLabel.Text = "Персонал";
            staffLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(55, 116, 91);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(853, 334);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // editorPanel
            // 
            editorPanel.BackColor = Color.FromArgb(33, 112, 116);
            editorPanel.Controls.Add(PositionField);
            editorPanel.Controls.Add(EmploymentDateField);
            editorPanel.Controls.Add(BirthDateField);
            editorPanel.Controls.Add(SnilsField);
            editorPanel.Controls.Add(label8);
            editorPanel.Controls.Add(label7);
            editorPanel.Controls.Add(PatronymicField);
            editorPanel.Controls.Add(SurnameField);
            editorPanel.Controls.Add(NameField);
            editorPanel.Controls.Add(label5);
            editorPanel.Controls.Add(label6);
            editorPanel.Controls.Add(label4);
            editorPanel.Controls.Add(label3);
            editorPanel.Controls.Add(label2);
            editorPanel.Controls.Add(editorLabel);
            editorPanel.Controls.Add(editorPicture);
            editorPanel.Location = new Point(12, 452);
            editorPanel.Name = "editorPanel";
            editorPanel.Size = new Size(667, 223);
            editorPanel.TabIndex = 2;
            // 
            // PositionField
            // 
            PositionField.Location = new Point(461, 105);
            PositionField.Name = "PositionField";
            PositionField.Size = new Size(195, 23);
            PositionField.TabIndex = 17;
            // 
            // EmploymentDateField
            // 
            EmploymentDateField.Location = new Point(461, 143);
            EmploymentDateField.Name = "EmploymentDateField";
            EmploymentDateField.Size = new Size(195, 23);
            EmploymentDateField.TabIndex = 16;
            // 
            // BirthDateField
            // 
            BirthDateField.Location = new Point(116, 187);
            BirthDateField.Name = "BirthDateField";
            BirthDateField.Size = new Size(195, 23);
            BirthDateField.TabIndex = 15;
            // 
            // SnilsField
            // 
            SnilsField.Location = new Point(461, 67);
            SnilsField.Name = "SnilsField";
            SnilsField.Size = new Size(195, 23);
            SnilsField.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            label8.Location = new Point(341, 145);
            label8.Name = "label8";
            label8.Size = new Size(114, 18);
            label8.TabIndex = 9;
            label8.Text = "Дата приёма:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            label7.Location = new Point(361, 105);
            label7.Name = "label7";
            label7.Size = new Size(94, 18);
            label7.TabIndex = 8;
            label7.Text = "Должность:";
            // 
            // PatronymicField
            // 
            PatronymicField.Location = new Point(116, 146);
            PatronymicField.Name = "PatronymicField";
            PatronymicField.Size = new Size(195, 23);
            PatronymicField.TabIndex = 13;
            // 
            // SurnameField
            // 
            SurnameField.Location = new Point(116, 67);
            SurnameField.Name = "SurnameField";
            SurnameField.Size = new Size(195, 23);
            SurnameField.TabIndex = 12;
            // 
            // NameField
            // 
            NameField.Location = new Point(116, 105);
            NameField.Name = "NameField";
            NameField.Size = new Size(195, 23);
            NameField.TabIndex = 11;
            // 
            // label5
            // 
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            label5.Location = new Point(18, 172);
            label5.Name = "label5";
            label5.Size = new Size(102, 38);
            label5.TabIndex = 6;
            label5.Text = "Дата рождения:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            label6.Location = new Point(387, 69);
            label6.Name = "label6";
            label6.Size = new Size(68, 18);
            label6.TabIndex = 7;
            label6.Text = "СНИЛС:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            label4.Location = new Point(29, 148);
            label4.Name = "label4";
            label4.Size = new Size(81, 18);
            label4.TabIndex = 5;
            label4.Text = "Отчество:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            label3.Location = new Point(30, 67);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 4;
            label3.Text = "Фамилия:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            label2.Location = new Point(67, 110);
            label2.Name = "label2";
            label2.Size = new Size(43, 18);
            label2.TabIndex = 3;
            label2.Text = "Имя:";
            // 
            // editorLabel
            // 
            editorLabel.AutoSize = true;
            editorLabel.Font = new Font("Century Gothic", 18F, FontStyle.Italic);
            editorLabel.Location = new Point(68, 13);
            editorLabel.Name = "editorLabel";
            editorLabel.Size = new Size(105, 28);
            editorLabel.TabIndex = 1;
            editorLabel.Text = "Запись:";
            // 
            // editorPicture
            // 
            editorPicture.Image = (Image)resources.GetObject("editorPicture.Image");
            editorPicture.Location = new Point(3, 0);
            editorPicture.Name = "editorPicture";
            editorPicture.Size = new Size(64, 64);
            editorPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            editorPicture.TabIndex = 0;
            editorPicture.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(177, 171, 212);
            panel4.Controls.Add(SaveChangesButton);
            panel4.Controls.Add(EditStuffButton);
            panel4.Controls.Add(DeleteStuffButton);
            panel4.Controls.Add(NewStuffButton);
            panel4.Location = new Point(686, 500);
            panel4.Name = "panel4";
            panel4.Size = new Size(176, 175);
            panel4.TabIndex = 3;
            // 
            // SaveChangesButton
            // 
            SaveChangesButton.BackColor = Color.FromArgb(231, 234, 239);
            SaveChangesButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            SaveChangesButton.Location = new Point(11, 130);
            SaveChangesButton.Name = "SaveChangesButton";
            SaveChangesButton.Size = new Size(153, 37);
            SaveChangesButton.TabIndex = 3;
            SaveChangesButton.Text = "Сохранить";
            SaveChangesButton.UseVisualStyleBackColor = false;
            SaveChangesButton.Click += SaveChangesButton_Click;
            // 
            // EditStuffButton
            // 
            EditStuffButton.BackColor = Color.FromArgb(231, 234, 239);
            EditStuffButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            EditStuffButton.Location = new Point(11, 91);
            EditStuffButton.Name = "EditStuffButton";
            EditStuffButton.Size = new Size(153, 37);
            EditStuffButton.TabIndex = 2;
            EditStuffButton.Text = "Изменить";
            EditStuffButton.UseVisualStyleBackColor = false;
            EditStuffButton.Click += EditStuffButton_Click;
            // 
            // DeleteStuffButton
            // 
            DeleteStuffButton.BackColor = Color.FromArgb(231, 234, 239);
            DeleteStuffButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            DeleteStuffButton.Location = new Point(11, 52);
            DeleteStuffButton.Name = "DeleteStuffButton";
            DeleteStuffButton.Size = new Size(153, 37);
            DeleteStuffButton.TabIndex = 1;
            DeleteStuffButton.Text = "Удалить";
            DeleteStuffButton.UseVisualStyleBackColor = false;
            DeleteStuffButton.Click += DeleteStuffButton_Click;
            // 
            // NewStuffButton
            // 
            NewStuffButton.BackColor = Color.FromArgb(231, 234, 239);
            NewStuffButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            NewStuffButton.Location = new Point(11, 13);
            NewStuffButton.Name = "NewStuffButton";
            NewStuffButton.Size = new Size(153, 37);
            NewStuffButton.TabIndex = 0;
            NewStuffButton.Text = "Новая запись";
            NewStuffButton.UseVisualStyleBackColor = false;
            NewStuffButton.Click += NewStuffButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic);
            label9.Location = new Point(686, 465);
            label9.Name = "label9";
            label9.Size = new Size(176, 18);
            label9.TabIndex = 4;
            label9.Text = "Управление записями";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(139, 157, 119);
            ClientSize = new Size(874, 687);
            Controls.Add(label9);
            Controls.Add(panel4);
            Controls.Add(editorPanel);
            Controls.Add(dataGridView1);
            Controls.Add(topPanel);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            topSearhEditPanel.ResumeLayout(false);
            topSearhEditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)synchronization).EndInit();
            ((System.ComponentModel.ISupportInitialize)staffPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            editorPanel.ResumeLayout(false);
            editorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)editorPicture).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel topPanel;
        private Label staffLabel;
        private Panel topSearhEditPanel;
        private PictureBox searchImage;
        private PictureBox synchronization;
        private TextBox textBoxSearch;
        private DataGridView dataGridView1;
        private Panel editorPanel;
        private Label editorLabel;
        private PictureBox editorPicture;
        private Panel panel4;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox NameField;
        private TextBox PatronymicField;
        private TextBox SurnameField;
        private TextBox SnilsField;
        private TextBox EmploymentDateField;
        private TextBox BirthDateField;
        private TextBox PositionField;
        private Label label9;
        private Button SaveChangesButton;
        private Button EditStuffButton;
        private Button DeleteStuffButton;
        private Button NewStuffButton;
        private PictureBox staffPicture;
        private PictureBox pictureBox1;
    }
}
