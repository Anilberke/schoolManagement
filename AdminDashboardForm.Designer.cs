using System.ComponentModel;

namespace schoolManagementSystem
{
    partial class AdminDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            this.adminDashboardTitle = new System.Windows.Forms.Label();
            this.studentSettingsButton = new System.Windows.Forms.Button();
            this.cardSettingsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminDashboardTurnOffButton = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.studentSettingsImage = new System.Windows.Forms.PictureBox();
            this.cardSettingsImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminDashboardTurnOffButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSettingsImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSettingsImage)).BeginInit();
            this.SuspendLayout();
            // 
            // adminDashboardTitle
            // 
            this.adminDashboardTitle.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminDashboardTitle.ForeColor = System.Drawing.Color.Red;
            this.adminDashboardTitle.Location = new System.Drawing.Point(140, 111);
            this.adminDashboardTitle.Name = "adminDashboardTitle";
            this.adminDashboardTitle.Size = new System.Drawing.Size(191, 34);
            this.adminDashboardTitle.TabIndex = 0;
            this.adminDashboardTitle.Text = "ADMIN DASHBOARD";
            // 
            // studentSettingsButton
            // 
            this.studentSettingsButton.BackColor = System.Drawing.SystemColors.Info;
            this.studentSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentSettingsButton.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentSettingsButton.Location = new System.Drawing.Point(140, 214);
            this.studentSettingsButton.Name = "studentSettingsButton";
            this.studentSettingsButton.Size = new System.Drawing.Size(248, 196);
            this.studentSettingsButton.TabIndex = 0;
            this.studentSettingsButton.Text = "Student Settings";
            this.studentSettingsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.studentSettingsButton.UseVisualStyleBackColor = false;
            // 
            // cardSettingsButton
            // 
            this.cardSettingsButton.BackColor = System.Drawing.SystemColors.Info;
            this.cardSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardSettingsButton.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cardSettingsButton.Location = new System.Drawing.Point(697, 214);
            this.cardSettingsButton.Name = "cardSettingsButton";
            this.cardSettingsButton.Size = new System.Drawing.Size(248, 196);
            this.cardSettingsButton.TabIndex = 1;
            this.cardSettingsButton.Text = "Card Settings";
            this.cardSettingsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cardSettingsButton.UseMnemonic = false;
            this.cardSettingsButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(140, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(511, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please select one of these options.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.adminDashboardTurnOffButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 83);
            this.panel1.TabIndex = 3;
            // 
            // adminDashboardTurnOffButton
            // 
            this.adminDashboardTurnOffButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.adminDashboardTurnOffButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminDashboardTurnOffButton.Image = ((System.Drawing.Image)(resources.GetObject("adminDashboardTurnOffButton.Image")));
            this.adminDashboardTurnOffButton.Location = new System.Drawing.Point(1008, 20);
            this.adminDashboardTurnOffButton.Name = "adminDashboardTurnOffButton";
            this.adminDashboardTurnOffButton.Size = new System.Drawing.Size(52, 47);
            this.adminDashboardTurnOffButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminDashboardTurnOffButton.TabIndex = 6;
            this.adminDashboardTurnOffButton.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(141, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "STUDENT MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTime.Location = new System.Drawing.Point(909, 475);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(163, 25);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "TIME";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // studentSettingsImage
            // 
            this.studentSettingsImage.BackColor = System.Drawing.SystemColors.Info;
            this.studentSettingsImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentSettingsImage.Image = ((System.Drawing.Image)(resources.GetObject("studentSettingsImage.Image")));
            this.studentSettingsImage.Location = new System.Drawing.Point(151, 248);
            this.studentSettingsImage.Name = "studentSettingsImage";
            this.studentSettingsImage.Size = new System.Drawing.Size(228, 148);
            this.studentSettingsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentSettingsImage.TabIndex = 5;
            this.studentSettingsImage.TabStop = false;
            // 
            // cardSettingsImage
            // 
            this.cardSettingsImage.BackColor = System.Drawing.SystemColors.Info;
            this.cardSettingsImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardSettingsImage.Image = ((System.Drawing.Image)(resources.GetObject("cardSettingsImage.Image")));
            this.cardSettingsImage.Location = new System.Drawing.Point(709, 248);
            this.cardSettingsImage.Name = "cardSettingsImage";
            this.cardSettingsImage.Size = new System.Drawing.Size(227, 148);
            this.cardSettingsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardSettingsImage.TabIndex = 5;
            this.cardSettingsImage.TabStop = false;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1084, 509);
            this.Controls.Add(this.cardSettingsImage);
            this.Controls.Add(this.studentSettingsImage);
            this.Controls.Add(this.adminDashboardTitle);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cardSettingsButton);
            this.Controls.Add(this.studentSettingsButton);
            this.MaximizeBox = false;
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminDashboardTurnOffButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSettingsImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSettingsImage)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox adminDashboardTurnOffButton;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.PictureBox studentSettingsImage;
        private System.Windows.Forms.PictureBox cardSettingsImage;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label labelTime;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button cardSettingsButton;

        private System.Windows.Forms.Button studentSettingsButton;

        private System.Windows.Forms.Label adminDashboardTitle;

        #endregion
    }
}