namespace PresentationLayer
{
    partial class Form3
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
            this.lblEditUserName = new System.Windows.Forms.Label();
            this.lblEditCategory = new System.Windows.Forms.Label();
            this.lblEditDifficulty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPitanja = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblEditUserName
            // 
            this.lblEditUserName.AutoSize = true;
            this.lblEditUserName.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditUserName.Location = new System.Drawing.Point(63, 53);
            this.lblEditUserName.Name = "lblEditUserName";
            this.lblEditUserName.Size = new System.Drawing.Size(87, 18);
            this.lblEditUserName.TabIndex = 0;
            this.lblEditUserName.Text = "username";
            // 
            // lblEditCategory
            // 
            this.lblEditCategory.AutoSize = true;
            this.lblEditCategory.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCategory.Location = new System.Drawing.Point(247, 53);
            this.lblEditCategory.Name = "lblEditCategory";
            this.lblEditCategory.Size = new System.Drawing.Size(84, 18);
            this.lblEditCategory.TabIndex = 1;
            this.lblEditCategory.Text = "category";
            // 
            // lblEditDifficulty
            // 
            this.lblEditDifficulty.AutoSize = true;
            this.lblEditDifficulty.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditDifficulty.Location = new System.Drawing.Point(420, 53);
            this.lblEditDifficulty.Name = "lblEditDifficulty";
            this.lblEditDifficulty.Size = new System.Drawing.Size(91, 18);
            this.lblEditDifficulty.TabIndex = 2;
            this.lblEditDifficulty.Text = "difficulty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "IME IGRAČA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "KATEGORIJA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "TEŽINA";
            // 
            // panelPitanja
            // 
            this.panelPitanja.Location = new System.Drawing.Point(12, 91);
            this.panelPitanja.Name = "panelPitanja";
            this.panelPitanja.Size = new System.Drawing.Size(1030, 529);
            this.panelPitanja.TabIndex = 7;
            this.panelPitanja.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPitanja_Paint);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1054, 632);
            this.Controls.Add(this.panelPitanja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEditDifficulty);
            this.Controls.Add(this.lblEditCategory);
            this.Controls.Add(this.lblEditUserName);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditUserName;
        private System.Windows.Forms.Label lblEditCategory;
        private System.Windows.Forms.Label lblEditDifficulty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPitanja;
    }
}