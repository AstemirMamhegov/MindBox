namespace Roguelike
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numUpDownHP = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.numUpDownDPS = new System.Windows.Forms.NumericUpDown();
            this.labelDPS = new System.Windows.Forms.Label();
            this.txtBxDiff = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDPS)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hero",
            "Boss"});
            this.comboBox1.Location = new System.Drawing.Point(59, 39);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(8, 265);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(145, 55);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(411, 39);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(713, 180);
            this.listBox1.TabIndex = 2;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(183, 118);
            this.txtBxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(120, 22);
            this.txtBxName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(52, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "HealthPoints";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(39, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "CharacterType";
            // 
            // numUpDownHP
            // 
            this.numUpDownHP.Location = new System.Drawing.Point(183, 152);
            this.numUpDownHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUpDownHP.Maximum = new decimal(new int[] {
            11000,
            0,
            0,
            0});
            this.numUpDownHP.Name = "numUpDownHP";
            this.numUpDownHP.Size = new System.Drawing.Size(120, 22);
            this.numUpDownHP.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "DD",
            "H",
            "T",
            "B"});
            this.comboBox2.Location = new System.Drawing.Point(182, 223);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 10;
            // 
            // numUpDownDPS
            // 
            this.numUpDownDPS.Location = new System.Drawing.Point(182, 188);
            this.numUpDownDPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUpDownDPS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownDPS.Name = "numUpDownDPS";
            this.numUpDownDPS.Size = new System.Drawing.Size(120, 22);
            this.numUpDownDPS.TabIndex = 11;
            // 
            // labelDPS
            // 
            this.labelDPS.AutoSize = true;
            this.labelDPS.BackColor = System.Drawing.Color.Transparent;
            this.labelDPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDPS.Location = new System.Drawing.Point(12, 190);
            this.labelDPS.Name = "labelDPS";
            this.labelDPS.Size = new System.Drawing.Size(140, 20);
            this.labelDPS.TabIndex = 12;
            this.labelDPS.Text = "DamgePerSecond";
            // 
            // txtBxDiff
            // 
            this.txtBxDiff.Location = new System.Drawing.Point(541, 227);
            this.txtBxDiff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxDiff.Name = "txtBxDiff";
            this.txtBxDiff.Size = new System.Drawing.Size(100, 22);
            this.txtBxDiff.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(407, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "DifficultDungeon";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(159, 265);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(144, 55);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Удалить выделенного";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1125, 538);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBxDiff);
            this.Controls.Add(this.labelDPS);
            this.Controls.Add(this.numUpDownDPS);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.numUpDownHP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUpDownHP;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown numUpDownDPS;
        private System.Windows.Forms.Label labelDPS;
        private System.Windows.Forms.TextBox txtBxDiff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemove;
    }
}

