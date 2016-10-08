namespace Calculator
{
    partial class FrmMain
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnc = new System.Windows.Forms.Button();
            this.btnbackspace = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btncham = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btndau = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.btncong = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btnchia = new System.Windows.Forms.Button();
            this.btnphantram = new System.Windows.Forms.Button();
            this.btncan = new System.Windows.Forms.Button();
            this.btnbang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDisplay.Location = new System.Drawing.Point(15, 9);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(224, 33);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "0.";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(15, 55);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(86, 33);
            this.btnc.TabIndex = 22;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            // 
            // btnbackspace
            // 
            this.btnbackspace.Location = new System.Drawing.Point(107, 55);
            this.btnbackspace.Name = "btnbackspace";
            this.btnbackspace.Size = new System.Drawing.Size(132, 33);
            this.btnbackspace.TabIndex = 23;
            this.btnbackspace.Text = "Backspace";
            this.btnbackspace.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(15, 103);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 37);
            this.btn7.TabIndex = 24;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(107, 103);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 37);
            this.btn9.TabIndex = 25;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NhapSo);
            // 
            // btncham
            // 
            this.btncham.Location = new System.Drawing.Point(107, 232);
            this.btncham.Name = "btncham";
            this.btncham.Size = new System.Drawing.Size(40, 37);
            this.btncham.TabIndex = 26;
            this.btncham.Text = ".";
            this.btncham.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(107, 146);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 37);
            this.btn6.TabIndex = 27;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(107, 189);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 37);
            this.btn3.TabIndex = 28;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(61, 232);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(40, 37);
            this.btn0.TabIndex = 29;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(61, 189);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 37);
            this.btn2.TabIndex = 30;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(61, 146);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 37);
            this.btn5.TabIndex = 31;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(61, 103);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 37);
            this.btn8.TabIndex = 32;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NhapSo);
            // 
            // btndau
            // 
            this.btndau.Location = new System.Drawing.Point(15, 232);
            this.btndau.Name = "btndau";
            this.btndau.Size = new System.Drawing.Size(40, 37);
            this.btndau.TabIndex = 33;
            this.btndau.Text = "+/-";
            this.btndau.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(15, 189);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 37);
            this.btn1.TabIndex = 34;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(15, 146);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 37);
            this.btn4.TabIndex = 35;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NhapSo);
            // 
            // btntru
            // 
            this.btntru.Location = new System.Drawing.Point(151, 146);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(40, 37);
            this.btntru.TabIndex = 36;
            this.btntru.Text = "-";
            this.btntru.UseVisualStyleBackColor = true;
            this.btntru.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // btncong
            // 
            this.btncong.Location = new System.Drawing.Point(151, 103);
            this.btncong.Name = "btncong";
            this.btncong.Size = new System.Drawing.Size(40, 37);
            this.btncong.TabIndex = 37;
            this.btncong.Text = "+";
            this.btncong.UseVisualStyleBackColor = true;
            this.btncong.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // btnnhan
            // 
            this.btnnhan.Location = new System.Drawing.Point(151, 189);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(40, 37);
            this.btnnhan.TabIndex = 38;
            this.btnnhan.Text = "*";
            this.btnnhan.UseVisualStyleBackColor = true;
            this.btnnhan.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // btnchia
            // 
            this.btnchia.Location = new System.Drawing.Point(151, 232);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(40, 37);
            this.btnchia.TabIndex = 39;
            this.btnchia.Text = "/";
            this.btnchia.UseVisualStyleBackColor = true;
            this.btnchia.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // btnphantram
            // 
            this.btnphantram.Location = new System.Drawing.Point(197, 103);
            this.btnphantram.Name = "btnphantram";
            this.btnphantram.Size = new System.Drawing.Size(40, 37);
            this.btnphantram.TabIndex = 40;
            this.btnphantram.Text = "%";
            this.btnphantram.UseVisualStyleBackColor = true;
            // 
            // btncan
            // 
            this.btncan.Location = new System.Drawing.Point(197, 146);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(40, 37);
            this.btncan.TabIndex = 41;
            this.btncan.Text = "√";
            this.btncan.UseVisualStyleBackColor = true;
            // 
            // btnbang
            // 
            this.btnbang.Location = new System.Drawing.Point(197, 189);
            this.btnbang.Name = "btnbang";
            this.btnbang.Size = new System.Drawing.Size(40, 78);
            this.btnbang.TabIndex = 42;
            this.btnbang.Text = "=";
            this.btnbang.UseVisualStyleBackColor = true;
            this.btnbang.Click += new System.EventHandler(this.btnBang_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 279);
            this.Controls.Add(this.btnbang);
            this.Controls.Add(this.btncan);
            this.Controls.Add(this.btnphantram);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.btncong);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btndau);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btncham);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnbackspace);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.lblDisplay);
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.Text = "Caculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnbackspace;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btncham;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btndau;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.Button btncong;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button btnchia;
        private System.Windows.Forms.Button btnphantram;
        private System.Windows.Forms.Button btncan;
        private System.Windows.Forms.Button btnbang;
    }
}

