namespace Max_Assistant
{
    partial class inserdatabooties
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
            this.bootiestt_txt = new System.Windows.Forms.TextBox();
            this.browers_btn = new System.Windows.Forms.Button();
            this.insert_booties_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bootiestt_txt
            // 
            this.bootiestt_txt.Location = new System.Drawing.Point(42, 54);
            this.bootiestt_txt.Name = "bootiestt_txt";
            this.bootiestt_txt.Size = new System.Drawing.Size(254, 20);
            this.bootiestt_txt.TabIndex = 0;
            // 
            // browers_btn
            // 
            this.browers_btn.Location = new System.Drawing.Point(302, 54);
            this.browers_btn.Name = "browers_btn";
            this.browers_btn.Size = new System.Drawing.Size(75, 23);
            this.browers_btn.TabIndex = 1;
            this.browers_btn.Text = "Examinar";
            this.browers_btn.UseVisualStyleBackColor = true;
            this.browers_btn.Click += new System.EventHandler(this.insertbooties_btn_Click);
            // 
            // insert_booties_btn
            // 
            this.insert_booties_btn.Location = new System.Drawing.Point(221, 80);
            this.insert_booties_btn.Name = "insert_booties_btn";
            this.insert_booties_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_booties_btn.TabIndex = 2;
            this.insert_booties_btn.Text = "Insertar";
            this.insert_booties_btn.UseVisualStyleBackColor = true;
            this.insert_booties_btn.Click += new System.EventHandler(this.insert_booties_btn_Click);
            // 
            // inserdatabooties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 154);
            this.Controls.Add(this.insert_booties_btn);
            this.Controls.Add(this.browers_btn);
            this.Controls.Add(this.bootiestt_txt);
            this.Name = "inserdatabooties";
            this.Text = "inserdatabooties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bootiestt_txt;
        private System.Windows.Forms.Button browers_btn;
        private System.Windows.Forms.Button insert_booties_btn;
    }
}