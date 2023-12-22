namespace pr333
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
            this.bExit = new System.Windows.Forms.Button();
            this.BtnFinalBill = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Baggage = new System.Windows.Forms.CheckBox();
            this.Carload = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ThereBack = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DataBack = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DataThere = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textFlight = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.RetiredPeopleQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RetiredPeople = new System.Windows.Forms.CheckBox();
            this.ChildQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Child = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPatronymic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.AutoSize = true;
            this.bExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bExit.BackColor = System.Drawing.Color.IndianRed;
            this.bExit.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.bExit.FlatAppearance.BorderSize = 2;
            this.bExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bExit.Location = new System.Drawing.Point(671, 16);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(22, 23);
            this.bExit.TabIndex = 15;
            this.bExit.Text = "x";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // BtnFinalBill
            // 
            this.BtnFinalBill.AutoSize = true;
            this.BtnFinalBill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnFinalBill.Location = new System.Drawing.Point(313, 400);
            this.BtnFinalBill.Name = "BtnFinalBill";
            this.BtnFinalBill.Size = new System.Drawing.Size(92, 23);
            this.BtnFinalBill.TabIndex = 14;
            this.BtnFinalBill.Text = "Итоговый счёт";
            this.BtnFinalBill.UseVisualStyleBackColor = false;
            this.BtnFinalBill.Click += new System.EventHandler(this.BtnFinalBill_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Baggage);
            this.groupBox2.Controls.Add(this.Carload);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ThereBack);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textFlight);
            this.groupBox2.Location = new System.Drawing.Point(26, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 217);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Рейс";
            // 
            // Baggage
            // 
            this.Baggage.AutoSize = true;
            this.Baggage.Location = new System.Drawing.Point(183, 58);
            this.Baggage.Name = "Baggage";
            this.Baggage.Size = new System.Drawing.Size(58, 17);
            this.Baggage.TabIndex = 5;
            this.Baggage.Text = "Багаж";
            this.Baggage.UseVisualStyleBackColor = true;
            // 
            // Carload
            // 
            this.Carload.FormattingEnabled = true;
            this.Carload.Items.AddRange(new object[] {
            "Купе",
            "СВ",
            "Плацкарт",
            "Для инвалидов"});
            this.Carload.Location = new System.Drawing.Point(114, 181);
            this.Carload.Name = "Carload";
            this.Carload.Size = new System.Drawing.Size(169, 21);
            this.Carload.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Тип вагона";
            // 
            // ThereBack
            // 
            this.ThereBack.AutoSize = true;
            this.ThereBack.Location = new System.Drawing.Point(65, 58);
            this.ThereBack.Name = "ThereBack";
            this.ThereBack.Size = new System.Drawing.Size(103, 17);
            this.ThereBack.TabIndex = 0;
            this.ThereBack.Text = "Туда и обратно";
            this.ThereBack.UseVisualStyleBackColor = true;
            this.ThereBack.CheckedChanged += new System.EventHandler(this.ThereBack_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.DataBack);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.DataThere);
            this.groupBox3.Location = new System.Drawing.Point(44, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 76);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дата и время";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Обратно";
            // 
            // DataBack
            // 
            this.DataBack.Enabled = false;
            this.DataBack.Location = new System.Drawing.Point(54, 45);
            this.DataBack.Name = "DataBack";
            this.DataBack.Size = new System.Drawing.Size(173, 20);
            this.DataBack.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Туда";
            // 
            // DataThere
            // 
            this.DataThere.Location = new System.Drawing.Point(54, 19);
            this.DataThere.Name = "DataThere";
            this.DataThere.Size = new System.Drawing.Size(173, 20);
            this.DataThere.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Рейс";
            // 
            // textFlight
            // 
            this.textFlight.FormattingEnabled = true;
            this.textFlight.Items.AddRange(new object[] {
            "Moscow - Ekaterinburg",
            "Moscow - Ivangorod",
            "Moscow - Saint-Petersburg",
            "Moscow - Magadan"});
            this.textFlight.Location = new System.Drawing.Point(98, 20);
            this.textFlight.Name = "textFlight";
            this.textFlight.Size = new System.Drawing.Size(169, 21);
            this.textFlight.TabIndex = 4;
            this.textFlight.SelectedIndexChanged += new System.EventHandler(this.textFlight_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.RetiredPeopleQuantity);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.RetiredPeople);
            this.groupBox4.Controls.Add(this.ChildQuantity);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.Child);
            this.groupBox4.Location = new System.Drawing.Point(376, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 173);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Количество пасажиров";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Количество пасажиров";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 22);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 17);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Пасажир";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // RetiredPeopleQuantity
            // 
            this.RetiredPeopleQuantity.Location = new System.Drawing.Point(140, 140);
            this.RetiredPeopleQuantity.Name = "RetiredPeopleQuantity";
            this.RetiredPeopleQuantity.Size = new System.Drawing.Size(91, 20);
            this.RetiredPeopleQuantity.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Количество пенсионеров";
            // 
            // RetiredPeople
            // 
            this.RetiredPeople.AutoSize = true;
            this.RetiredPeople.Location = new System.Drawing.Point(10, 118);
            this.RetiredPeople.Name = "RetiredPeople";
            this.RetiredPeople.Size = new System.Drawing.Size(90, 17);
            this.RetiredPeople.TabIndex = 10;
            this.RetiredPeople.Text = "Пенсионеры";
            this.RetiredPeople.UseVisualStyleBackColor = true;
            // 
            // ChildQuantity
            // 
            this.ChildQuantity.Enabled = false;
            this.ChildQuantity.Location = new System.Drawing.Point(142, 88);
            this.ChildQuantity.Name = "ChildQuantity";
            this.ChildQuantity.Size = new System.Drawing.Size(91, 20);
            this.ChildQuantity.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(29, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Количество детей";
            // 
            // Child
            // 
            this.Child.AutoSize = true;
            this.Child.Location = new System.Drawing.Point(12, 67);
            this.Child.Name = "Child";
            this.Child.Size = new System.Drawing.Size(52, 17);
            this.Child.TabIndex = 8;
            this.Child.Text = "Дети";
            this.Child.UseVisualStyleBackColor = true;
            this.Child.CheckedChanged += new System.EventHandler(this.Child_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textSurname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textPatronymic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 105);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Покупатель";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(123, 19);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(171, 20);
            this.textSurname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Отчество";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(123, 45);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(171, 20);
            this.textName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Имя";
            // 
            // textPatronymic
            // 
            this.textPatronymic.Location = new System.Drawing.Point(123, 71);
            this.textPatronymic.Name = "textPatronymic";
            this.textPatronymic.Size = new System.Drawing.Size(171, 20);
            this.textPatronymic.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "ЖДКасса";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 435);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.BtnFinalBill);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button BtnFinalBill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox Child;
        private System.Windows.Forms.TextBox ChildQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox Baggage;
        private System.Windows.Forms.ComboBox Carload;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ThereBack;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DataBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DataThere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox textFlight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPatronymic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox RetiredPeople;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox RetiredPeopleQuantity;
        private System.Windows.Forms.Label label11;
    }
}

