namespace Max_Assistant
{
    partial class postoperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(postoperation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data_dtp = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.code_txt = new System.Windows.Forms.TextBox();
            this.position_cb = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.data_dtp);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.code_txt);
            this.groupBox1.Controls.Add(this.position_cb);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lectura de Operaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de Terminacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo/Orden:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Posicion:";
            // 
            // data_dtp
            // 
            this.data_dtp.CustomFormat = "yyyy-MM-dd";
            this.data_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_dtp.Location = new System.Drawing.Point(593, 37);
            this.data_dtp.Name = "data_dtp";
            this.data_dtp.Size = new System.Drawing.Size(200, 20);
            this.data_dtp.TabIndex = 3;
            this.data_dtp.ValueChanged += new System.EventHandler(this.data_dtp_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(787, 286);
            this.dataGridView1.TabIndex = 2;
            // 
            // code_txt
            // 
            this.code_txt.Location = new System.Drawing.Point(266, 36);
            this.code_txt.Name = "code_txt";
            this.code_txt.Size = new System.Drawing.Size(321, 20);
            this.code_txt.TabIndex = 1;
            this.code_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.code_txt_KeyDown);
            this.code_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.code_txt_KeyPress);
            // 
            // position_cb
            // 
            this.position_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position_cb.FormattingEnabled = true;
            this.position_cb.Items.AddRange(new object[] {
            "Planning",
            "Cut Out",
            "Pre-Fitting Out",
            "Preparation Out",
            "Casing Booties/Leather Out",
            "Final Inspection"});
            this.position_cb.Location = new System.Drawing.Point(6, 36);
            this.position_cb.Name = "position_cb";
            this.position_cb.Size = new System.Drawing.Size(254, 21);
            this.position_cb.TabIndex = 0;
            this.position_cb.SelectedIndexChanged += new System.EventHandler(this.position_cb_SelectedIndexChanged);
            this.position_cb.SelectedValueChanged += new System.EventHandler(this.position_cb_SelectedValueChanged);
            // 
            // postoperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 380);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "postoperation";
            this.Text = "Post Operation";
            this.Activated += new System.EventHandler(this.postoperation_Activated);
            this.Load += new System.EventHandler(this.postoperation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox code_txt;
        private System.Windows.Forms.ComboBox position_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker data_dtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}