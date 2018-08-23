namespace Max_Assistant
{
    partial class entryhw
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtpartid = new System.Windows.Forms.TextBox();
            this.txtupc = new System.Windows.Forms.TextBox();
            this.txtpo = new System.Windows.Forms.TextBox();
            this.dataentry = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtpartid);
            this.groupBox1.Controls.Add(this.txtupc);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion de caja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PartID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "UPC";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(539, 341);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtpartid
            // 
            this.txtpartid.Location = new System.Drawing.Point(288, 37);
            this.txtpartid.Name = "txtpartid";
            this.txtpartid.Size = new System.Drawing.Size(257, 20);
            this.txtpartid.TabIndex = 1;
            this.txtpartid.TextChanged += new System.EventHandler(this.txtpartid_TextChanged);
            // 
            // txtupc
            // 
            this.txtupc.Location = new System.Drawing.Point(41, 37);
            this.txtupc.Name = "txtupc";
            this.txtupc.Size = new System.Drawing.Size(198, 20);
            this.txtupc.TabIndex = 0;
            this.txtupc.TextChanged += new System.EventHandler(this.txtupc_TextChanged);
            // 
            // txtpo
            // 
            this.txtpo.Location = new System.Drawing.Point(54, 468);
            this.txtpo.Name = "txtpo";
            this.txtpo.Size = new System.Drawing.Size(100, 20);
            this.txtpo.TabIndex = 1;
            // 
            // dataentry
            // 
            this.dataentry.CustomFormat = "MM/dd/yyyy";
            this.dataentry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataentry.Location = new System.Drawing.Point(171, 468);
            this.dataentry.Name = "dataentry";
            this.dataentry.Size = new System.Drawing.Size(200, 20);
            this.dataentry.TabIndex = 2;
            // 
            // entryhw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 436);
            this.Controls.Add(this.dataentry);
            this.Controls.Add(this.txtpo);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "entryhw";
            this.Text = "Entrada a almacen";
            this.Activated += new System.EventHandler(this.entryhw_Activated);
            this.Load += new System.EventHandler(this.entryhw_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtpartid;
        private System.Windows.Forms.TextBox txtupc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpo;
        private System.Windows.Forms.DateTimePicker dataentry;
    }
}