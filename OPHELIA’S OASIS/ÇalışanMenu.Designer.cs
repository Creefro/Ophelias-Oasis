
namespace OPHELIA_S_OASIS
{
    partial class ÇalışanMenu
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
            this.listViewGelen = new System.Windows.Forms.ListView();
            this.musteriAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rezType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.odaNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDoluluk = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dolulukButton = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.gelenButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewGelen
            // 
            this.listViewGelen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.musteriAd,
            this.rezType,
            this.odaNo,
            this.checkOut});
            this.listViewGelen.HideSelection = false;
            this.listViewGelen.Location = new System.Drawing.Point(12, 47);
            this.listViewGelen.Name = "listViewGelen";
            this.listViewGelen.Size = new System.Drawing.Size(515, 257);
            this.listViewGelen.TabIndex = 0;
            this.listViewGelen.UseCompatibleStateImageBehavior = false;
            // 
            // musteriAd
            // 
            this.musteriAd.Text = "Müşteri Ad Soyad";
            this.musteriAd.Width = 100;
            // 
            // rezType
            // 
            this.rezType.Text = "Rezervasyon Tipi";
            this.rezType.Width = 100;
            // 
            // odaNo
            // 
            this.odaNo.Text = "Oda Numarası";
            this.odaNo.Width = 80;
            // 
            // checkOut
            // 
            this.checkOut.Text = "Check-Out Tarihi";
            this.checkOut.Width = 100;
            // 
            // listViewDoluluk
            // 
            this.listViewDoluluk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4});
            this.listViewDoluluk.HideSelection = false;
            this.listViewDoluluk.Location = new System.Drawing.Point(12, 47);
            this.listViewDoluluk.Name = "listViewDoluluk";
            this.listViewDoluluk.Size = new System.Drawing.Size(383, 257);
            this.listViewDoluluk.TabIndex = 1;
            this.listViewDoluluk.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Müşteri Ad Soyad";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Oda Numarası";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Check-Out Tarihi";
            this.columnHeader4.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(124, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Fatura";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(17, 52);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Oda No";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dolulukButton);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.gelenButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(566, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 107);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rapor Göster";
            // 
            // dolulukButton
            // 
            this.dolulukButton.AutoSize = true;
            this.dolulukButton.Location = new System.Drawing.Point(7, 66);
            this.dolulukButton.Name = "dolulukButton";
            this.dolulukButton.Size = new System.Drawing.Size(125, 24);
            this.dolulukButton.TabIndex = 1;
            this.dolulukButton.TabStop = true;
            this.dolulukButton.Text = "Doluluk Oranı";
            this.dolulukButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(138, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 31);
            this.button3.TabIndex = 9;
            this.button3.Text = "Göster";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gelenButton
            // 
            this.gelenButton.AutoSize = true;
            this.gelenButton.Location = new System.Drawing.Point(7, 36);
            this.gelenButton.Name = "gelenButton";
            this.gelenButton.Size = new System.Drawing.Size(122, 24);
            this.gelenButton.TabIndex = 0;
            this.gelenButton.TabStop = true;
            this.gelenButton.Text = "Gelen Raporu";
            this.gelenButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(566, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 86);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fatura Göster";
            // 
            // ÇalışanMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewDoluluk);
            this.Controls.Add(this.listViewGelen);
            this.Name = "ÇalışanMenu";
            this.Text = "ÇalışanMenu";
            this.Load += new System.EventHandler(this.ÇalışanMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewGelen;
        private System.Windows.Forms.ColumnHeader musteriAd;
        private System.Windows.Forms.ColumnHeader rezType;
        private System.Windows.Forms.ColumnHeader odaNo;
        private System.Windows.Forms.ColumnHeader checkOut;
        private System.Windows.Forms.ListView listViewDoluluk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton dolulukButton;
        private System.Windows.Forms.RadioButton gelenButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}