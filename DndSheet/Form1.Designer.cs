namespace DndSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Str = new System.Windows.Forms.NumericUpDown();
            this.Int = new System.Windows.Forms.NumericUpDown();
            this.Dex = new System.Windows.Forms.NumericUpDown();
            this.Con = new System.Windows.Forms.NumericUpDown();
            this.Cha = new System.Windows.Forms.NumericUpDown();
            this.Luk = new System.Windows.Forms.NumericUpDown();
            this.Hp = new System.Windows.Forms.NumericUpDown();
            this.Mp = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Str)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Int)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Con)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mp)).BeginInit();
            this.SuspendLayout();
            // 
            // CName
            // 
            this.CName.Location = new System.Drawing.Point(22, 52);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(247, 22);
            this.CName.TabIndex = 0;
            this.CName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(589, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(498, 260);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Character Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 125F;
            this.Column2.HeaderText = "HP";
            this.Column2.MinimumWidth = 35;
            this.Column2.Name = "Column2";
            this.Column2.Width = 35;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 125F;
            this.Column3.HeaderText = "MP";
            this.Column3.MinimumWidth = 35;
            this.Column3.Name = "Column3";
            this.Column3.Width = 35;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gender";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Faction";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Character Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // Str
            // 
            this.Str.Location = new System.Drawing.Point(465, 74);
            this.Str.Name = "Str";
            this.Str.Size = new System.Drawing.Size(59, 22);
            this.Str.TabIndex = 4;
            this.Str.ValueChanged += new System.EventHandler(this.Str_ValueChanged);
            // 
            // Int
            // 
            this.Int.Location = new System.Drawing.Point(465, 174);
            this.Int.Name = "Int";
            this.Int.Size = new System.Drawing.Size(59, 22);
            this.Int.TabIndex = 5;
            this.Int.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // Dex
            // 
            this.Dex.Location = new System.Drawing.Point(465, 124);
            this.Dex.Name = "Dex";
            this.Dex.Size = new System.Drawing.Size(59, 22);
            this.Dex.TabIndex = 6;
            this.Dex.ValueChanged += new System.EventHandler(this.Dex_ValueChanged);
            // 
            // Con
            // 
            this.Con.Location = new System.Drawing.Point(465, 229);
            this.Con.Name = "Con";
            this.Con.Size = new System.Drawing.Size(59, 22);
            this.Con.TabIndex = 7;
            this.Con.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // Cha
            // 
            this.Cha.Location = new System.Drawing.Point(465, 283);
            this.Cha.Name = "Cha";
            this.Cha.Size = new System.Drawing.Size(59, 22);
            this.Cha.TabIndex = 8;
            // 
            // Luk
            // 
            this.Luk.Location = new System.Drawing.Point(465, 337);
            this.Luk.Name = "Luk";
            this.Luk.Size = new System.Drawing.Size(59, 22);
            this.Luk.TabIndex = 9;
            this.Luk.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // Hp
            // 
            this.Hp.Location = new System.Drawing.Point(23, 117);
            this.Hp.Name = "Hp";
            this.Hp.Size = new System.Drawing.Size(59, 22);
            this.Hp.TabIndex = 10;
            this.Hp.ValueChanged += new System.EventHandler(this.numericUpDown7_ValueChanged);
            // 
            // Mp
            // 
            this.Mp.Location = new System.Drawing.Point(140, 117);
            this.Mp.Name = "Mp";
            this.Mp.Size = new System.Drawing.Size(59, 22);
            this.Mp.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(22, 259);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(22, 381);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 25);
            this.Save.TabIndex = 13;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(198, 182);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 14;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(198, 259);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Mp);
            this.Controls.Add(this.Hp);
            this.Controls.Add(this.Luk);
            this.Controls.Add(this.Cha);
            this.Controls.Add(this.Con);
            this.Controls.Add(this.Dex);
            this.Controls.Add(this.Int);
            this.Controls.Add(this.Str);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CName);
            this.Name = "Form1";
            this.Text = "RPG Character Creator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Str)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Int)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Con)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown Str;
        private System.Windows.Forms.NumericUpDown Int;
        private System.Windows.Forms.NumericUpDown Dex;
        private System.Windows.Forms.NumericUpDown Con;
        private System.Windows.Forms.NumericUpDown Cha;
        private System.Windows.Forms.NumericUpDown Luk;
        private System.Windows.Forms.NumericUpDown Hp;
        private System.Windows.Forms.NumericUpDown Mp;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

