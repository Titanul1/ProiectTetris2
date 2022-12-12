namespace ProiectTetris2
{
    partial class Shop
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
            this.button1 = new System.Windows.Forms.Button();
            this.salutare = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cumpara T-Gold";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // salutare
            // 
            this.salutare.AutoSize = true;
            this.salutare.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salutare.Location = new System.Drawing.Point(26, 18);
            this.salutare.Name = "salutare";
            this.salutare.Size = new System.Drawing.Size(283, 36);
            this.salutare.TabIndex = 1;
            this.salutare.Text = "Bine ai venit la shop!";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(26, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Inapoi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.salutare);
            this.Controls.Add(this.button1);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label salutare;
        private Button button2;
    }
}