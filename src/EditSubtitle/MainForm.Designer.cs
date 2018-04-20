namespace EditSubtitle
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtOpenPath = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.prbDone = new System.Windows.Forms.ProgressBar();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnTtBack = new System.Windows.Forms.Button();
            this.btnTtForward = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(473, 48);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save to";
            this.toolTip1.SetToolTip(this.btnSave, "Export processed subtitle");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOpenPath
            // 
            this.txtOpenPath.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtOpenPath.Location = new System.Drawing.Point(16, 15);
            this.txtOpenPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOpenPath.Name = "txtOpenPath";
            this.txtOpenPath.ReadOnly = true;
            this.txtOpenPath.Size = new System.Drawing.Size(448, 22);
            this.txtOpenPath.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtOpenPath, "Original subtitle pathe");
            // 
            // btnOpen
            // 
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Location = new System.Drawing.Point(473, 12);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 28);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "&Open";
            this.toolTip1.SetToolTip(this.btnOpen, "Import original subtitle");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtSavePath
            // 
            this.txtSavePath.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSavePath.Location = new System.Drawing.Point(16, 50);
            this.txtSavePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.ReadOnly = true;
            this.txtSavePath.Size = new System.Drawing.Size(448, 22);
            this.txtSavePath.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtSavePath, "Export subtitle pathe");
            // 
            // prbDone
            // 
            this.prbDone.Location = new System.Drawing.Point(-3, 135);
            this.prbDone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prbDone.Name = "prbDone";
            this.prbDone.Size = new System.Drawing.Size(595, 25);
            this.prbDone.TabIndex = 2;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtTime.Location = new System.Drawing.Point(75, 86);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTime.MaxLength = 3;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(41, 25);
            this.txtTime.TabIndex = 3;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtTime, "Please desired time in seconds to enter.");
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            this.txtTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTime_KeyDown);
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time: ";
            // 
            // btnTtBack
            // 
            this.btnTtBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTtBack.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btnTtBack.Enabled = false;
            this.btnTtBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTtBack.Font = new System.Drawing.Font("Times New Roman", 10.75F);
            this.btnTtBack.Location = new System.Drawing.Point(135, 85);
            this.btnTtBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTtBack.Name = "btnTtBack";
            this.btnTtBack.Size = new System.Drawing.Size(161, 28);
            this.btnTtBack.TabIndex = 6;
            this.btnTtBack.Text = "Time To &Back";
            this.toolTip1.SetToolTip(this.btnTtBack, "Set all subtitle time\'s to back");
            this.btnTtBack.UseVisualStyleBackColor = false;
            this.btnTtBack.Click += new System.EventHandler(this.btnTtBack_Click);
            // 
            // btnTtForward
            // 
            this.btnTtForward.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTtForward.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.btnTtForward.Enabled = false;
            this.btnTtForward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTtForward.Font = new System.Drawing.Font("Times New Roman", 10.75F);
            this.btnTtForward.Location = new System.Drawing.Point(304, 85);
            this.btnTtForward.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTtForward.Name = "btnTtForward";
            this.btnTtForward.Size = new System.Drawing.Size(161, 28);
            this.btnTtForward.TabIndex = 6;
            this.btnTtForward.Text = "Time To &Forward";
            this.toolTip1.SetToolTip(this.btnTtForward, "Set all subtitle time\'s to forward");
            this.btnTtForward.UseVisualStyleBackColor = false;
            this.btnTtForward.Click += new System.EventHandler(this.btnTtForward_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "newSubtitle.srt";
            this.saveFileDialog1.Filter = "Subtitle files|*.srt|All files|*.*";
            this.saveFileDialog1.Title = "Save exported subtitle in this path";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Subtitle files|*.srt|All files|*.*";
            this.openFileDialog1.Title = "Import the subtitle file";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.LightCoral;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnAbout.Location = new System.Drawing.Point(517, 100);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(63, 28);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "About!";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 159);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnTtForward);
            this.Controls.Add(this.btnTtBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prbDone);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.txtOpenPath);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Edit Subtitle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtOpenPath;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.ProgressBar prbDone;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnTtBack;
        private System.Windows.Forms.Button btnTtForward;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAbout;
    }
}

