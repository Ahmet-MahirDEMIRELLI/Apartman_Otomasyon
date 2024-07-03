namespace ApartmanOtomasyon
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
            this.buttonIncomes = new System.Windows.Forms.Button();
            this.buttonExpenses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIncomes
            // 
            this.buttonIncomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIncomes.Location = new System.Drawing.Point(138, 71);
            this.buttonIncomes.Name = "buttonIncomes";
            this.buttonIncomes.Size = new System.Drawing.Size(158, 298);
            this.buttonIncomes.TabIndex = 0;
            this.buttonIncomes.Text = "Gelirler";
            this.buttonIncomes.UseVisualStyleBackColor = true;
            this.buttonIncomes.Click += new System.EventHandler(this.buttonIncomes_Click);
            // 
            // buttonExpenses
            // 
            this.buttonExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonExpenses.Location = new System.Drawing.Point(468, 71);
            this.buttonExpenses.Name = "buttonExpenses";
            this.buttonExpenses.Size = new System.Drawing.Size(158, 298);
            this.buttonExpenses.TabIndex = 1;
            this.buttonExpenses.Text = "Giderler";
            this.buttonExpenses.UseVisualStyleBackColor = true;
            this.buttonExpenses.Click += new System.EventHandler(this.buttonExpenses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExpenses);
            this.Controls.Add(this.buttonIncomes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIncomes;
        private System.Windows.Forms.Button buttonExpenses;
    }
}

