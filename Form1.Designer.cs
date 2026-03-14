namespace Modul3_103022400048
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
            this.cmb_satuanawal = new System.Windows.Forms.ComboBox();
            this.txt_nilaiawal = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.cmb_satuanakhir = new System.Windows.Forms.ComboBox();
            this.txt_nilaiakhir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_satuanawal
            // 
            this.cmb_satuanawal.FormattingEnabled = true;
            this.cmb_satuanawal.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Kelvin",
            "Reamur"});
            this.cmb_satuanawal.Location = new System.Drawing.Point(273, 164);
            this.cmb_satuanawal.Name = "cmb_satuanawal";
            this.cmb_satuanawal.Size = new System.Drawing.Size(121, 28);
            this.cmb_satuanawal.TabIndex = 0;
            // 
            // txt_nilaiawal
            // 
            this.txt_nilaiawal.Location = new System.Drawing.Point(456, 166);
            this.txt_nilaiawal.Name = "txt_nilaiawal";
            this.txt_nilaiawal.Size = new System.Drawing.Size(100, 26);
            this.txt_nilaiawal.TabIndex = 1;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(602, 166);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(75, 28);
            this.btn_convert.TabIndex = 2;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // cmb_satuanakhir
            // 
            this.cmb_satuanakhir.FormattingEnabled = true;
            this.cmb_satuanakhir.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Kelvin",
            "Reamur"});
            this.cmb_satuanakhir.Location = new System.Drawing.Point(273, 254);
            this.cmb_satuanakhir.Name = "cmb_satuanakhir";
            this.cmb_satuanakhir.Size = new System.Drawing.Size(121, 28);
            this.cmb_satuanakhir.TabIndex = 3;
            // 
            // txt_nilaiakhir
            // 
            this.txt_nilaiakhir.Location = new System.Drawing.Point(456, 256);
            this.txt_nilaiakhir.Name = "txt_nilaiakhir";
            this.txt_nilaiakhir.Size = new System.Drawing.Size(100, 26);
            this.txt_nilaiakhir.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Satuan Awal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nilai Awal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Satuan Akhir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nilai Akhir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 539);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nilaiakhir);
            this.Controls.Add(this.cmb_satuanakhir);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_nilaiawal);
            this.Controls.Add(this.cmb_satuanawal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_satuanawal;
        private System.Windows.Forms.TextBox txt_nilaiawal;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.ComboBox cmb_satuanakhir;
        private System.Windows.Forms.TextBox txt_nilaiakhir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

