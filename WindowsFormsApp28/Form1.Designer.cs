namespace WindowsFormsApp28
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.TextBox();
            this.cep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Ekle = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.Button();
            this.hepsi = new System.Windows.Forms.Button();
            this.çik = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adres , Telefon Defteri ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(166, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "İsim";
            // 
            // isim
            // 
            this.isim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.isim.Location = new System.Drawing.Point(244, 87);
            this.isim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(367, 30);
            this.isim.TabIndex = 2;
            this.toolTip1.SetToolTip(this.isim, "Ad Soyad Yazın");
            // 
            // cep
            // 
            this.cep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cep.Location = new System.Drawing.Point(244, 146);
            this.cep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(367, 30);
            this.cep.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cep, "Cep Telefonu Yazın");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(119, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cep num.";
            // 
            // adres
            // 
            this.adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adres.Location = new System.Drawing.Point(244, 200);
            this.adres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(367, 30);
            this.adres.TabIndex = 5;
            this.toolTip1.SetToolTip(this.adres, "Adres yazın ");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(145, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adress";
            // 
            // Ekle
            // 
            this.Ekle.FlatAppearance.BorderSize = 4;
            this.Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ekle.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ekle.Location = new System.Drawing.Point(91, 268);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(128, 48);
            this.Ekle.TabIndex = 7;
            this.Ekle.Text = "Ekle";
            this.toolTip1.SetToolTip(this.Ekle, "Yeni kişi ekle");
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // ara
            // 
            this.ara.FlatAppearance.BorderSize = 4;
            this.ara.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ara.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ara.Location = new System.Drawing.Point(254, 268);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(128, 48);
            this.ara.TabIndex = 8;
            this.ara.Text = "Ara";
            this.toolTip1.SetToolTip(this.ara, "listadan kişi ara");
            this.ara.UseVisualStyleBackColor = true;
            this.ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // hepsi
            // 
            this.hepsi.FlatAppearance.BorderSize = 4;
            this.hepsi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hepsi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hepsi.Location = new System.Drawing.Point(413, 268);
            this.hepsi.Name = "hepsi";
            this.hepsi.Size = new System.Drawing.Size(128, 48);
            this.hepsi.TabIndex = 9;
            this.hepsi.Text = "Liste Göster";
            this.toolTip1.SetToolTip(this.hepsi, "tüm listeyi göster");
            this.hepsi.UseVisualStyleBackColor = true;
            this.hepsi.Click += new System.EventHandler(this.hepsi_Click);
            // 
            // çik
            // 
            this.çik.FlatAppearance.BorderSize = 4;
            this.çik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.çik.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.çik.Location = new System.Drawing.Point(581, 265);
            this.çik.Name = "çik";
            this.çik.Size = new System.Drawing.Size(128, 48);
            this.çik.TabIndex = 10;
            this.çik.Text = "Çık";
            this.toolTip1.SetToolTip(this.çik, "uygulamadan çık");
            this.çik.UseVisualStyleBackColor = true;
            this.çik.Click += new System.EventHandler(this.çik_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "not";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(781, 364);
            this.Controls.Add(this.çik);
            this.Controls.Add(this.hepsi);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoş Geldiniz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.Button hepsi;
        private System.Windows.Forms.Button çik;
    }
}

