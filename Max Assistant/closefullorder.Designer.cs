namespace Max_Assistant
{
    partial class closefullorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(closefullorder));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderref_txt = new System.Windows.Forms.TextBox();
            this.run_btn = new System.Windows.Forms.Button();
            this.action_cb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.action_cb);
            this.groupBox1.Controls.Add(this.run_btn);
            this.groupBox1.Controls.Add(this.orderref_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cerrar Orden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orden:";
            // 
            // orderref_txt
            // 
            this.orderref_txt.Location = new System.Drawing.Point(179, 19);
            this.orderref_txt.MaxLength = 8;
            this.orderref_txt.Name = "orderref_txt";
            this.orderref_txt.Size = new System.Drawing.Size(162, 20);
            this.orderref_txt.TabIndex = 1;
            this.orderref_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderref_txt_KeyPress);
            // 
            // run_btn
            // 
            this.run_btn.Location = new System.Drawing.Point(6, 45);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(335, 23);
            this.run_btn.TabIndex = 2;
            this.run_btn.Text = "Realizar";
            this.run_btn.UseVisualStyleBackColor = true;
            this.run_btn.Click += new System.EventHandler(this.run_btn_Click);
            // 
            // action_cb
            // 
            this.action_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.action_cb.FormattingEnabled = true;
            this.action_cb.Items.AddRange(new object[] {
            "Cerrar",
            "Abrir"});
            this.action_cb.Location = new System.Drawing.Point(6, 19);
            this.action_cb.Name = "action_cb";
            this.action_cb.Size = new System.Drawing.Size(121, 21);
            this.action_cb.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 330);
            this.dataGridView1.TabIndex = 4;
            // 
            // closefullorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 428);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "closefullorder";
            this.Text = "closefullorder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox action_cb;
        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.TextBox orderref_txt;
        private System.Windows.Forms.Label label1;
    }
}