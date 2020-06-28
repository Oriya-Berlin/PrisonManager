namespace PrisonManager
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.pictureBoxFrontUpdateForm = new System.Windows.Forms.PictureBox();
            this.pictureBoxSideUpdateForm = new System.Windows.Forms.PictureBox();
            this.textBoxFnameUpdateForm = new System.Windows.Forms.TextBox();
            this.textBoxLnameUpdateForm = new System.Windows.Forms.TextBox();
            this.textBoxPenaltyUpdateForm = new System.Windows.Forms.TextBox();
            this.dataGridViewUpdate = new System.Windows.Forms.DataGridView();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Penalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonExitUpdateForm = new System.Windows.Forms.Button();
            this.buttonUPDATE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddSide = new System.Windows.Forms.Button();
            this.buttonAddFront = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearchUpdateForm = new System.Windows.Forms.TextBox();
            this.textBoxIDNumberUpdateForm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrontUpdateForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSideUpdateForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFrontUpdateForm
            // 
            this.pictureBoxFrontUpdateForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFrontUpdateForm.Image")));
            this.pictureBoxFrontUpdateForm.Location = new System.Drawing.Point(741, 56);
            this.pictureBoxFrontUpdateForm.Name = "pictureBoxFrontUpdateForm";
            this.pictureBoxFrontUpdateForm.Size = new System.Drawing.Size(233, 269);
            this.pictureBoxFrontUpdateForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFrontUpdateForm.TabIndex = 0;
            this.pictureBoxFrontUpdateForm.TabStop = false;
            // 
            // pictureBoxSideUpdateForm
            // 
            this.pictureBoxSideUpdateForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSideUpdateForm.Image")));
            this.pictureBoxSideUpdateForm.Location = new System.Drawing.Point(1022, 56);
            this.pictureBoxSideUpdateForm.Name = "pictureBoxSideUpdateForm";
            this.pictureBoxSideUpdateForm.Size = new System.Drawing.Size(233, 269);
            this.pictureBoxSideUpdateForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSideUpdateForm.TabIndex = 1;
            this.pictureBoxSideUpdateForm.TabStop = false;
            // 
            // textBoxFnameUpdateForm
            // 
            this.textBoxFnameUpdateForm.Location = new System.Drawing.Point(176, 193);
            this.textBoxFnameUpdateForm.Name = "textBoxFnameUpdateForm";
            this.textBoxFnameUpdateForm.Size = new System.Drawing.Size(262, 22);
            this.textBoxFnameUpdateForm.TabIndex = 2;
            // 
            // textBoxLnameUpdateForm
            // 
            this.textBoxLnameUpdateForm.Location = new System.Drawing.Point(176, 247);
            this.textBoxLnameUpdateForm.Name = "textBoxLnameUpdateForm";
            this.textBoxLnameUpdateForm.Size = new System.Drawing.Size(262, 22);
            this.textBoxLnameUpdateForm.TabIndex = 3;
            // 
            // textBoxPenaltyUpdateForm
            // 
            this.textBoxPenaltyUpdateForm.Location = new System.Drawing.Point(176, 301);
            this.textBoxPenaltyUpdateForm.Name = "textBoxPenaltyUpdateForm";
            this.textBoxPenaltyUpdateForm.Size = new System.Drawing.Size(262, 22);
            this.textBoxPenaltyUpdateForm.TabIndex = 4;
            // 
            // dataGridViewUpdate
            // 
            this.dataGridViewUpdate.AllowUserToAddRows = false;
            this.dataGridViewUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.First_Name,
            this.Last_Name,
            this.ID,
            this.Gender,
            this.Crime,
            this.Penalty,
            this.Date});
            this.dataGridViewUpdate.Location = new System.Drawing.Point(45, 393);
            this.dataGridViewUpdate.Name = "dataGridViewUpdate";
            this.dataGridViewUpdate.RowTemplate.Height = 24;
            this.dataGridViewUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUpdate.Size = new System.Drawing.Size(1276, 296);
            this.dataGridViewUpdate.TabIndex = 5;
            this.dataGridViewUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewUpdate_MouseClick);
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
            // buttonExitUpdateForm
            // 
            this.buttonExitUpdateForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonExitUpdateForm.Location = new System.Drawing.Point(1200, 725);
            this.buttonExitUpdateForm.Name = "buttonExitUpdateForm";
            this.buttonExitUpdateForm.Size = new System.Drawing.Size(121, 39);
            this.buttonExitUpdateForm.TabIndex = 6;
            this.buttonExitUpdateForm.Text = "Exit";
            this.buttonExitUpdateForm.UseVisualStyleBackColor = true;
            this.buttonExitUpdateForm.Click += new System.EventHandler(this.buttonExitUpdateForm_Click);
            // 
            // buttonUPDATE
            // 
            this.buttonUPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonUPDATE.Location = new System.Drawing.Point(45, 725);
            this.buttonUPDATE.Name = "buttonUPDATE";
            this.buttonUPDATE.Size = new System.Drawing.Size(121, 39);
            this.buttonUPDATE.TabIndex = 7;
            this.buttonUPDATE.Text = "Update";
            this.buttonUPDATE.UseVisualStyleBackColor = true;
            this.buttonUPDATE.Click += new System.EventHandler(this.buttonUPDATE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(42, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(42, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(42, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Penalty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(1107, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Side";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(825, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Front";
            // 
            // buttonAddSide
            // 
            this.buttonAddSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAddSide.Location = new System.Drawing.Point(1097, 343);
            this.buttonAddSide.Name = "buttonAddSide";
            this.buttonAddSide.Size = new System.Drawing.Size(91, 30);
            this.buttonAddSide.TabIndex = 14;
            this.buttonAddSide.Text = "Add...";
            this.buttonAddSide.UseVisualStyleBackColor = true;
            this.buttonAddSide.Click += new System.EventHandler(this.buttonAddSide_Click);
            // 
            // buttonAddFront
            // 
            this.buttonAddFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAddFront.Location = new System.Drawing.Point(818, 343);
            this.buttonAddFront.Name = "buttonAddFront";
            this.buttonAddFront.Size = new System.Drawing.Size(91, 30);
            this.buttonAddFront.TabIndex = 15;
            this.buttonAddFront.Text = "Add...";
            this.buttonAddFront.UseVisualStyleBackColor = true;
            this.buttonAddFront.Click += new System.EventHandler(this.buttonAddFront_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(40, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Search:";
            // 
            // textBoxSearchUpdateForm
            // 
            this.textBoxSearchUpdateForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxSearchUpdateForm.Location = new System.Drawing.Point(176, 56);
            this.textBoxSearchUpdateForm.Name = "textBoxSearchUpdateForm";
            this.textBoxSearchUpdateForm.Size = new System.Drawing.Size(406, 34);
            this.textBoxSearchUpdateForm.TabIndex = 17;
            this.textBoxSearchUpdateForm.TextChanged += new System.EventHandler(this.textBoxSearchUpdateForm_TextChanged);
            // 
            // textBoxIDNumberUpdateForm
            // 
            this.textBoxIDNumberUpdateForm.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxIDNumberUpdateForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxIDNumberUpdateForm.Location = new System.Drawing.Point(176, 132);
            this.textBoxIDNumberUpdateForm.Name = "textBoxIDNumberUpdateForm";
            this.textBoxIDNumberUpdateForm.ReadOnly = true;
            this.textBoxIDNumberUpdateForm.Size = new System.Drawing.Size(262, 28);
            this.textBoxIDNumberUpdateForm.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(41, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "ID Number:";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 776);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxIDNumberUpdateForm);
            this.Controls.Add(this.textBoxSearchUpdateForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddFront);
            this.Controls.Add(this.buttonAddSide);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUPDATE);
            this.Controls.Add(this.buttonExitUpdateForm);
            this.Controls.Add(this.dataGridViewUpdate);
            this.Controls.Add(this.textBoxPenaltyUpdateForm);
            this.Controls.Add(this.textBoxLnameUpdateForm);
            this.Controls.Add(this.textBoxFnameUpdateForm);
            this.Controls.Add(this.pictureBoxSideUpdateForm);
            this.Controls.Add(this.pictureBoxFrontUpdateForm);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrontUpdateForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSideUpdateForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFrontUpdateForm;
        private System.Windows.Forms.PictureBox pictureBoxSideUpdateForm;
        private System.Windows.Forms.TextBox textBoxFnameUpdateForm;
        private System.Windows.Forms.TextBox textBoxLnameUpdateForm;
        private System.Windows.Forms.TextBox textBoxPenaltyUpdateForm;
        private System.Windows.Forms.DataGridView dataGridViewUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Penalty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button buttonExitUpdateForm;
        private System.Windows.Forms.Button buttonUPDATE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddSide;
        private System.Windows.Forms.Button buttonAddFront;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearchUpdateForm;
        private System.Windows.Forms.TextBox textBoxIDNumberUpdateForm;
        private System.Windows.Forms.Label label7;
    }
}