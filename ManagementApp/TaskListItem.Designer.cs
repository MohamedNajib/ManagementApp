
namespace ManagementApp
{
    partial class TaskListItem
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
            this.itemPanel = new Guna.UI.WinForms.GunaPanel();
            this.taskBtnState = new Guna.UI.WinForms.GunaAdvenceButton();
            this.taskLabelDes = new System.Windows.Forms.Label();
            this.taskLabelTitle = new System.Windows.Forms.Label();
            this.itemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemPanel
            // 
            this.itemPanel.Controls.Add(this.taskBtnState);
            this.itemPanel.Controls.Add(this.taskLabelDes);
            this.itemPanel.Controls.Add(this.taskLabelTitle);
            this.itemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel.Location = new System.Drawing.Point(0, 0);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(342, 75);
            this.itemPanel.TabIndex = 0;
            this.itemPanel.Click += new System.EventHandler(this.onItemClicked);
            // 
            // taskBtnState
            // 
            this.taskBtnState.AnimationHoverSpeed = 0.07F;
            this.taskBtnState.AnimationSpeed = 0.03F;
            this.taskBtnState.BackColor = System.Drawing.Color.Transparent;
            this.taskBtnState.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.taskBtnState.BorderColor = System.Drawing.Color.Black;
            this.taskBtnState.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.taskBtnState.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.taskBtnState.CheckedForeColor = System.Drawing.Color.White;
            this.taskBtnState.CheckedImage = null;
            this.taskBtnState.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.taskBtnState.DialogResult = System.Windows.Forms.DialogResult.None;
            this.taskBtnState.FocusedColor = System.Drawing.Color.Empty;
            this.taskBtnState.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.taskBtnState.ForeColor = System.Drawing.Color.White;
            this.taskBtnState.Image = null;
            this.taskBtnState.ImageSize = new System.Drawing.Size(20, 20);
            this.taskBtnState.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.taskBtnState.Location = new System.Drawing.Point(277, 11);
            this.taskBtnState.Name = "taskBtnState";
            this.taskBtnState.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.taskBtnState.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.taskBtnState.OnHoverForeColor = System.Drawing.Color.White;
            this.taskBtnState.OnHoverImage = null;
            this.taskBtnState.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.taskBtnState.OnPressedColor = System.Drawing.Color.Black;
            this.taskBtnState.Radius = 5;
            this.taskBtnState.Size = new System.Drawing.Size(55, 21);
            this.taskBtnState.TabIndex = 9;
            this.taskBtnState.Text = "New";
            this.taskBtnState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // taskLabelDes
            // 
            this.taskLabelDes.AutoSize = true;
            this.taskLabelDes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(152)))), ((int)(((byte)(130)))));
            this.taskLabelDes.Location = new System.Drawing.Point(15, 47);
            this.taskLabelDes.Name = "taskLabelDes";
            this.taskLabelDes.Size = new System.Drawing.Size(172, 17);
            this.taskLabelDes.TabIndex = 8;
            this.taskLabelDes.Text = "This is my Task Discreption";
            this.taskLabelDes.Click += new System.EventHandler(this.onItemClicked);
            // 
            // taskLabelTitle
            // 
            this.taskLabelTitle.AutoSize = true;
            this.taskLabelTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.taskLabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.taskLabelTitle.Location = new System.Drawing.Point(11, 12);
            this.taskLabelTitle.Name = "taskLabelTitle";
            this.taskLabelTitle.Size = new System.Drawing.Size(105, 28);
            this.taskLabelTitle.TabIndex = 7;
            this.taskLabelTitle.Text = "Task Name";
            this.taskLabelTitle.Click += new System.EventHandler(this.onItemClicked);
            // 
            // TaskListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.itemPanel);
            this.Name = "TaskListItem";
            this.Size = new System.Drawing.Size(342, 75);
            this.itemPanel.ResumeLayout(false);
            this.itemPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel itemPanel;
        private Guna.UI.WinForms.GunaAdvenceButton taskBtnState;
        private System.Windows.Forms.Label taskLabelDes;
        private System.Windows.Forms.Label taskLabelTitle;
    }
}
