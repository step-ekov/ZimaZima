namespace test_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataSet1 = new test_2.DataSet1();
            this.regestratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regestratTableAdapter = new test_2.DataSet1TableAdapters.RegestratTableAdapter();
            this.regestratBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.designer1 = new test_2.designer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.loginDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regestratBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regestratBindingSource1)).BeginInit();
            this.designer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regestratBindingSource
            // 
            this.regestratBindingSource.DataMember = "Regestrat";
            this.regestratBindingSource.DataSource = this.dataSet1;
            // 
            // regestratTableAdapter
            // 
            this.regestratTableAdapter.ClearBeforeFill = true;
            // 
            // regestratBindingSource1
            // 
            this.regestratBindingSource1.DataMember = "Regestrat";
            this.regestratBindingSource1.DataSource = this.dataSet1;
            // 
            // designer1
            // 
            this.designer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.designer1.ColorFillFirst = System.Drawing.Color.White;
            this.designer1.ColorFillSecond = System.Drawing.Color.DodgerBlue;
            this.designer1.Controls.Add(this.dataGridView2);
            this.designer1.Controls.Add(this.label8);
            this.designer1.Controls.Add(this.label7);
            this.designer1.Controls.Add(this.label6);
            this.designer1.Controls.Add(this.button5);
            this.designer1.Controls.Add(this.label5);
            this.designer1.Controls.Add(this.dataGridView1);
            this.designer1.Controls.Add(this.button4);
            this.designer1.Controls.Add(this.button3);
            this.designer1.Controls.Add(this.label4);
            this.designer1.Controls.Add(this.button2);
            this.designer1.Controls.Add(this.button1);
            this.designer1.Controls.Add(this.textBox2);
            this.designer1.Controls.Add(this.textBox1);
            this.designer1.Controls.Add(this.label3);
            this.designer1.Controls.Add(this.label1);
            this.designer1.Controls.Add(this.label2);
            this.designer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.designer1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.designer1.Location = new System.Drawing.Point(0, 0);
            this.designer1.Name = "designer1";
            this.designer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.designer1.Size = new System.Drawing.Size(886, 503);
            this.designer1.TabIndex = 1;
            this.designer1.Paint += new System.Windows.Forms.PaintEventHandler(this.designer1_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.regestratBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(629, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(245, 104);
            this.dataGridView2.TabIndex = 26;
            // 
            // loginDataGridViewTextBoxColumn1
            // 
            this.loginDataGridViewTextBoxColumn1.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn1.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn1.Name = "loginDataGridViewTextBoxColumn1";
            // 
            // passwordDataGridViewTextBoxColumn1
            // 
            this.passwordDataGridViewTextBoxColumn1.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn1.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn1.Name = "passwordDataGridViewTextBoxColumn1";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(661, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 126);
            this.label8.TabIndex = 25;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(492, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 126);
            this.label7.TabIndex = 24;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(287, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 116);
            this.label6.TabIndex = 23;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(492, 454);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 37);
            this.button5.TabIndex = 22;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(116, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 116);
            this.label5.TabIndex = 21;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.regestratBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(629, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 95);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(393, 454);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 37);
            this.button4.TabIndex = 19;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::test_2.Properties.Resources.image_BhhCuuKiu_transformed__1_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(5, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 27);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(141, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Вход";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(116, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Зарегистрироваться";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(39, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(146, 212);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.Click += new System.EventHandler(this.textBox2_TextChanged_1);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(146, 152);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(35, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(35, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(224, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ZimaZima";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // loginDataGridViewTextBoxColumn2
            // 
            this.loginDataGridViewTextBoxColumn2.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn2.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn2.Name = "loginDataGridViewTextBoxColumn2";
            // 
            // passwordDataGridViewTextBoxColumn2
            // 
            this.passwordDataGridViewTextBoxColumn2.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn2.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn2.Name = "passwordDataGridViewTextBoxColumn2";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn3
            // 
            this.loginDataGridViewTextBoxColumn3.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn3.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn3.Name = "loginDataGridViewTextBoxColumn3";
            // 
            // passwordDataGridViewTextBoxColumn3
            // 
            this.passwordDataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn3.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn3.Name = "passwordDataGridViewTextBoxColumn3";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(886, 503);
            this.Controls.Add(this.designer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regestratBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regestratBindingSource1)).EndInit();
            this.designer1.ResumeLayout(false);
            this.designer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private designer designer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource regestratBindingSource;
        private DataSet1TableAdapters.RegestratTableAdapter regestratTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource regestratBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
    }
}

