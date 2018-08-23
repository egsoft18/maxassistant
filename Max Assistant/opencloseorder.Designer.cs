namespace Max_Assistant
{
    partial class opencloseorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(opencloseorder));
            this.startorder_txt = new System.Windows.Forms.TextBox();
            this.gg = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endorder_txt = new System.Windows.Forms.TextBox();
            this.run_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.action_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // startorder_txt
            // 
            this.startorder_txt.Location = new System.Drawing.Point(133, 43);
            this.startorder_txt.MaxLength = 8;
            this.startorder_txt.Name = "startorder_txt";
            this.startorder_txt.Size = new System.Drawing.Size(118, 20);
            this.startorder_txt.TabIndex = 0;
            this.startorder_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // gg
            // 
            this.gg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gg.Controls.Add(this.label3);
            this.gg.Controls.Add(this.endorder_txt);
            this.gg.Controls.Add(this.run_btn);
            this.gg.Controls.Add(this.label2);
            this.gg.Controls.Add(this.action_cb);
            this.gg.Controls.Add(this.label1);
            this.gg.Controls.Add(this.startorder_txt);
            this.gg.Location = new System.Drawing.Point(12, 12);
            this.gg.Name = "gg";
            this.gg.Size = new System.Drawing.Size(381, 100);
            this.gg.TabIndex = 1;
            this.gg.TabStop = false;
            this.gg.Text = "Accion Abrir/Cerrar Ordenes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Final de codigo";
            // 
            // endorder_txt
            // 
            this.endorder_txt.Location = new System.Drawing.Point(257, 43);
            this.endorder_txt.MaxLength = 8;
            this.endorder_txt.Name = "endorder_txt";
            this.endorder_txt.Size = new System.Drawing.Size(118, 20);
            this.endorder_txt.TabIndex = 5;
            this.endorder_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // run_btn
            // 
            this.run_btn.Location = new System.Drawing.Point(6, 69);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(369, 23);
            this.run_btn.TabIndex = 4;
            this.run_btn.Text = "Realizar";
            this.run_btn.UseVisualStyleBackColor = true;
            this.run_btn.Click += new System.EventHandler(this.run_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Accion:";
            // 
            // action_cb
            // 
            this.action_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.action_cb.FormattingEnabled = true;
            this.action_cb.Items.AddRange(new object[] {
            "Cerrar",
            "Abrir"});
            this.action_cb.Location = new System.Drawing.Point(6, 43);
            this.action_cb.Name = "action_cb";
            this.action_cb.Size = new System.Drawing.Size(121, 21);
            this.action_cb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio de codigo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 261);
            this.dataGridView1.TabIndex = 2;
            // 
            // opencloseorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(405, 391);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gg);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.Name = "opencloseorder";
            this.Text = "Abrir/Cerrar Order";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.opencloseorder_Load);
            this.gg.ResumeLayout(false);
            this.gg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox startorder_txt;
        private System.Windows.Forms.GroupBox gg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox endorder_txt;
        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox action_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}