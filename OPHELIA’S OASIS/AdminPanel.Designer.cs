
namespace OPHELIA_S_OASIS
{
    partial class AdminPanel
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tesvikRaporu = new System.Windows.Forms.RadioButton();
            this.beklenenOdaGelir = new System.Windows.Forms.RadioButton();
            this.beklenenDoluluk = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.geriButton = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(495, 248);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rezervasyon Sayısı";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rezervasyon Tipi";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tarih";
            this.columnHeader3.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tesvikRaporu);
            this.groupBox1.Controls.Add(this.beklenenOdaGelir);
            this.groupBox1.Controls.Add(this.beklenenDoluluk);
            this.groupBox1.Location = new System.Drawing.Point(524, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raporlar";
            // 
            // tesvikRaporu
            // 
            this.tesvikRaporu.AutoSize = true;
            this.tesvikRaporu.Location = new System.Drawing.Point(6, 86);
            this.tesvikRaporu.Name = "tesvikRaporu";
            this.tesvikRaporu.Size = new System.Drawing.Size(121, 21);
            this.tesvikRaporu.TabIndex = 2;
            this.tesvikRaporu.TabStop = true;
            this.tesvikRaporu.Text = "Teşvik Raporu";
            this.tesvikRaporu.UseVisualStyleBackColor = true;
            // 
            // beklenenOdaGelir
            // 
            this.beklenenOdaGelir.AutoSize = true;
            this.beklenenOdaGelir.Location = new System.Drawing.Point(6, 59);
            this.beklenenOdaGelir.Name = "beklenenOdaGelir";
            this.beklenenOdaGelir.Size = new System.Drawing.Size(204, 21);
            this.beklenenOdaGelir.TabIndex = 1;
            this.beklenenOdaGelir.TabStop = true;
            this.beklenenOdaGelir.Text = "Beklenen Oda Gelir Raporu";
            this.beklenenOdaGelir.UseVisualStyleBackColor = true;
            // 
            // beklenenDoluluk
            // 
            this.beklenenDoluluk.AutoSize = true;
            this.beklenenDoluluk.Location = new System.Drawing.Point(6, 32);
            this.beklenenDoluluk.Name = "beklenenDoluluk";
            this.beklenenDoluluk.Size = new System.Drawing.Size(190, 21);
            this.beklenenDoluluk.TabIndex = 0;
            this.beklenenDoluluk.TabStop = true;
            this.beklenenDoluluk.Text = "Beklenen Doluluk Raporu";
            this.beklenenDoluluk.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rapor Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // geriButton
            // 
            this.geriButton.Location = new System.Drawing.Point(12, 323);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(87, 49);
            this.geriButton.TabIndex = 3;
            this.geriButton.Text = "Geri";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.GeriButton_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 12);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(495, 248);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tarih";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Beklenen Gelir";
            this.columnHeader5.Width = 160;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(646, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 49);
            this.button3.TabIndex = 5;
            this.button3.Text = "Fiyatları Değiştir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(12, 12);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(495, 248);
            this.listView3.TabIndex = 7;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tarih";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Teşvik İndirimi";
            this.columnHeader7.Width = 80;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 392);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton tesvikRaporu;
        private System.Windows.Forms.RadioButton beklenenOdaGelir;
        private System.Windows.Forms.RadioButton beklenenDoluluk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}