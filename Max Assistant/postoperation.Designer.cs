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
            this.gbpost = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data_dtp = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.code_txt = new System.Windows.Forms.TextBox();
            this.position_cb = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturaCeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb0 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtcodezero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbpost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gb0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbpost
            // 
            this.gbpost.Controls.Add(this.label3);
            this.gbpost.Controls.Add(this.label2);
            this.gbpost.Controls.Add(this.label1);
            this.gbpost.Controls.Add(this.data_dtp);
            this.gbpost.Controls.Add(this.dataGridView1);
            this.gbpost.Controls.Add(this.code_txt);
            this.gbpost.Controls.Add(this.position_cb);
            this.gbpost.Location = new System.Drawing.Point(12, 27);
            this.gbpost.Name = "gbpost";
            this.gbpost.Size = new System.Drawing.Size(799, 355);
            this.gbpost.TabIndex = 0;
            this.gbpost.TabStop = false;
            this.gbpost.Text = "Lectura de Operaciones";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postOperationToolStripMenuItem,
            this.lecturaCeroToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // postOperationToolStripMenuItem
            // 
            this.postOperationToolStripMenuItem.Name = "postOperationToolStripMenuItem";
            this.postOperationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.postOperationToolStripMenuItem.Text = "Post operation";
            this.postOperationToolStripMenuItem.Click += new System.EventHandler(this.postOperationToolStripMenuItem_Click);
            // 
            // lecturaCeroToolStripMenuItem
            // 
            this.lecturaCeroToolStripMenuItem.Name = "lecturaCeroToolStripMenuItem";
            this.lecturaCeroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lecturaCeroToolStripMenuItem.Text = "Lectura cero";
            this.lecturaCeroToolStripMenuItem.Click += new System.EventHandler(this.lecturaCeroToolStripMenuItem_Click);
            // 
            // gb0
            // 
            this.gb0.Controls.Add(this.label4);
            this.gb0.Controls.Add(this.txtcodezero);
            this.gb0.Controls.Add(this.dataGridView2);
            this.gb0.Location = new System.Drawing.Point(5, 27);
            this.gb0.Name = "gb0";
            this.gb0.Size = new System.Drawing.Size(807, 355);
            this.gb0.TabIndex = 7;
            this.gb0.TabStop = false;
            this.gb0.Text = "Lectura Cero";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 44);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(767, 286);
            this.dataGridView2.TabIndex = 3;
            // 
            // txtcodezero
            // 
            this.txtcodezero.Location = new System.Drawing.Point(218, 18);
            this.txtcodezero.Name = "txtcodezero";
            this.txtcodezero.Size = new System.Drawing.Size(321, 20);
            this.txtcodezero.TabIndex = 4;
            this.txtcodezero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodezero_KeyDown);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Code";
            // 
            // postoperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 397);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gb0);
            this.Controls.Add(this.gbpost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "postoperation";
            this.Text = "Post Operation";
            this.Activated += new System.EventHandler(this.postoperation_Activated);
            this.Load += new System.EventHandler(this.postoperation_Load);
            this.gbpost.ResumeLayout(false);
            this.gbpost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb0.ResumeLayout(false);
            this.gb0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbpost;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox code_txt;
        private System.Windows.Forms.ComboBox position_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker data_dtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturaCeroToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodezero;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}