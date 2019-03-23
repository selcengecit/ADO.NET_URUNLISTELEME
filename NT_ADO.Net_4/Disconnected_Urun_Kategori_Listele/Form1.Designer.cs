namespace Disconnected_Urun_Kategori_Listele
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnUrunGetir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnKategoriGetir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ürün Doldur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUrunGetir
            // 
            this.btnUrunGetir.Location = new System.Drawing.Point(12, 54);
            this.btnUrunGetir.Name = "btnUrunGetir";
            this.btnUrunGetir.Size = new System.Drawing.Size(113, 23);
            this.btnUrunGetir.TabIndex = 1;
            this.btnUrunGetir.Text = "ÜRÜN GÖSTER";
            this.btnUrunGetir.UseVisualStyleBackColor = true;
            this.btnUrunGetir.Click += new System.EventHandler(this.btnUrunGetir_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(379, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kategori Doldur";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnKategoriGetir
            // 
            this.btnKategoriGetir.Location = new System.Drawing.Point(379, 54);
            this.btnKategoriGetir.Name = "btnKategoriGetir";
            this.btnKategoriGetir.Size = new System.Drawing.Size(127, 23);
            this.btnKategoriGetir.TabIndex = 3;
            this.btnKategoriGetir.Text = "KATEGORİ GÖSTER";
            this.btnKategoriGetir.UseVisualStyleBackColor = true;
            this.btnKategoriGetir.Click += new System.EventHandler(this.btnKategoriGetir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 237);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKategoriGetir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnUrunGetir);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUrunGetir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnKategoriGetir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

