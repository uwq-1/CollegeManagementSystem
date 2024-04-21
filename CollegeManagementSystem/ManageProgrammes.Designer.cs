namespace CollegeManagementSystem
{
    partial class ManageProgrammes
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
            this.gvSProgrammeList = new System.Windows.Forms.DataGridView();
            this.lbltypesOfProgramme = new System.Windows.Forms.Label();
            this.btnaddProgramme = new System.Windows.Forms.Button();
            this.btneditProgramme = new System.Windows.Forms.Button();
            this.btndeleteProgramme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvSProgrammeList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvSProgrammeList
            // 
            this.gvSProgrammeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSProgrammeList.Location = new System.Drawing.Point(12, 126);
            this.gvSProgrammeList.Name = "gvSProgrammeList";
            this.gvSProgrammeList.Size = new System.Drawing.Size(811, 286);
            this.gvSProgrammeList.TabIndex = 0;
            // 
            // lbltypesOfProgramme
            // 
            this.lbltypesOfProgramme.AutoSize = true;
            this.lbltypesOfProgramme.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltypesOfProgramme.Location = new System.Drawing.Point(217, 18);
            this.lbltypesOfProgramme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltypesOfProgramme.Name = "lbltypesOfProgramme";
            this.lbltypesOfProgramme.Size = new System.Drawing.Size(517, 55);
            this.lbltypesOfProgramme.TabIndex = 1;
            this.lbltypesOfProgramme.Text = "Types Of Programme List";
            // 
            // btnaddProgramme
            // 
            this.btnaddProgramme.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddProgramme.Location = new System.Drawing.Point(27, 435);
            this.btnaddProgramme.Margin = new System.Windows.Forms.Padding(4);
            this.btnaddProgramme.Name = "btnaddProgramme";
            this.btnaddProgramme.Size = new System.Drawing.Size(205, 47);
            this.btnaddProgramme.TabIndex = 12;
            this.btnaddProgramme.Text = "Add Programme";
            this.btnaddProgramme.UseVisualStyleBackColor = true;
            this.btnaddProgramme.Click += new System.EventHandler(this.btnaddProgramme_Click);
            // 
            // btneditProgramme
            // 
            this.btneditProgramme.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditProgramme.Location = new System.Drawing.Point(301, 435);
            this.btneditProgramme.Margin = new System.Windows.Forms.Padding(4);
            this.btneditProgramme.Name = "btneditProgramme";
            this.btneditProgramme.Size = new System.Drawing.Size(205, 47);
            this.btneditProgramme.TabIndex = 13;
            this.btneditProgramme.Text = "Edit Programme";
            this.btneditProgramme.UseVisualStyleBackColor = true;
            this.btneditProgramme.Click += new System.EventHandler(this.btneditProgramme_Click);
            // 
            // btndeleteProgramme
            // 
            this.btndeleteProgramme.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteProgramme.Location = new System.Drawing.Point(618, 435);
            this.btndeleteProgramme.Margin = new System.Windows.Forms.Padding(4);
            this.btndeleteProgramme.Name = "btndeleteProgramme";
            this.btndeleteProgramme.Size = new System.Drawing.Size(205, 47);
            this.btndeleteProgramme.TabIndex = 14;
            this.btndeleteProgramme.Text = "Delete Programme";
            this.btndeleteProgramme.UseVisualStyleBackColor = true;
            this.btndeleteProgramme.Click += new System.EventHandler(this.btndeleteProgramme_Click);
            // 
            // ManageProgrammes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 495);
            this.Controls.Add(this.btndeleteProgramme);
            this.Controls.Add(this.btneditProgramme);
            this.Controls.Add(this.btnaddProgramme);
            this.Controls.Add(this.lbltypesOfProgramme);
            this.Controls.Add(this.gvSProgrammeList);
            this.Name = "ManageProgrammes";
            this.Text = "Manage Programmes";
            this.Load += new System.EventHandler(this.ManageProgrammes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSProgrammeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvSProgrammeList;
        private System.Windows.Forms.Label lbltypesOfProgramme;
        private System.Windows.Forms.Button btnaddProgramme;
        private System.Windows.Forms.Button btneditProgramme;
        private System.Windows.Forms.Button btndeleteProgramme;
    }
}