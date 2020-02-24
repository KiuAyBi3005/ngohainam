namespace GiaoDienPhanLoaiCau
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
            this.buttonHienThi = new System.Windows.Forms.Button();
            this.buttonTrain = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textCauPhanTich = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPhanTich = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelKetQua = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHienThi
            // 
            this.buttonHienThi.Location = new System.Drawing.Point(594, 126);
            this.buttonHienThi.Name = "buttonHienThi";
            this.buttonHienThi.Size = new System.Drawing.Size(60, 37);
            this.buttonHienThi.TabIndex = 0;
            this.buttonHienThi.Text = "Hiển Thị";
            this.buttonHienThi.UseVisualStyleBackColor = true;
            this.buttonHienThi.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTrain
            // 
            this.buttonTrain.Location = new System.Drawing.Point(594, 22);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(60, 37);
            this.buttonTrain.TabIndex = 1;
            this.buttonTrain.Text = "Train";
            this.buttonTrain.UseVisualStyleBackColor = true;
            this.buttonTrain.Click += new System.EventHandler(this.buttonTrain_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(594, 77);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(60, 37);
            this.buttonTest.TabIndex = 2;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(665, 315);
            this.dataGridView1.TabIndex = 4;
            // 
            // textCauPhanTich
            // 
            this.textCauPhanTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCauPhanTich.Location = new System.Drawing.Point(210, 47);
            this.textCauPhanTich.Name = "textCauPhanTich";
            this.textCauPhanTich.Size = new System.Drawing.Size(337, 22);
            this.textCauPhanTich.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập một câu ngẫu nhiên";
            // 
            // buttonPhanTich
            // 
            this.buttonPhanTich.Location = new System.Drawing.Point(346, 84);
            this.buttonPhanTich.Name = "buttonPhanTich";
            this.buttonPhanTich.Size = new System.Drawing.Size(75, 22);
            this.buttonPhanTich.TabIndex = 7;
            this.buttonPhanTich.Text = "Phân tích";
            this.buttonPhanTich.UseVisualStyleBackColor = true;
            this.buttonPhanTich.Click += new System.EventHandler(this.buttonPhanTich_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaoDienPhanLoaiCau.Properties.Resources.tải_xuống__7_;
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 151);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelKetQua
            // 
            this.labelKetQua.AutoSize = true;
            this.labelKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKetQua.Location = new System.Drawing.Point(347, 126);
            this.labelKetQua.Name = "labelKetQua";
            this.labelKetQua.Size = new System.Drawing.Size(74, 20);
            this.labelKetQua.TabIndex = 9;
            this.labelKetQua.Text = "Kết Quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(672, 496);
            this.Controls.Add(this.labelKetQua);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPhanTich);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCauPhanTich);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonTrain);
            this.Controls.Add(this.buttonHienThi);
            this.Name = "Form1";
            this.Text = "Phân Loại Quan Điểm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHienThi;
        private System.Windows.Forms.Button buttonTrain;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textCauPhanTich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPhanTich;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelKetQua;
    }
}

