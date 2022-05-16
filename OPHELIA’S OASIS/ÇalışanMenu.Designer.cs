
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
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.musteriAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rezType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.odaNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDoluluk = new System.Windows.Forms.ListView();
            this.musteriAdSyd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doluOdaNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkoutTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewGelen
            // 
            this.listViewGelen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.musteriAd,
            this.rezType,
            this.odaNo,
            this.checkOut});
            this.listViewGelen.HideSelection = false;
            this.listViewGelen.Location = new System.Drawing.Point(12, 47);
            this.listViewGelen.Name = "listViewGelen";
            this.listViewGelen.Size = new System.Drawing.Size(565, 257);
            this.listViewGelen.TabIndex = 0;
            this.listViewGelen.UseCompatibleStateImageBehavior = false;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 25;
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
            this.odaNo.Width = 100;
            // 
            // checkOut
            // 
            this.checkOut.Text = "Check-Out Tarihi";
            this.checkOut.Width = 100;
            // 
            // listViewDoluluk
            // 
            this.listViewDoluluk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.musteriAdSyd,
            this.doluOdaNo,
            this.checkoutTarihi});
            this.listViewDoluluk.HideSelection = false;
            this.listViewDoluluk.Location = new System.Drawing.Point(610, 47);
            this.listViewDoluluk.Name = "listViewDoluluk";
            this.listViewDoluluk.Size = new System.Drawing.Size(408, 257);
            this.listViewDoluluk.TabIndex = 1;
            this.listViewDoluluk.UseCompatibleStateImageBehavior = false;
            // 
            // musteriAdSyd
            // 
            this.musteriAdSyd.DisplayIndex = 1;
            this.musteriAdSyd.Text = "Müşteri İsim";
            this.musteriAdSyd.Width = 100;
            // 
            // doluOdaNo
            // 
            this.doluOdaNo.DisplayIndex = 0;
            this.doluOdaNo.Text = "Oda Numarası";
            this.doluOdaNo.Width = 100;
            // 
            // checkoutTarihi
            // 
            this.checkoutTarihi.Text = "Check-out Tarihi";
            this.checkoutTarihi.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Günlük gelenler raporu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Günlük doluluk oranı:";
            // 
            // ÇalışanMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewDoluluk);
            this.Controls.Add(this.listViewGelen);
            this.Name = "ÇalışanMenu";
            this.Text = "ÇalışanMenu";
            this.Load += new System.EventHandler(this.ÇalışanMenu_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader musteriAdSyd;
        private System.Windows.Forms.ColumnHeader doluOdaNo;
        private System.Windows.Forms.ColumnHeader checkoutTarihi;
        private System.Windows.Forms.ColumnHeader id;
    }
}