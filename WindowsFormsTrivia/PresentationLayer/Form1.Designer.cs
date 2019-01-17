namespace PresentationLayer
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
            this.NoviKviz = new System.Windows.Forms.Button();
            this.PregledRezultata = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoviKviz
            // 
            this.NoviKviz.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoviKviz.Location = new System.Drawing.Point(85, 122);
            this.NoviKviz.Name = "NoviKviz";
            this.NoviKviz.Size = new System.Drawing.Size(211, 54);
            this.NoviKviz.TabIndex = 0;
            this.NoviKviz.Text = "Novi kviz";
            this.NoviKviz.UseVisualStyleBackColor = true;
            this.NoviKviz.Click += new System.EventHandler(this.NoviKviz_Click);
            // 
            // PregledRezultata
            // 
            this.PregledRezultata.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PregledRezultata.Location = new System.Drawing.Point(85, 212);
            this.PregledRezultata.Name = "PregledRezultata";
            this.PregledRezultata.Size = new System.Drawing.Size(211, 54);
            this.PregledRezultata.TabIndex = 1;
            this.PregledRezultata.Text = "Pregled rezultata";
            this.PregledRezultata.UseVisualStyleBackColor = true;
            this.PregledRezultata.Click += new System.EventHandler(this.PregledRezultata_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kviz o općem znanju";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PregledRezultata);
            this.Controls.Add(this.NoviKviz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NoviKviz;
        private System.Windows.Forms.Button PregledRezultata;
        private System.Windows.Forms.Label label1;
    }
}

