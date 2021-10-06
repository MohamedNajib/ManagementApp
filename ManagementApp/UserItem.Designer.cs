
namespace ManagementApp
{
    partial class UserItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.userPhoneLabel = new System.Windows.Forms.Label();
            this.userEmailLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel1.Location = new System.Drawing.Point(834, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(11, 58);
            this.gunaPanel1.TabIndex = 3;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.gunaPanel2.Controls.Add(this.userPhoneLabel);
            this.gunaPanel2.Controls.Add(this.userEmailLabel);
            this.gunaPanel2.Controls.Add(this.userNameLabel);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(834, 58);
            this.gunaPanel2.TabIndex = 4;
            // 
            // userPhoneLabel
            // 
            this.userPhoneLabel.AutoSize = true;
            this.userPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.userPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(240)))), ((int)(((byte)(215)))));
            this.userPhoneLabel.Location = new System.Drawing.Point(494, 20);
            this.userPhoneLabel.Name = "userPhoneLabel";
            this.userPhoneLabel.Size = new System.Drawing.Size(55, 23);
            this.userPhoneLabel.TabIndex = 5;
            this.userPhoneLabel.Text = "label1";
            // 
            // userEmailLabel
            // 
            this.userEmailLabel.AutoSize = true;
            this.userEmailLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.userEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(240)))), ((int)(((byte)(215)))));
            this.userEmailLabel.Location = new System.Drawing.Point(227, 20);
            this.userEmailLabel.Name = "userEmailLabel";
            this.userEmailLabel.Size = new System.Drawing.Size(55, 23);
            this.userEmailLabel.TabIndex = 4;
            this.userEmailLabel.Text = "label1";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(240)))), ((int)(((byte)(215)))));
            this.userNameLabel.Location = new System.Drawing.Point(23, 20);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(55, 23);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "label1";
            // 
            // UserItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "UserItem";
            this.Size = new System.Drawing.Size(845, 58);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private System.Windows.Forms.Label userPhoneLabel;
        private System.Windows.Forms.Label userEmailLabel;
        private System.Windows.Forms.Label userNameLabel;
    }
}
