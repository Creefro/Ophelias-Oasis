
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.beklenenDoluluk = new System.Windows.Forms.RadioButton();
            this.beklenenOdaGelir = new System.Windows.Forms.RadioButton();
            this.tesvikRaporu = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tesvikRaporu);
            this.groupBox1.Controls.Add(this.beklenenOdaGelir);
            this.groupBox1.Controls.Add(this.beklenenDoluluk);
            this.groupBox1.Location = new System.Drawing.Point(535, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // beklenenDoluluk
            // 
            this.beklenenDoluluk.AutoSize = true;
            this.beklenenDoluluk.Location = new System.Drawing.Point(23, 18);
            this.beklenenDoluluk.Name = "beklenenDoluluk";
            this.beklenenDoluluk.Size = new System.Drawing.Size(190, 21);
            this.beklenenDoluluk.TabIndex = 0;
            this.beklenenDoluluk.TabStop = true;
            this.beklenenDoluluk.Text = "Beklenen Doluluk Raporu";
            this.beklenenDoluluk.UseVisualStyleBackColor = true;
            // 
            // beklenenOdaGelir
            // 
            this.beklenenOdaGelir.AutoSize = true;
            this.beklenenOdaGelir.Location = new System.Drawing.Point(23, 45);
            this.beklenenOdaGelir.Name = "beklenenOdaGelir";
            this.beklenenOdaGelir.Size = new System.Drawing.Size(204, 21);
            this.beklenenOdaGelir.TabIndex = 1;
            this.beklenenOdaGelir.TabStop = true;
            this.beklenenOdaGelir.Text = "Beklenen Oda Gelir Raporu";
            this.beklenenOdaGelir.UseVisualStyleBackColor = true;
            // 
            // tesvikRaporu
            // 
            this.tesvikRaporu.AutoSize = true;
            this.tesvikRaporu.Location = new System.Drawing.Point(23, 72);
            this.tesvikRaporu.Name = "tesvikRaporu";
            this.tesvikRaporu.Size = new System.Drawing.Size(121, 21);
            this.tesvikRaporu.TabIndex = 2;
            this.tesvikRaporu.TabStop = true;
            this.tesvikRaporu.Text = "Teşvik Raporu";
            this.tesvikRaporu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rapor Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(118, 266);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(495, 248);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton tesvikRaporu;
        private System.Windows.Forms.RadioButton beklenenOdaGelir;
        private System.Windows.Forms.RadioButton beklenenDoluluk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}