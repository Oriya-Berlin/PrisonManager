namespace PrisonManager
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Penalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxSearchFront = new System.Windows.Forms.PictureBox();
            this.pictureBoxSearchSide = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddExit = new System.Windows.Forms.Button();
            this.buttonDeletePrisoner = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchSide)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxSearch.Location = new System.Drawing.Point(132, 34);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(327, 30);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AllowUserToAddRows = false;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.First_Name,
            this.Last_Name,
            this.ID,
            this.Gender,
            this.Crime,
            this.Penalty,
            this.Date});
            this.dataGridViewSearch.Location = new System.Drawing.Point(26, 108);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowTemplate.Height = 24;
            this.dataGridViewSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearch.Size = new System.Drawing.Size(1276, 296);
            this.dataGridViewSearch.TabIndex = 2;
            this.dataGridViewSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewSearch_MouseClick);
            // 
            // First_Name
            // 
            this.First_Name.HeaderText = "First Name";
            this.First_Name.Name = "First_Name";
            this.First_Name.ReadOnly = true;
            this.First_Name.Width = 150;
            // 
            // Last_Name
            // 
            this.Last_Name.HeaderText = "Last Name";
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.ReadOnly = true;
            this.Last_Name.Width = 150;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 120;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 80;
            // 
            // Crime
            // 
            this.Crime.HeaderText = "Crime";
            this.Crime.Name = "Crime";
            this.Crime.ReadOnly = true;
            this.Crime.Width = 150;
            // 
            // Penalty
            // 
            this.Penalty.HeaderText = "Penalty (Months)";
            this.Penalty.Name = "Penalty";
            this.Penalty.ReadOnly = true;
            this.Penalty.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 115;
            // 
            // pictureBoxSearchFront
            // 
            this.pictureBoxSearchFront.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearchFront.Image")));
            this.pictureBoxSearchFront.Location = new System.Drawing.Point(784, 446);
            this.pictureBoxSearchFront.Name = "pictureBoxSearchFront";
            this.pictureBoxSearchFront.Size = new System.Drawing.Size(244, 272);
            this.pictureBoxSearchFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearchFront.TabIndex = 3;
            this.pictureBoxSearchFront.TabStop = false;
            // 
            // pictureBoxSearchSide
            // 
            this.pictureBoxSearchSide.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearchSide.Image")));
            this.pictureBoxSearchSide.Location = new System.Drawing.Point(1058, 446);
            this.pictureBoxSearchSide.Name = "pictureBoxSearchSide";
            this.pictureBoxSearchSide.Size = new System.Drawing.Size(244, 272);
            this.pictureBoxSearchSide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearchSide.TabIndex = 4;
            this.pictureBoxSearchSide.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "here we put the prisoner data";
            // 
            // buttonAddExit
            // 
            this.buttonAddExit.BackColor = System.Drawing.Color.Firebrick;
            this.buttonAddExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAddExit.Location = new System.Drawing.Point(1190, 767);
            this.buttonAddExit.Name = "buttonAddExit";
            this.buttonAddExit.Size = new System.Drawing.Size(112, 41);
            this.buttonAddExit.TabIndex = 25;
            this.buttonAddExit.Text = "Exit";
            this.buttonAddExit.UseVisualStyleBackColor = false;
            this.buttonAddExit.Click += new System.EventHandler(this.buttonAddExit_Click);
            // 
            // buttonDeletePrisoner
            // 
            this.buttonDeletePrisoner.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonDeletePrisoner.Location = new System.Drawing.Point(28, 770);
            this.buttonDeletePrisoner.Name = "buttonDeletePrisoner";
            this.buttonDeletePrisoner.Size = new System.Drawing.Size(181, 38);
            this.buttonDeletePrisoner.TabIndex = 28;
            this.buttonDeletePrisoner.Text = "Delete Prisoner";
            this.buttonDeletePrisoner.UseVisualStyleBackColor = true;
            this.buttonDeletePrisoner.Click += new System.EventHandler(this.buttonDeletePrisoner_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxID.Location = new System.Drawing.Point(1104, 34);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(198, 30);
            this.textBoxID.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(410, 511);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 30;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 845);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonDeletePrisoner);
            this.Controls.Add(this.buttonAddExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxSearchSide);
            this.Controls.Add(this.pictureBoxSearchFront);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.TextBoxSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchSide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.PictureBox pictureBoxSearchFront;
        private System.Windows.Forms.PictureBox pictureBoxSearchSide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddExit;
        private System.Windows.Forms.Button buttonDeletePrisoner;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Penalty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.TextBox textBox1;
    }
}