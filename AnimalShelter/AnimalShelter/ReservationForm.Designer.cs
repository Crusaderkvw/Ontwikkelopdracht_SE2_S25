﻿namespace AnimalShelter
{
    partial class ReservationForm
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
            this.btnReserve = new System.Windows.Forms.Button();
            this.cmbBoxAnimalSelection = new System.Windows.Forms.ComboBox();
            this.cmbBoxCustomerSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(104, 93);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(103, 39);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.Text = "Reserveer";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // cmbBoxAnimalSelection
            // 
            this.cmbBoxAnimalSelection.FormattingEnabled = true;
            this.cmbBoxAnimalSelection.Location = new System.Drawing.Point(86, 12);
            this.cmbBoxAnimalSelection.Name = "cmbBoxAnimalSelection";
            this.cmbBoxAnimalSelection.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxAnimalSelection.TabIndex = 2;
            // 
            // cmbBoxCustomerSelection
            // 
            this.cmbBoxCustomerSelection.FormattingEnabled = true;
            this.cmbBoxCustomerSelection.Location = new System.Drawing.Point(86, 55);
            this.cmbBoxCustomerSelection.Name = "cmbBoxCustomerSelection";
            this.cmbBoxCustomerSelection.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxCustomerSelection.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Animal: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer: ";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 165);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxCustomerSelection);
            this.Controls.Add(this.cmbBoxAnimalSelection);
            this.Controls.Add(this.btnReserve);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.ComboBox cmbBoxAnimalSelection;
        private System.Windows.Forms.ComboBox cmbBoxCustomerSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}