namespace ProductivityTool
{
    partial class MainForm
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
                // make sure to dispose the tray icon for it to disappear from system tray...
                trayIcon.Dispose();
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
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.timerTextBox = new System.Windows.Forms.TextBox();
            this.pomodoroRadioButton = new System.Windows.Forms.RadioButton();
            this.shortBreakRadioButton = new System.Windows.Forms.RadioButton();
            this.longBreakRadioButton = new System.Windows.Forms.RadioButton();
            this.resetButton = new System.Windows.Forms.Button();
            this.distractionButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(251, 25);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(106, 27);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(251, 58);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(106, 27);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timerTextBox
            // 
            this.timerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerTextBox.Location = new System.Drawing.Point(6, 25);
            this.timerTextBox.Name = "timerTextBox";
            this.timerTextBox.Size = new System.Drawing.Size(239, 44);
            this.timerTextBox.TabIndex = 2;
            this.timerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pomodoroRadioButton
            // 
            this.pomodoroRadioButton.AutoSize = true;
            this.pomodoroRadioButton.Location = new System.Drawing.Point(6, 111);
            this.pomodoroRadioButton.Name = "pomodoroRadioButton";
            this.pomodoroRadioButton.Size = new System.Drawing.Size(99, 24);
            this.pomodoroRadioButton.TabIndex = 3;
            this.pomodoroRadioButton.TabStop = true;
            this.pomodoroRadioButton.Text = "pomodoro";
            this.pomodoroRadioButton.UseVisualStyleBackColor = true;
            this.pomodoroRadioButton.CheckedChanged += new System.EventHandler(this.pomodoroRadioButton_CheckedChanged);
            // 
            // shortBreakRadioButton
            // 
            this.shortBreakRadioButton.AutoSize = true;
            this.shortBreakRadioButton.Location = new System.Drawing.Point(6, 141);
            this.shortBreakRadioButton.Name = "shortBreakRadioButton";
            this.shortBreakRadioButton.Size = new System.Drawing.Size(107, 24);
            this.shortBreakRadioButton.TabIndex = 4;
            this.shortBreakRadioButton.TabStop = true;
            this.shortBreakRadioButton.Text = "short break";
            this.shortBreakRadioButton.UseVisualStyleBackColor = true;
            this.shortBreakRadioButton.CheckedChanged += new System.EventHandler(this.shortBreakRadioButton_CheckedChanged);
            // 
            // longBreakRadioButton
            // 
            this.longBreakRadioButton.AutoSize = true;
            this.longBreakRadioButton.Location = new System.Drawing.Point(6, 171);
            this.longBreakRadioButton.Name = "longBreakRadioButton";
            this.longBreakRadioButton.Size = new System.Drawing.Size(101, 24);
            this.longBreakRadioButton.TabIndex = 5;
            this.longBreakRadioButton.TabStop = true;
            this.longBreakRadioButton.Text = "long break";
            this.longBreakRadioButton.UseVisualStyleBackColor = true;
            this.longBreakRadioButton.CheckedChanged += new System.EventHandler(this.longBreakRadioButton_CheckedChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(251, 91);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(106, 27);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // distractionButton
            // 
            this.distractionButton.Location = new System.Drawing.Point(251, 124);
            this.distractionButton.Name = "distractionButton";
            this.distractionButton.Size = new System.Drawing.Size(106, 27);
            this.distractionButton.TabIndex = 8;
            this.distractionButton.Text = "Distraction";
            this.distractionButton.UseVisualStyleBackColor = true;
            this.distractionButton.Click += new System.EventHandler(this.distractionButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(387, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pomodoroRadioButton);
            this.groupBox1.Controls.Add(this.distractionButton);
            this.groupBox1.Controls.Add(this.shortBreakRadioButton);
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.longBreakRadioButton);
            this.groupBox1.Controls.Add(this.stopButton);
            this.groupBox1.Controls.Add(this.timerTextBox);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 214);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pomodoro";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 253);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Productivity Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox timerTextBox;
        private System.Windows.Forms.RadioButton pomodoroRadioButton;
        private System.Windows.Forms.RadioButton shortBreakRadioButton;
        private System.Windows.Forms.RadioButton longBreakRadioButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button distractionButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}

