namespace ZooApp
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
            this.dataGridView_Animals = new System.Windows.Forms.DataGridView();
            this.btn_AnimalSearch = new System.Windows.Forms.Button();
            this.btn_AnimalNewEntry = new System.Windows.Forms.Button();
            this.btn_AnimalDelete = new System.Windows.Forms.Button();
            this.txtBox_Animal = new System.Windows.Forms.TextBox();
            this.txtBox_Visitor = new System.Windows.Forms.TextBox();
            this.btn_VisitorDelete = new System.Windows.Forms.Button();
            this.btn_VisitorNewEntry = new System.Windows.Forms.Button();
            this.btn_VisitorSearch = new System.Windows.Forms.Button();
            this.dataGridView_Visitors = new System.Windows.Forms.DataGridView();
            this.dataGridView_Visits = new System.Windows.Forms.DataGridView();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.btn_SearchDates = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Animals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Visitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Visits)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Animals
            // 
            this.dataGridView_Animals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Animals.Location = new System.Drawing.Point(12, 75);
            this.dataGridView_Animals.Name = "dataGridView_Animals";
            this.dataGridView_Animals.Size = new System.Drawing.Size(645, 262);
            this.dataGridView_Animals.TabIndex = 0;
            // 
            // btn_AnimalSearch
            // 
            this.btn_AnimalSearch.Location = new System.Drawing.Point(140, 46);
            this.btn_AnimalSearch.Name = "btn_AnimalSearch";
            this.btn_AnimalSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_AnimalSearch.TabIndex = 1;
            this.btn_AnimalSearch.Text = "Ara";
            this.btn_AnimalSearch.UseVisualStyleBackColor = true;
            this.btn_AnimalSearch.Click += new System.EventHandler(this.btn_AnimalSearch_Click);
            // 
            // btn_AnimalNewEntry
            // 
            this.btn_AnimalNewEntry.Location = new System.Drawing.Point(221, 46);
            this.btn_AnimalNewEntry.Name = "btn_AnimalNewEntry";
            this.btn_AnimalNewEntry.Size = new System.Drawing.Size(75, 23);
            this.btn_AnimalNewEntry.TabIndex = 2;
            this.btn_AnimalNewEntry.Text = "Yeni Kayıt";
            this.btn_AnimalNewEntry.UseVisualStyleBackColor = true;
            this.btn_AnimalNewEntry.Click += new System.EventHandler(this.btn_AnimalNewEntry_Click);
            // 
            // btn_AnimalDelete
            // 
            this.btn_AnimalDelete.Location = new System.Drawing.Point(408, 46);
            this.btn_AnimalDelete.Name = "btn_AnimalDelete";
            this.btn_AnimalDelete.Size = new System.Drawing.Size(75, 23);
            this.btn_AnimalDelete.TabIndex = 3;
            this.btn_AnimalDelete.Text = "Kaydı Sil";
            this.btn_AnimalDelete.UseVisualStyleBackColor = true;
            this.btn_AnimalDelete.Click += new System.EventHandler(this.btn_AnimalDelete_Click);
            // 
            // txtBox_Animal
            // 
            this.txtBox_Animal.Location = new System.Drawing.Point(12, 46);
            this.txtBox_Animal.Name = "txtBox_Animal";
            this.txtBox_Animal.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Animal.TabIndex = 4;
            // 
            // txtBox_Visitor
            // 
            this.txtBox_Visitor.Location = new System.Drawing.Point(9, 373);
            this.txtBox_Visitor.Name = "txtBox_Visitor";
            this.txtBox_Visitor.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Visitor.TabIndex = 9;
            // 
            // btn_VisitorDelete
            // 
            this.btn_VisitorDelete.Location = new System.Drawing.Point(357, 371);
            this.btn_VisitorDelete.Name = "btn_VisitorDelete";
            this.btn_VisitorDelete.Size = new System.Drawing.Size(75, 23);
            this.btn_VisitorDelete.TabIndex = 8;
            this.btn_VisitorDelete.Text = "Kaydı Sil";
            this.btn_VisitorDelete.UseVisualStyleBackColor = true;
            this.btn_VisitorDelete.Click += new System.EventHandler(this.btn_VisitorDelete_Click);
            // 
            // btn_VisitorNewEntry
            // 
            this.btn_VisitorNewEntry.Location = new System.Drawing.Point(218, 371);
            this.btn_VisitorNewEntry.Name = "btn_VisitorNewEntry";
            this.btn_VisitorNewEntry.Size = new System.Drawing.Size(75, 23);
            this.btn_VisitorNewEntry.TabIndex = 7;
            this.btn_VisitorNewEntry.Text = "Yeni Kayıt";
            this.btn_VisitorNewEntry.UseVisualStyleBackColor = true;
            this.btn_VisitorNewEntry.Click += new System.EventHandler(this.btn_VisitorNewEntry_Click);
            // 
            // btn_VisitorSearch
            // 
            this.btn_VisitorSearch.Location = new System.Drawing.Point(137, 370);
            this.btn_VisitorSearch.Name = "btn_VisitorSearch";
            this.btn_VisitorSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_VisitorSearch.TabIndex = 6;
            this.btn_VisitorSearch.Text = "Ara";
            this.btn_VisitorSearch.UseVisualStyleBackColor = true;
            this.btn_VisitorSearch.Click += new System.EventHandler(this.btn_VisitorSearch_Click);
            // 
            // dataGridView_Visitors
            // 
            this.dataGridView_Visitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Visitors.Location = new System.Drawing.Point(9, 400);
            this.dataGridView_Visitors.Name = "dataGridView_Visitors";
            this.dataGridView_Visitors.Size = new System.Drawing.Size(445, 262);
            this.dataGridView_Visitors.TabIndex = 5;
            // 
            // dataGridView_Visits
            // 
            this.dataGridView_Visits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Visits.Location = new System.Drawing.Point(787, 219);
            this.dataGridView_Visits.Name = "dataGridView_Visits";
            this.dataGridView_Visits.Size = new System.Drawing.Size(355, 325);
            this.dataGridView_Visits.TabIndex = 10;
            // 
            // dtp_Start
            // 
            this.dtp_Start.Location = new System.Drawing.Point(737, 161);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(200, 20);
            this.dtp_Start.TabIndex = 11;
            // 
            // dtp_End
            // 
            this.dtp_End.Location = new System.Drawing.Point(982, 161);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(200, 20);
            this.dtp_End.TabIndex = 12;
            // 
            // btn_SearchDates
            // 
            this.btn_SearchDates.Location = new System.Drawing.Point(925, 190);
            this.btn_SearchDates.Name = "btn_SearchDates";
            this.btn_SearchDates.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchDates.TabIndex = 13;
            this.btn_SearchDates.Text = "Ara";
            this.btn_SearchDates.UseVisualStyleBackColor = true;
            this.btn_SearchDates.Click += new System.EventHandler(this.btn_SearchDates_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hayvanlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ziyaretçiler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ziyaretler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SearchDates);
            this.Controls.Add(this.dtp_End);
            this.Controls.Add(this.dtp_Start);
            this.Controls.Add(this.dataGridView_Visits);
            this.Controls.Add(this.txtBox_Visitor);
            this.Controls.Add(this.btn_VisitorDelete);
            this.Controls.Add(this.btn_VisitorNewEntry);
            this.Controls.Add(this.btn_VisitorSearch);
            this.Controls.Add(this.dataGridView_Visitors);
            this.Controls.Add(this.txtBox_Animal);
            this.Controls.Add(this.btn_AnimalDelete);
            this.Controls.Add(this.btn_AnimalNewEntry);
            this.Controls.Add(this.btn_AnimalSearch);
            this.Controls.Add(this.dataGridView_Animals);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZooApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Animals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Visitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Visits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Animals;
        private System.Windows.Forms.Button btn_AnimalSearch;
        private System.Windows.Forms.Button btn_AnimalNewEntry;
        private System.Windows.Forms.Button btn_AnimalDelete;
        private System.Windows.Forms.TextBox txtBox_Animal;
        private System.Windows.Forms.TextBox txtBox_Visitor;
        private System.Windows.Forms.Button btn_VisitorDelete;
        private System.Windows.Forms.Button btn_VisitorNewEntry;
        private System.Windows.Forms.Button btn_VisitorSearch;
        private System.Windows.Forms.DataGridView dataGridView_Visitors;
        private System.Windows.Forms.DataGridView dataGridView_Visits;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.Button btn_SearchDates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

