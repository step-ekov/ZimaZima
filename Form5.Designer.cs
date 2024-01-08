namespace test_2
{
    partial class Form5
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
            this.designer1 = new test_2.designer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.roundButton2 = new test_2.RoundButton();
            this.roundButton1 = new test_2.RoundButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.designer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // designer1
            // 
            this.designer1.BackColor = System.Drawing.Color.Transparent;
            this.designer1.ColorFillFirst = System.Drawing.Color.White;
            this.designer1.ColorFillSecond = System.Drawing.Color.DodgerBlue;
            this.designer1.Controls.Add(this.comboBox1);
            this.designer1.Controls.Add(this.label7);
            this.designer1.Controls.Add(this.label6);
            this.designer1.Controls.Add(this.button1);
            this.designer1.Controls.Add(this.roundButton2);
            this.designer1.Controls.Add(this.roundButton1);
            this.designer1.Controls.Add(this.label5);
            this.designer1.Controls.Add(this.dateTimePicker1);
            this.designer1.Controls.Add(this.label4);
            this.designer1.Controls.Add(this.textBox3);
            this.designer1.Controls.Add(this.textBox2);
            this.designer1.Controls.Add(this.textBox1);
            this.designer1.Controls.Add(this.label3);
            this.designer1.Controls.Add(this.label2);
            this.designer1.Controls.Add(this.label1);
            this.designer1.Controls.Add(this.radioButton1);
            this.designer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.designer1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.designer1.Location = new System.Drawing.Point(0, 0);
            this.designer1.Name = "designer1";
            this.designer1.Size = new System.Drawing.Size(446, 496);
            this.designer1.TabIndex = 19;
            this.designer1.Paint += new System.Windows.Forms.PaintEventHandler(this.designer1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "С 11:00 - 15:00 (1 чел.)",
            "С 15:00 - 21:00 (3 чел.)",
            "С 12:00 - 16:00 (1 чел.)",
            "С 9:30 - 13:30 (5 людей)"});
            this.comboBox1.Location = new System.Drawing.Point(205, 386);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(41, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 18);
            this.label7.TabIndex = 36;
            this.label7.Text = "Выберете время";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(271, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 39);
            this.label6.TabIndex = 33;
            this.label6.Text = "Взятие напитков из бара, \r\nинструктор,персональная \r\nкомната(сауна, хамам и т.д)";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::test_2.Properties.Resources.icons8_вопрос_48_photo_resizer1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(247, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.label6_Click);
            this.button1.MouseLeave += new System.EventHandler(this.label6VS);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton2.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.roundButton2.ButtonBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundButton2.ButtonHighlightColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundButton2.ButtonHighlightColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.roundButton2.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton2.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.roundButton2.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.roundButton2.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.roundButton2.ButtonRoundRadius = 30;
            this.roundButton2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton2.ForeColor = System.Drawing.Color.Black;
            this.roundButton2.Location = new System.Drawing.Point(106, 440);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(103, 40);
            this.roundButton2.TabIndex = 31;
            this.roundButton2.Text = "Вернуться";
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton1.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.roundButton1.ButtonBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundButton1.ButtonHighlightColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundButton1.ButtonHighlightColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.roundButton1.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton1.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.roundButton1.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.roundButton1.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.roundButton1.ButtonRoundRadius = 30;
            this.roundButton1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton1.ForeColor = System.Drawing.Color.Black;
            this.roundButton1.Location = new System.Drawing.Point(227, 440);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(103, 40);
            this.roundButton1.TabIndex = 30;
            this.roundButton1.Text = "Подтвердить";
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(41, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Выберете дату";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 333);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 21);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(155, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Оформление";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(173, 198);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 26);
            this.textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 142);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 26);
            this.textBox2.TabIndex = 23;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 26);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Эл. Почта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "ФИО";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(44, 266);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(211, 26);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Дополнительные услуги";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 496);
            this.Controls.Add(this.designer1);
            this.Name = "Form5";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.designer1.ResumeLayout(false);
            this.designer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private designer designer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private RoundButton roundButton1;
        private RoundButton roundButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}