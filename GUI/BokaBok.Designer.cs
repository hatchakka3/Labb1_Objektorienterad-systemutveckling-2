namespace GUI
{
    partial class BokaBok
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
            this.dataGridTillgängligaBöcker = new System.Windows.Forms.DataGridView();
            this.btnBoka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridBokadeBöcker = new System.Windows.Forms.DataGridView();
            this.btnÅterlämna = new System.Windows.Forms.Button();
            this.btnVisaBokningar = new System.Windows.Forms.Button();
            this.btnFakturor = new System.Windows.Forms.Button();
            this.btnTillbaka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTillgängligaBöcker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBokadeBöcker)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTillgängligaBöcker
            // 
            this.dataGridTillgängligaBöcker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTillgängligaBöcker.Location = new System.Drawing.Point(12, 12);
            this.dataGridTillgängligaBöcker.MultiSelect = false;
            this.dataGridTillgängligaBöcker.Name = "dataGridTillgängligaBöcker";
            this.dataGridTillgängligaBöcker.ReadOnly = true;
            this.dataGridTillgängligaBöcker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTillgängligaBöcker.Size = new System.Drawing.Size(500, 316);
            this.dataGridTillgängligaBöcker.TabIndex = 0;
            this.dataGridTillgängligaBöcker.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTillgängligaBöcker_CellContentClick);
            // 
            // btnBoka
            // 
            this.btnBoka.Location = new System.Drawing.Point(391, 335);
            this.btnBoka.Name = "btnBoka";
            this.btnBoka.Size = new System.Drawing.Size(121, 38);
            this.btnBoka.TabIndex = 1;
            this.btnBoka.Text = "Boka";
            this.btnBoka.UseVisualStyleBackColor = true;
            this.btnBoka.Click += new System.EventHandler(this.btnBoka_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medlem";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 353);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridBokadeBöcker
            // 
            this.dataGridBokadeBöcker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBokadeBöcker.Location = new System.Drawing.Point(550, 12);
            this.dataGridBokadeBöcker.MultiSelect = false;
            this.dataGridBokadeBöcker.Name = "dataGridBokadeBöcker";
            this.dataGridBokadeBöcker.ReadOnly = true;
            this.dataGridBokadeBöcker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBokadeBöcker.Size = new System.Drawing.Size(500, 316);
            this.dataGridBokadeBöcker.TabIndex = 4;
            // 
            // btnÅterlämna
            // 
            this.btnÅterlämna.Location = new System.Drawing.Point(929, 337);
            this.btnÅterlämna.Name = "btnÅterlämna";
            this.btnÅterlämna.Size = new System.Drawing.Size(121, 38);
            this.btnÅterlämna.TabIndex = 6;
            this.btnÅterlämna.Text = "Återlämna bok";
            this.btnÅterlämna.UseVisualStyleBackColor = true;
            this.btnÅterlämna.Click += new System.EventHandler(this.btnÅterlämna_Click);
            // 
            // btnVisaBokningar
            // 
            this.btnVisaBokningar.Location = new System.Drawing.Point(550, 337);
            this.btnVisaBokningar.Name = "btnVisaBokningar";
            this.btnVisaBokningar.Size = new System.Drawing.Size(121, 38);
            this.btnVisaBokningar.TabIndex = 5;
            this.btnVisaBokningar.Text = "Visa bokningar";
            this.btnVisaBokningar.UseVisualStyleBackColor = true;
            this.btnVisaBokningar.Click += new System.EventHandler(this.btnVisaBokningar_Click);
            // 
            // btnFakturor
            // 
            this.btnFakturor.Location = new System.Drawing.Point(677, 337);
            this.btnFakturor.Name = "btnFakturor";
            this.btnFakturor.Size = new System.Drawing.Size(121, 38);
            this.btnFakturor.TabIndex = 7;
            this.btnFakturor.Text = "Visa fakturor";
            this.btnFakturor.UseVisualStyleBackColor = true;
            this.btnFakturor.Click += new System.EventHandler(this.btnFakturor_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(12, 337);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(121, 38);
            this.btnTillbaka.TabIndex = 8;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // BokaBok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 385);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.btnFakturor);
            this.Controls.Add(this.btnÅterlämna);
            this.Controls.Add(this.btnVisaBokningar);
            this.Controls.Add(this.dataGridBokadeBöcker);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBoka);
            this.Controls.Add(this.dataGridTillgängligaBöcker);
            this.Name = "BokaBok";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTillgängligaBöcker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBokadeBöcker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTillgängligaBöcker;
        private System.Windows.Forms.Button btnBoka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridBokadeBöcker;
        private System.Windows.Forms.Button btnÅterlämna;
        private System.Windows.Forms.Button btnVisaBokningar;
        private System.Windows.Forms.Button btnFakturor;
        private System.Windows.Forms.Button btnTillbaka;
    }
}