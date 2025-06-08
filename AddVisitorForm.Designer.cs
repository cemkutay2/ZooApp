namespace ZooApp
{
    partial class AddVisitorForm
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
            this.cmbBox_TicketType = new System.Windows.Forms.ComboBox();
            this.btn_SaveVisitor = new System.Windows.Forms.Button();
            this.dtp_VisitDate = new System.Windows.Forms.DateTimePicker();
            this.txtBox_FullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbBox_TicketType
            // 
            this.cmbBox_TicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_TicketType.FormattingEnabled = true;
            this.cmbBox_TicketType.Items.AddRange(new object[] {
            "Tam",
            "Ogrenci"});
            this.cmbBox_TicketType.Location = new System.Drawing.Point(72, 180);
            this.cmbBox_TicketType.Name = "cmbBox_TicketType";
            this.cmbBox_TicketType.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_TicketType.TabIndex = 9;
            // 
            // btn_SaveVisitor
            // 
            this.btn_SaveVisitor.Location = new System.Drawing.Point(72, 219);
            this.btn_SaveVisitor.Name = "btn_SaveVisitor";
            this.btn_SaveVisitor.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveVisitor.TabIndex = 8;
            this.btn_SaveVisitor.Text = "Ekle";
            this.btn_SaveVisitor.UseVisualStyleBackColor = true;
            this.btn_SaveVisitor.Click += new System.EventHandler(this.btn_SaveVisitor_Click);
            // 
            // dtp_VisitDate
            // 
            this.dtp_VisitDate.Location = new System.Drawing.Point(72, 125);
            this.dtp_VisitDate.Name = "dtp_VisitDate";
            this.dtp_VisitDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_VisitDate.TabIndex = 7;
            // 
            // txtBox_FullName
            // 
            this.txtBox_FullName.Location = new System.Drawing.Point(72, 71);
            this.txtBox_FullName.Name = "txtBox_FullName";
            this.txtBox_FullName.Size = new System.Drawing.Size(100, 20);
            this.txtBox_FullName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ziyaret Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bilet Çeşidi";
            // 
            // AddVisitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBox_TicketType);
            this.Controls.Add(this.btn_SaveVisitor);
            this.Controls.Add(this.dtp_VisitDate);
            this.Controls.Add(this.txtBox_FullName);
            this.Name = "AddVisitorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ziyaretçi Ekle";
            this.Load += new System.EventHandler(this.AddVisitorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBox_TicketType;
        private System.Windows.Forms.Button btn_SaveVisitor;
        private System.Windows.Forms.DateTimePicker dtp_VisitDate;
        private System.Windows.Forms.TextBox txtBox_FullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}