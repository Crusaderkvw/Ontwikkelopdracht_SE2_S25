namespace AnimalShelter
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
            this.lstBoxOverview = new System.Windows.Forms.ListBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnReserveAnimal = new System.Windows.Forms.Button();
            this.btnSellAnimal = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxOverview
            // 
            this.lstBoxOverview.FormattingEnabled = true;
            this.lstBoxOverview.Location = new System.Drawing.Point(12, 165);
            this.lstBoxOverview.Name = "lstBoxOverview";
            this.lstBoxOverview.Size = new System.Drawing.Size(372, 160);
            this.lstBoxOverview.TabIndex = 0;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(13, 13);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(80, 40);
            this.btnAddAnimal.TabIndex = 1;
            this.btnAddAnimal.Text = "Voer dier in";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnReserveAnimal
            // 
            this.btnReserveAnimal.Location = new System.Drawing.Point(13, 59);
            this.btnReserveAnimal.Name = "btnReserveAnimal";
            this.btnReserveAnimal.Size = new System.Drawing.Size(80, 40);
            this.btnReserveAnimal.TabIndex = 2;
            this.btnReserveAnimal.Text = "Reservering plaatsen";
            this.btnReserveAnimal.UseVisualStyleBackColor = true;
            this.btnReserveAnimal.Click += new System.EventHandler(this.btnReserveAnimal_Click);
            // 
            // btnSellAnimal
            // 
            this.btnSellAnimal.Location = new System.Drawing.Point(99, 13);
            this.btnSellAnimal.Name = "btnSellAnimal";
            this.btnSellAnimal.Size = new System.Drawing.Size(80, 40);
            this.btnSellAnimal.TabIndex = 3;
            this.btnSellAnimal.Text = "Verkoop dier";
            this.btnSellAnimal.UseVisualStyleBackColor = true;
            this.btnSellAnimal.Click += new System.EventHandler(this.btnSellAnimal_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Location = new System.Drawing.Point(12, 136);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(103, 23);
            this.btnRefreshList.TabIndex = 4;
            this.btnRefreshList.Text = "Refresh lijst";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 340);
            this.Controls.Add(this.btnRefreshList);
            this.Controls.Add(this.btnSellAnimal);
            this.Controls.Add(this.btnReserveAnimal);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.lstBoxOverview);
            this.Name = "Form1";
            this.Text = "Animal Shelter //TODO: input<Name>";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxOverview;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnReserveAnimal;
        private System.Windows.Forms.Button btnSellAnimal;
        private System.Windows.Forms.Button btnRefreshList;
    }
}

