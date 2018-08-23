namespace Max_Assistant
{
    partial class seeorders
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ordersearch_txt = new System.Windows.Forms.TextBox();
            this.totalqty_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maxorder_rbtn = new System.Windows.Forms.RadioButton();
            this.poref_rbtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.poref_rbtn);
            this.groupBox1.Controls.Add(this.maxorder_rbtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.totalqty_txt);
            this.groupBox1.Controls.Add(this.ordersearch_txt);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 511);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visor de orden agrupada";
            // 
            // ordersearch_txt
            // 
            this.ordersearch_txt.Location = new System.Drawing.Point(120, 36);
            this.ordersearch_txt.Name = "ordersearch_txt";
            this.ordersearch_txt.Size = new System.Drawing.Size(251, 20);
            this.ordersearch_txt.TabIndex = 1;
            // 
            // totalqty_txt
            // 
            this.totalqty_txt.Location = new System.Drawing.Point(239, 62);
            this.totalqty_txt.Name = "totalqty_txt";
            this.totalqty_txt.Size = new System.Drawing.Size(132, 20);
            this.totalqty_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Criterio de Busqueda:";
            // 
            // maxorder_rbtn
            // 
            this.maxorder_rbtn.AutoSize = true;
            this.maxorder_rbtn.Location = new System.Drawing.Point(120, 13);
            this.maxorder_rbtn.Name = "maxorder_rbtn";
            this.maxorder_rbtn.Size = new System.Drawing.Size(74, 17);
            this.maxorder_rbtn.TabIndex = 4;
            this.maxorder_rbtn.TabStop = true;
            this.maxorder_rbtn.Text = "Order Max";
            this.maxorder_rbtn.UseVisualStyleBackColor = true;
            // 
            // poref_rbtn
            // 
            this.poref_rbtn.AutoSize = true;
            this.poref_rbtn.Location = new System.Drawing.Point(200, 13);
            this.poref_rbtn.Name = "poref_rbtn";
            this.poref_rbtn.Size = new System.Drawing.Size(62, 17);
            this.poref_rbtn.TabIndex = 5;
            this.poref_rbtn.TabStop = true;
            this.poref_rbtn.Text = "PO/Ref";
            this.poref_rbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad Total:";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(268, 10);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(103, 23);
            this.search_btn.TabIndex = 7;
            this.search_btn.Text = "Buscar";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // seeorders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 536);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "seeorders";
            this.Text = "Ver Ordenes";
            this.Load += new System.EventHandler(this.seeorders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton maxorder_rbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalqty_txt;
        private System.Windows.Forms.TextBox ordersearch_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton poref_rbtn;
        private System.Windows.Forms.Button search_btn;
    }
}