namespace PrisonManager
{
    partial class Options
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
            this.buttonAddPrisoner = new System.Windows.Forms.Button();
            this.buttonSearchAndDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddPrisoner
            // 
            this.buttonAddPrisoner.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAddPrisoner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAddPrisoner.Location = new System.Drawing.Point(63, 41);
            this.buttonAddPrisoner.Name = "buttonAddPrisoner";
            this.buttonAddPrisoner.Size = new System.Drawing.Size(678, 57);
            this.buttonAddPrisoner.TabIndex = 0;
            this.buttonAddPrisoner.Text = "Add Prisoner";
            this.buttonAddPrisoner.UseVisualStyleBackColor = false;
            this.buttonAddPrisoner.Click += new System.EventHandler(this.buttonAddPrisoner_Click);
            // 
            // buttonSearchAndDelete
            // 
            this.buttonSearchAndDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSearchAndDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSearchAndDelete.Location = new System.Drawing.Point(63, 114);
            this.buttonSearchAndDelete.Name = "buttonSearchAndDelete";
            this.buttonSearchAndDelete.Size = new System.Drawing.Size(678, 57);
            this.buttonSearchAndDelete.TabIndex = 1;
            this.buttonSearchAndDelete.Text = "Search / Delete";
            this.buttonSearchAndDelete.UseVisualStyleBackColor = false;
            this.buttonSearchAndDelete.Click += new System.EventHandler(this.buttonSearchAndDelete_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(63, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(678, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update Details";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Firebrick;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonExit.Location = new System.Drawing.Point(583, 371);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(158, 50);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonSearchAndDelete);
            this.Controls.Add(this.buttonAddPrisoner);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddPrisoner;
        private System.Windows.Forms.Button buttonSearchAndDelete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonExit;
    }
}