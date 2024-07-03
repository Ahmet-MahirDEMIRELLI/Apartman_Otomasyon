namespace ApartmanOtomasyon
{
    partial class Expenses
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
            this.checkBoxElectric = new System.Windows.Forms.CheckBox();
            this.checkBoxWater = new System.Windows.Forms.CheckBox();
            this.checkBoxElevator = new System.Windows.Forms.CheckBox();
            this.checkBoxCleaning = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxExpenses = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxExpenses.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxElectric
            // 
            this.checkBoxElectric.AutoSize = true;
            this.checkBoxElectric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxElectric.Location = new System.Drawing.Point(38, 19);
            this.checkBoxElectric.Name = "checkBoxElectric";
            this.checkBoxElectric.Size = new System.Drawing.Size(88, 24);
            this.checkBoxElectric.TabIndex = 0;
            this.checkBoxElectric.Text = "Elektrik";
            this.checkBoxElectric.UseVisualStyleBackColor = true;
            // 
            // checkBoxWater
            // 
            this.checkBoxWater.AutoSize = true;
            this.checkBoxWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxWater.Location = new System.Drawing.Point(38, 61);
            this.checkBoxWater.Name = "checkBoxWater";
            this.checkBoxWater.Size = new System.Drawing.Size(50, 24);
            this.checkBoxWater.TabIndex = 1;
            this.checkBoxWater.Text = "Su";
            this.checkBoxWater.UseVisualStyleBackColor = true;
            // 
            // checkBoxElevator
            // 
            this.checkBoxElevator.AutoSize = true;
            this.checkBoxElevator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxElevator.Location = new System.Drawing.Point(38, 103);
            this.checkBoxElevator.Name = "checkBoxElevator";
            this.checkBoxElevator.Size = new System.Drawing.Size(94, 24);
            this.checkBoxElevator.TabIndex = 2;
            this.checkBoxElevator.Text = "Asansör";
            this.checkBoxElevator.UseVisualStyleBackColor = true;
            // 
            // checkBoxCleaning
            // 
            this.checkBoxCleaning.AutoSize = true;
            this.checkBoxCleaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxCleaning.Location = new System.Drawing.Point(38, 146);
            this.checkBoxCleaning.Name = "checkBoxCleaning";
            this.checkBoxCleaning.Size = new System.Drawing.Size(92, 24);
            this.checkBoxCleaning.TabIndex = 3;
            this.checkBoxCleaning.Text = "Temizlik";
            this.checkBoxCleaning.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(258, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(258, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tarih:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.Location = new System.Drawing.Point(350, 50);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(246, 26);
            this.numericUpDown1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(350, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAdd.Location = new System.Drawing.Point(377, 146);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(194, 31);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Ekle";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxExpenses
            // 
            this.groupBoxExpenses.Controls.Add(this.label2);
            this.groupBoxExpenses.Controls.Add(this.buttonAdd);
            this.groupBoxExpenses.Controls.Add(this.checkBoxElectric);
            this.groupBoxExpenses.Controls.Add(this.dateTimePicker1);
            this.groupBoxExpenses.Controls.Add(this.checkBoxWater);
            this.groupBoxExpenses.Controls.Add(this.numericUpDown1);
            this.groupBoxExpenses.Controls.Add(this.checkBoxElevator);
            this.groupBoxExpenses.Controls.Add(this.checkBoxCleaning);
            this.groupBoxExpenses.Controls.Add(this.label1);
            this.groupBoxExpenses.Location = new System.Drawing.Point(57, 12);
            this.groupBoxExpenses.Name = "groupBoxExpenses";
            this.groupBoxExpenses.Size = new System.Drawing.Size(665, 190);
            this.groupBoxExpenses.TabIndex = 9;
            this.groupBoxExpenses.TabStop = false;
            this.groupBoxExpenses.Text = "Giderler";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(60, 217);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 225);
            this.listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(319, 217);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(145, 225);
            this.listBox2.TabIndex = 11;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(577, 217);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(145, 225);
            this.listBox3.TabIndex = 12;
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBoxExpenses);
            this.Name = "Expenses";
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.Expenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxExpenses.ResumeLayout(false);
            this.groupBoxExpenses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxElectric;
        private System.Windows.Forms.CheckBox checkBoxWater;
        private System.Windows.Forms.CheckBox checkBoxElevator;
        private System.Windows.Forms.CheckBox checkBoxCleaning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxExpenses;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}