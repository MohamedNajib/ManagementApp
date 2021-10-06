
namespace ManagementApp
{
    partial class ProjectItem
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
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.addTaskButton = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.projectDesLabel = new System.Windows.Forms.Label();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.gunaPanelContainer = new Guna.UI.WinForms.GunaPanel();
            this.addTaskPanel = new Guna.UI.WinForms.GunaPanel();
            this.addNewTaskButton = new Guna.UI.WinForms.GunaButton();
            this.toDateTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.fromDateTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.calenderGroupBox = new Guna.UI.WinForms.GunaGroupBox();
            this.selectDateButton = new Guna.UI.WinForms.GunaButton();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.taskDesTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.taskNameTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.fromDateButton = new Guna.UI.WinForms.GunaButton();
            this.toDateButton = new Guna.UI.WinForms.GunaButton();
            this.closeAddTaskFormButton = new Guna.UI.WinForms.GunaImageButton();
            this.gunaPanel3.SuspendLayout();
            this.gunaPanelContainer.SuspendLayout();
            this.addTaskPanel.SuspendLayout();
            this.calenderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.gunaPanel3.Controls.Add(this.addTaskButton);
            this.gunaPanel3.Controls.Add(this.gunaSeparator1);
            this.gunaPanel3.Controls.Add(this.projectDesLabel);
            this.gunaPanel3.Controls.Add(this.projectNameLabel);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(355, 82);
            this.gunaPanel3.TabIndex = 5;
            // 
            // addTaskButton
            // 
            this.addTaskButton.AnimationHoverSpeed = 0.07F;
            this.addTaskButton.AnimationSpeed = 0.03F;
            this.addTaskButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(219)))), ((int)(((byte)(240)))));
            this.addTaskButton.BorderColor = System.Drawing.Color.Black;
            this.addTaskButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addTaskButton.FocusedColor = System.Drawing.Color.Empty;
            this.addTaskButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.addTaskButton.ForeColor = System.Drawing.Color.White;
            this.addTaskButton.Image = null;
            this.addTaskButton.ImageSize = new System.Drawing.Size(50, 50);
            this.addTaskButton.Location = new System.Drawing.Point(300, 12);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(219)))), ((int)(((byte)(240)))));
            this.addTaskButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addTaskButton.OnHoverForeColor = System.Drawing.Color.White;
            this.addTaskButton.OnHoverImage = null;
            this.addTaskButton.OnPressedColor = System.Drawing.Color.Black;
            this.addTaskButton.Size = new System.Drawing.Size(40, 40);
            this.addTaskButton.TabIndex = 7;
            this.addTaskButton.Text = "+";
            this.addTaskButton.Click += new System.EventHandler(this.onAddTaskButtonclicked);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaSeparator1.Location = new System.Drawing.Point(3, 73);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(358, 10);
            this.gunaSeparator1.TabIndex = 6;
            // 
            // projectDesLabel
            // 
            this.projectDesLabel.AutoSize = true;
            this.projectDesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(152)))), ((int)(((byte)(130)))));
            this.projectDesLabel.Location = new System.Drawing.Point(17, 49);
            this.projectDesLabel.Name = "projectDesLabel";
            this.projectDesLabel.Size = new System.Drawing.Size(124, 17);
            this.projectDesLabel.TabIndex = 5;
            this.projectDesLabel.Text = "Project Discreption";
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.projectNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.projectNameLabel.Location = new System.Drawing.Point(13, 12);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(217, 37);
            this.projectNameLabel.TabIndex = 4;
            this.projectNameLabel.Text = "Project NNName";
            // 
            // gunaPanelContainer
            // 
            this.gunaPanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gunaPanelContainer.Controls.Add(this.addTaskPanel);
            this.gunaPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanelContainer.Location = new System.Drawing.Point(0, 82);
            this.gunaPanelContainer.Name = "gunaPanelContainer";
            this.gunaPanelContainer.Size = new System.Drawing.Size(355, 689);
            this.gunaPanelContainer.TabIndex = 6;
            // 
            // addTaskPanel
            // 
            this.addTaskPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.addTaskPanel.Controls.Add(this.addNewTaskButton);
            this.addTaskPanel.Controls.Add(this.fromDateButton);
            this.addTaskPanel.Controls.Add(this.toDateButton);
            this.addTaskPanel.Controls.Add(this.toDateTextBox);
            this.addTaskPanel.Controls.Add(this.fromDateTextBox);
            this.addTaskPanel.Controls.Add(this.gunaLabel6);
            this.addTaskPanel.Controls.Add(this.gunaLabel5);
            this.addTaskPanel.Controls.Add(this.calenderGroupBox);
            this.addTaskPanel.Controls.Add(this.gunaLabel4);
            this.addTaskPanel.Controls.Add(this.gunaLabel3);
            this.addTaskPanel.Controls.Add(this.taskDesTextBox);
            this.addTaskPanel.Controls.Add(this.gunaLabel2);
            this.addTaskPanel.Controls.Add(this.taskNameTextBox);
            this.addTaskPanel.Controls.Add(this.gunaLabel1);
            this.addTaskPanel.Controls.Add(this.closeAddTaskFormButton);
            this.addTaskPanel.Location = new System.Drawing.Point(0, 0);
            this.addTaskPanel.Name = "addTaskPanel";
            this.addTaskPanel.Size = new System.Drawing.Size(355, 686);
            this.addTaskPanel.TabIndex = 0;
            this.addTaskPanel.Visible = false;
            // 
            // addNewTaskButton
            // 
            this.addNewTaskButton.AnimationHoverSpeed = 0.07F;
            this.addNewTaskButton.AnimationSpeed = 0.03F;
            this.addNewTaskButton.BackColor = System.Drawing.Color.Transparent;
            this.addNewTaskButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(219)))), ((int)(((byte)(240)))));
            this.addNewTaskButton.BorderColor = System.Drawing.Color.Black;
            this.addNewTaskButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addNewTaskButton.FocusedColor = System.Drawing.Color.Empty;
            this.addNewTaskButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addNewTaskButton.ForeColor = System.Drawing.Color.Black;
            this.addNewTaskButton.Image = null;
            this.addNewTaskButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addNewTaskButton.ImageSize = new System.Drawing.Size(20, 20);
            this.addNewTaskButton.Location = new System.Drawing.Point(20, 372);
            this.addNewTaskButton.Name = "addNewTaskButton";
            this.addNewTaskButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(219)))), ((int)(((byte)(240)))));
            this.addNewTaskButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addNewTaskButton.OnHoverForeColor = System.Drawing.Color.White;
            this.addNewTaskButton.OnHoverImage = null;
            this.addNewTaskButton.OnPressedColor = System.Drawing.Color.Black;
            this.addNewTaskButton.Radius = 5;
            this.addNewTaskButton.Size = new System.Drawing.Size(154, 40);
            this.addNewTaskButton.TabIndex = 17;
            this.addNewTaskButton.Text = "Add Task";
            this.addNewTaskButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addNewTaskButton.Click += new System.EventHandler(this.onAddNewTaskButtonClicked);
            // 
            // toDateTextBox
            // 
            this.toDateTextBox.BackColor = System.Drawing.Color.Transparent;
            this.toDateTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.toDateTextBox.BorderColor = System.Drawing.Color.Silver;
            this.toDateTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.toDateTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.toDateTextBox.FocusedBorderColor = System.Drawing.Color.Silver;
            this.toDateTextBox.FocusedForeColor = System.Drawing.Color.White;
            this.toDateTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toDateTextBox.ForeColor = System.Drawing.Color.White;
            this.toDateTextBox.Location = new System.Drawing.Point(186, 269);
            this.toDateTextBox.Name = "toDateTextBox";
            this.toDateTextBox.PasswordChar = '\0';
            this.toDateTextBox.Radius = 5;
            this.toDateTextBox.SelectedText = "";
            this.toDateTextBox.Size = new System.Drawing.Size(154, 40);
            this.toDateTextBox.TabIndex = 14;
            // 
            // fromDateTextBox
            // 
            this.fromDateTextBox.BackColor = System.Drawing.Color.Transparent;
            this.fromDateTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.fromDateTextBox.BorderColor = System.Drawing.Color.Silver;
            this.fromDateTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fromDateTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.fromDateTextBox.FocusedBorderColor = System.Drawing.Color.Silver;
            this.fromDateTextBox.FocusedForeColor = System.Drawing.Color.White;
            this.fromDateTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fromDateTextBox.ForeColor = System.Drawing.Color.White;
            this.fromDateTextBox.Location = new System.Drawing.Point(20, 269);
            this.fromDateTextBox.Name = "fromDateTextBox";
            this.fromDateTextBox.PasswordChar = '\0';
            this.fromDateTextBox.Radius = 5;
            this.fromDateTextBox.SelectedText = "";
            this.fromDateTextBox.Size = new System.Drawing.Size(154, 40);
            this.fromDateTextBox.TabIndex = 13;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(152)))), ((int)(((byte)(130)))));
            this.gunaLabel6.Location = new System.Drawing.Point(184, 320);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(71, 12);
            this.gunaLabel6.TabIndex = 12;
            this.gunaLabel6.Text = "\"MM/dd/yyyy\"";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(152)))), ((int)(((byte)(130)))));
            this.gunaLabel5.Location = new System.Drawing.Point(18, 320);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(71, 12);
            this.gunaLabel5.TabIndex = 11;
            this.gunaLabel5.Text = "\"MM/dd/yyyy\"";
            // 
            // calenderGroupBox
            // 
            this.calenderGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.calenderGroupBox.BaseColor = System.Drawing.Color.White;
            this.calenderGroupBox.BorderColor = System.Drawing.Color.Gainsboro;
            this.calenderGroupBox.Controls.Add(this.selectDateButton);
            this.calenderGroupBox.Controls.Add(this.monthCalendar);
            this.calenderGroupBox.LineColor = System.Drawing.Color.White;
            this.calenderGroupBox.Location = new System.Drawing.Point(20, 358);
            this.calenderGroupBox.Name = "calenderGroupBox";
            this.calenderGroupBox.Radius = 5;
            this.calenderGroupBox.Size = new System.Drawing.Size(320, 280);
            this.calenderGroupBox.TabIndex = 10;
            this.calenderGroupBox.TextLocation = new System.Drawing.Point(10, 8);
            this.calenderGroupBox.Visible = false;
            // 
            // selectDateButton
            // 
            this.selectDateButton.AnimationHoverSpeed = 0.07F;
            this.selectDateButton.AnimationSpeed = 0.03F;
            this.selectDateButton.BackColor = System.Drawing.Color.Transparent;
            this.selectDateButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.selectDateButton.BorderColor = System.Drawing.Color.Black;
            this.selectDateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.selectDateButton.FocusedColor = System.Drawing.Color.Empty;
            this.selectDateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectDateButton.ForeColor = System.Drawing.Color.White;
            this.selectDateButton.Image = null;
            this.selectDateButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.selectDateButton.ImageSize = new System.Drawing.Size(20, 20);
            this.selectDateButton.Location = new System.Drawing.Point(135, 228);
            this.selectDateButton.Name = "selectDateButton";
            this.selectDateButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.selectDateButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.selectDateButton.OnHoverForeColor = System.Drawing.Color.White;
            this.selectDateButton.OnHoverImage = null;
            this.selectDateButton.OnPressedColor = System.Drawing.Color.Black;
            this.selectDateButton.Radius = 5;
            this.selectDateButton.Size = new System.Drawing.Size(154, 40);
            this.selectDateButton.TabIndex = 16;
            this.selectDateButton.Text = "Select";
            this.selectDateButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.selectDateButton.Click += new System.EventHandler(this.onSelectDateButtonClicked);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(27, 9);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.onMonthCalendarDateChanged);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(152)))), ((int)(((byte)(130)))));
            this.gunaLabel4.Location = new System.Drawing.Point(182, 246);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(70, 20);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "End Date";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(152)))), ((int)(((byte)(130)))));
            this.gunaLabel3.Location = new System.Drawing.Point(16, 246);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(76, 20);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = "Start Date";
            // 
            // taskDesTextBox
            // 
            this.taskDesTextBox.BackColor = System.Drawing.Color.Transparent;
            this.taskDesTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.taskDesTextBox.BorderColor = System.Drawing.Color.Silver;
            this.taskDesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.taskDesTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.taskDesTextBox.FocusedBorderColor = System.Drawing.Color.Silver;
            this.taskDesTextBox.FocusedForeColor = System.Drawing.Color.White;
            this.taskDesTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.taskDesTextBox.ForeColor = System.Drawing.Color.White;
            this.taskDesTextBox.Location = new System.Drawing.Point(20, 152);
            this.taskDesTextBox.Name = "taskDesTextBox";
            this.taskDesTextBox.PasswordChar = '\0';
            this.taskDesTextBox.Radius = 5;
            this.taskDesTextBox.SelectedText = "";
            this.taskDesTextBox.Size = new System.Drawing.Size(320, 79);
            this.taskDesTextBox.TabIndex = 5;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(152)))), ((int)(((byte)(130)))));
            this.gunaLabel2.Location = new System.Drawing.Point(16, 125);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(116, 20);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Task Description";
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.taskNameTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.taskNameTextBox.BorderColor = System.Drawing.Color.Silver;
            this.taskNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.taskNameTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.taskNameTextBox.FocusedBorderColor = System.Drawing.Color.Silver;
            this.taskNameTextBox.FocusedForeColor = System.Drawing.Color.White;
            this.taskNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.taskNameTextBox.ForeColor = System.Drawing.Color.White;
            this.taskNameTextBox.Location = new System.Drawing.Point(20, 73);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.PasswordChar = '\0';
            this.taskNameTextBox.Radius = 5;
            this.taskNameTextBox.SelectedText = "";
            this.taskNameTextBox.Size = new System.Drawing.Size(320, 40);
            this.taskNameTextBox.TabIndex = 3;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(152)))), ((int)(((byte)(130)))));
            this.gunaLabel1.Location = new System.Drawing.Point(16, 46);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(80, 20);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Task Name";
            // 
            // fromDateButton
            // 
            this.fromDateButton.AnimationHoverSpeed = 0.07F;
            this.fromDateButton.AnimationSpeed = 0.03F;
            this.fromDateButton.BackColor = System.Drawing.Color.Transparent;
            this.fromDateButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fromDateButton.BorderColor = System.Drawing.Color.Black;
            this.fromDateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.fromDateButton.FocusedColor = System.Drawing.Color.Empty;
            this.fromDateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fromDateButton.ForeColor = System.Drawing.Color.White;
            this.fromDateButton.Image = global::ManagementApp.Properties.Resources.calendar;
            this.fromDateButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fromDateButton.ImageSize = new System.Drawing.Size(20, 20);
            this.fromDateButton.Location = new System.Drawing.Point(134, 269);
            this.fromDateButton.Name = "fromDateButton";
            this.fromDateButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.fromDateButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.fromDateButton.OnHoverForeColor = System.Drawing.Color.White;
            this.fromDateButton.OnHoverImage = null;
            this.fromDateButton.OnPressedColor = System.Drawing.Color.Black;
            this.fromDateButton.Radius = 5;
            this.fromDateButton.Size = new System.Drawing.Size(40, 40);
            this.fromDateButton.TabIndex = 16;
            this.fromDateButton.Click += new System.EventHandler(this.onDateButtonClicked);
            // 
            // toDateButton
            // 
            this.toDateButton.AnimationHoverSpeed = 0.07F;
            this.toDateButton.AnimationSpeed = 0.03F;
            this.toDateButton.BackColor = System.Drawing.Color.Transparent;
            this.toDateButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.toDateButton.BorderColor = System.Drawing.Color.Black;
            this.toDateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.toDateButton.FocusedColor = System.Drawing.Color.Empty;
            this.toDateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toDateButton.ForeColor = System.Drawing.Color.White;
            this.toDateButton.Image = global::ManagementApp.Properties.Resources.calendar;
            this.toDateButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toDateButton.ImageSize = new System.Drawing.Size(20, 20);
            this.toDateButton.Location = new System.Drawing.Point(300, 269);
            this.toDateButton.Name = "toDateButton";
            this.toDateButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.toDateButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.toDateButton.OnHoverForeColor = System.Drawing.Color.White;
            this.toDateButton.OnHoverImage = null;
            this.toDateButton.OnPressedColor = System.Drawing.Color.Black;
            this.toDateButton.Radius = 5;
            this.toDateButton.Size = new System.Drawing.Size(40, 40);
            this.toDateButton.TabIndex = 15;
            this.toDateButton.Click += new System.EventHandler(this.onDateButtonClicked);
            // 
            // closeAddTaskFormButton
            // 
            this.closeAddTaskFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeAddTaskFormButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closeAddTaskFormButton.Image = global::ManagementApp.Properties.Resources.cloase;
            this.closeAddTaskFormButton.ImageSize = new System.Drawing.Size(20, 20);
            this.closeAddTaskFormButton.Location = new System.Drawing.Point(306, 18);
            this.closeAddTaskFormButton.Name = "closeAddTaskFormButton";
            this.closeAddTaskFormButton.OnHoverImage = null;
            this.closeAddTaskFormButton.OnHoverImageOffset = new System.Drawing.Point(0, -1);
            this.closeAddTaskFormButton.Size = new System.Drawing.Size(32, 32);
            this.closeAddTaskFormButton.TabIndex = 1;
            this.closeAddTaskFormButton.Click += new System.EventHandler(this.onCloseAddTaskFormButtonClicked);
            // 
            // ProjectItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaPanelContainer);
            this.Controls.Add(this.gunaPanel3);
            this.Name = "ProjectItem";
            this.Size = new System.Drawing.Size(355, 771);
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            this.gunaPanelContainer.ResumeLayout(false);
            this.addTaskPanel.ResumeLayout(false);
            this.addTaskPanel.PerformLayout();
            this.calenderGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Label projectDesLabel;
        private System.Windows.Forms.Label projectNameLabel;
        private Guna.UI.WinForms.GunaPanel gunaPanelContainer;
        private Guna.UI.WinForms.GunaCircleButton addTaskButton;
        private Guna.UI.WinForms.GunaPanel addTaskPanel;
        private Guna.UI.WinForms.GunaImageButton closeAddTaskFormButton;
        private Guna.UI.WinForms.GunaTextBox taskNameTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox taskDesTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaGroupBox calenderGroupBox;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox fromDateTextBox;
        private Guna.UI.WinForms.GunaTextBox toDateTextBox;
        private Guna.UI.WinForms.GunaButton fromDateButton;
        private Guna.UI.WinForms.GunaButton toDateButton;
        private Guna.UI.WinForms.GunaButton selectDateButton;
        private Guna.UI.WinForms.GunaButton addNewTaskButton;
    }
}
