﻿using System.Windows.Forms;

namespace VashiteKinti.Forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.depositNameTextBox = new System.Windows.Forms.TextBox();
            this.bankComboBox = new System.Windows.Forms.ComboBox();
            this.interestTypeComboBox = new System.Windows.Forms.ComboBox();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.minSumNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.interestNumUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSumNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interestNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 86);
            this.label1.TabIndex = 1;
            this.label1.Text = "Банкови Депозити";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(624, 408);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Име на банка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Име на депозит";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Минимална сума";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Лихва";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Изплащане на лихва";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Валута";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(624, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Update table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // depositNameTextBox
            // 
            this.depositNameTextBox.Location = new System.Drawing.Point(16, 291);
            this.depositNameTextBox.Name = "depositNameTextBox";
            this.depositNameTextBox.Size = new System.Drawing.Size(243, 20);
            this.depositNameTextBox.TabIndex = 11;
            this.depositNameTextBox.Click += new System.EventHandler(this.depositNameTextBox_Clicked);
            this.depositNameTextBox.LostFocus += new System.EventHandler(this.depositNameTextBox_LostFocus);
            // 
            // bankComboBox
            // 
            this.bankComboBox.FormattingEnabled = true;
            this.bankComboBox.Location = new System.Drawing.Point(16, 244);
            this.bankComboBox.Name = "bankComboBox";
            this.bankComboBox.Size = new System.Drawing.Size(243, 21);
            this.bankComboBox.TabIndex = 16;
            // 
            // interestTypeComboBox
            // 
            this.interestTypeComboBox.FormattingEnabled = true;
            this.interestTypeComboBox.Location = new System.Drawing.Point(16, 428);
            this.interestTypeComboBox.Name = "interestTypeComboBox";
            this.interestTypeComboBox.Size = new System.Drawing.Size(243, 21);
            this.interestTypeComboBox.TabIndex = 17;
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Location = new System.Drawing.Point(16, 474);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(243, 21);
            this.currencyComboBox.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(15, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(100, 527);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 20;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(184, 527);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 40);
            this.button4.TabIndex = 21;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // minSumNumUpDown
            // 
            this.minSumNumUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.minSumNumUpDown.Location = new System.Drawing.Point(16, 338);
            this.minSumNumUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.minSumNumUpDown.Name = "minSumNumUpDown";
            this.minSumNumUpDown.Size = new System.Drawing.Size(243, 20);
            this.minSumNumUpDown.TabIndex = 22;
            // 
            // interestNumUpDown
            // 
            this.interestNumUpDown.DecimalPlaces = 5;
            this.interestNumUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.interestNumUpDown.Location = new System.Drawing.Point(16, 382);
            this.interestNumUpDown.Name = "interestNumUpDown";
            this.interestNumUpDown.Size = new System.Drawing.Size(243, 20);
            this.interestNumUpDown.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 583);
            this.Controls.Add(this.interestNumUpDown);
            this.Controls.Add(this.minSumNumUpDown);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.currencyComboBox);
            this.Controls.Add(this.interestTypeComboBox);
            this.Controls.Add(this.bankComboBox);
            this.Controls.Add(this.depositNameTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSumNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interestNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private TextBox depositNameTextBox;
        private ComboBox bankComboBox;
        private ComboBox interestTypeComboBox;
        private ComboBox currencyComboBox;
        private Button button2;
        private Button button3;
        private Button button4;
        private NumericUpDown minSumNumUpDown;
        private NumericUpDown interestNumUpDown;
    }
}

