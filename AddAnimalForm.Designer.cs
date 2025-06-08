namespace ZooApp
{
    partial class AddAnimalForm
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
            this.txtBox_AnimalName = new System.Windows.Forms.TextBox();
            this.txtBox_Species = new System.Windows.Forms.TextBox();
            this.txtBox_Habitat = new System.Windows.Forms.TextBox();
            this.dtp_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.btn_SaveAnimal = new System.Windows.Forms.Button();
            this.cmbBox_Health = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_AnimalName
            // 
            this.txtBox_AnimalName.Location = new System.Drawing.Point(73, 57);
            this.txtBox_AnimalName.Name = "txtBox_AnimalName";
            this.txtBox_AnimalName.Size = new System.Drawing.Size(100, 20);
            this.txtBox_AnimalName.TabIndex = 0;
            // 
            // txtBox_Species
            // 
            this.txtBox_Species.Location = new System.Drawing.Point(73, 94);
            this.txtBox_Species.Name = "txtBox_Species";
            this.txtBox_Species.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Species.TabIndex = 1;
            // 
            // txtBox_Habitat
            // 
            this.txtBox_Habitat.Location = new System.Drawing.Point(73, 173);
            this.txtBox_Habitat.Name = "txtBox_Habitat";
            this.txtBox_Habitat.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Habitat.TabIndex = 2;
            // 
            // dtp_BirthDate
            // 
            this.dtp_BirthDate.Location = new System.Drawing.Point(73, 134);
            this.dtp_BirthDate.Name = "dtp_BirthDate";
            this.dtp_BirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_BirthDate.TabIndex = 3;
            // 
            // btn_SaveAnimal
            // 
            this.btn_SaveAnimal.Location = new System.Drawing.Point(71, 238);
            this.btn_SaveAnimal.Name = "btn_SaveAnimal";
            this.btn_SaveAnimal.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveAnimal.TabIndex = 4;
            this.btn_SaveAnimal.Text = "Ekle";
            this.btn_SaveAnimal.UseVisualStyleBackColor = true;
            this.btn_SaveAnimal.Click += new System.EventHandler(this.btn_SaveAnimal_Click);
            // 
            // cmbBox_Health
            // 
            this.cmbBox_Health.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Health.FormattingEnabled = true;
            this.cmbBox_Health.Items.AddRange(new object[] {
            "Saglikli",
            "Tedavi Ediliyor",
            "Hasta"});
            this.cmbBox_Health.Location = new System.Drawing.Point(73, 211);
            this.cmbBox_Health.Name = "cmbBox_Health";
            this.cmbBox_Health.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_Health.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tür";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Habitat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sağlık Durumu";
            // 
            // AddAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 311);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBox_Health);
            this.Controls.Add(this.btn_SaveAnimal);
            this.Controls.Add(this.dtp_BirthDate);
            this.Controls.Add(this.txtBox_Habitat);
            this.Controls.Add(this.txtBox_Species);
            this.Controls.Add(this.txtBox_AnimalName);
            this.Name = "AddAnimalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hayvan Ekle";
            this.Load += new System.EventHandler(this.AddAnimalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_AnimalName;
        private System.Windows.Forms.TextBox txtBox_Species;
        private System.Windows.Forms.TextBox txtBox_Habitat;
        private System.Windows.Forms.DateTimePicker dtp_BirthDate;
        private System.Windows.Forms.Button btn_SaveAnimal;
        private System.Windows.Forms.ComboBox cmbBox_Health;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}