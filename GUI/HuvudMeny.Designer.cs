namespace GUI
{
    partial class HuvudMeny
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
            this.btnBokaBok = new System.Windows.Forms.Button();
            this.btnLoggaUT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBokaBok
            // 
            this.btnBokaBok.Location = new System.Drawing.Point(12, 12);
            this.btnBokaBok.Name = "btnBokaBok";
            this.btnBokaBok.Size = new System.Drawing.Size(214, 39);
            this.btnBokaBok.TabIndex = 0;
            this.btnBokaBok.Text = "Boka bok";
            this.btnBokaBok.UseVisualStyleBackColor = true;
            this.btnBokaBok.Click += new System.EventHandler(this.btnBokaBok_Click);
            // 
            // btnLoggaUT
            // 
            this.btnLoggaUT.Location = new System.Drawing.Point(12, 57);
            this.btnLoggaUT.Name = "btnLoggaUT";
            this.btnLoggaUT.Size = new System.Drawing.Size(214, 39);
            this.btnLoggaUT.TabIndex = 1;
            this.btnLoggaUT.Text = "Logga ut";
            this.btnLoggaUT.UseVisualStyleBackColor = true;
            this.btnLoggaUT.Click += new System.EventHandler(this.btnLoggaUT_Click);
            // 
            // HuvudMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 112);
            this.Controls.Add(this.btnLoggaUT);
            this.Controls.Add(this.btnBokaBok);
            this.Name = "HuvudMeny";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBokaBok;
        private System.Windows.Forms.Button btnLoggaUT;
    }
}