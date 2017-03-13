namespace AnimalShelter
{
    partial class Dier_Invoer
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
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.cmbBoxSpecies = new System.Windows.Forms.ComboBox();
            this.cmbBoxGender = new System.Windows.Forms.ComboBox();
            this.checkReserved = new System.Windows.Forms.CheckBox();
            this.nupAge = new System.Windows.Forms.NumericUpDown();
            this.nupWeight = new System.Windows.Forms.NumericUpDown();
            this.nupPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(13, 230);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(91, 37);
            this.btnAddAnimal.TabIndex = 0;
            this.btnAddAnimal.Text = "Voer dier in";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label1.Location = new System.Drawing.Point(9, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Diersoort:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label4.Location = new System.Drawing.Point(9, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label6.Location = new System.Drawing.Point(9, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Weight:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label7.Location = new System.Drawing.Point(9, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Price:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(91, 60);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(153, 20);
            this.txtBoxName.TabIndex = 9;
            // 
            // cmbBoxSpecies
            // 
            this.cmbBoxSpecies.FormattingEnabled = true;
            this.cmbBoxSpecies.Location = new System.Drawing.Point(91, 6);
            this.cmbBoxSpecies.Name = "cmbBoxSpecies";
            this.cmbBoxSpecies.Size = new System.Drawing.Size(153, 21);
            this.cmbBoxSpecies.TabIndex = 10;
            // 
            // cmbBoxGender
            // 
            this.cmbBoxGender.FormattingEnabled = true;
            this.cmbBoxGender.Location = new System.Drawing.Point(91, 33);
            this.cmbBoxGender.Name = "cmbBoxGender";
            this.cmbBoxGender.Size = new System.Drawing.Size(153, 21);
            this.cmbBoxGender.TabIndex = 11;
            // 
            // checkReserved
            // 
            this.checkReserved.AutoSize = true;
            this.checkReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.checkReserved.Location = new System.Drawing.Point(91, 179);
            this.checkReserved.Name = "checkReserved";
            this.checkReserved.Size = new System.Drawing.Size(100, 19);
            this.checkReserved.TabIndex = 15;
            this.checkReserved.Text = "Gereserveerd";
            this.checkReserved.UseVisualStyleBackColor = true;
            // 
            // nupAge
            // 
            this.nupAge.Location = new System.Drawing.Point(91, 87);
            this.nupAge.Name = "nupAge";
            this.nupAge.Size = new System.Drawing.Size(153, 20);
            this.nupAge.TabIndex = 16;
            // 
            // nupWeight
            // 
            this.nupWeight.DecimalPlaces = 2;
            this.nupWeight.Location = new System.Drawing.Point(91, 113);
            this.nupWeight.Name = "nupWeight";
            this.nupWeight.Size = new System.Drawing.Size(153, 20);
            this.nupWeight.TabIndex = 17;
            // 
            // nupPrice
            // 
            this.nupPrice.DecimalPlaces = 2;
            this.nupPrice.Location = new System.Drawing.Point(91, 142);
            this.nupPrice.Name = "nupPrice";
            this.nupPrice.Size = new System.Drawing.Size(153, 20);
            this.nupPrice.TabIndex = 18;
            // 
            // Dier_Invoer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 286);
            this.Controls.Add(this.nupPrice);
            this.Controls.Add(this.nupWeight);
            this.Controls.Add(this.nupAge);
            this.Controls.Add(this.checkReserved);
            this.Controls.Add(this.cmbBoxGender);
            this.Controls.Add(this.cmbBoxSpecies);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddAnimal);
            this.Name = "Dier_Invoer";
            this.Text = "Dier_Invoer";
            ((System.ComponentModel.ISupportInitialize)(this.nupAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.ComboBox cmbBoxSpecies;
        private System.Windows.Forms.ComboBox cmbBoxGender;
        private System.Windows.Forms.CheckBox checkReserved;
        private System.Windows.Forms.NumericUpDown nupAge;
        private System.Windows.Forms.NumericUpDown nupWeight;
        private System.Windows.Forms.NumericUpDown nupPrice;
    }
}