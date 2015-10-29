namespace TournyManager
{
    partial class timerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timerWindow));
            this.gridLayout = new System.Windows.Forms.TableLayoutPanel();
            this.timerControls = new System.Windows.Forms.FlowLayoutPanel();
            this.restartLevel = new System.Windows.Forms.RadioButton();
            this.pauseClock = new System.Windows.Forms.RadioButton();
            this.startClock = new System.Windows.Forms.RadioButton();
            this.nextLevel = new System.Windows.Forms.RadioButton();
            this.clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gridLayout.SuspendLayout();
            this.timerControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridLayout
            // 
            this.gridLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gridLayout.BackColor = System.Drawing.Color.Teal;
            this.gridLayout.ColumnCount = 1;
            this.gridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.gridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gridLayout.Controls.Add(this.timerControls, 1, 1);
            this.gridLayout.Controls.Add(this.clock, 1, 0);
            this.gridLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLayout.Location = new System.Drawing.Point(0, 0);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.RowCount = 1;
            this.gridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.40379F));
            this.gridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.59621F));
            this.gridLayout.Size = new System.Drawing.Size(570, 288);
            this.gridLayout.TabIndex = 0;
            this.gridLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // timerControls
            // 
            this.timerControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timerControls.Controls.Add(this.restartLevel);
            this.timerControls.Controls.Add(this.pauseClock);
            this.timerControls.Controls.Add(this.startClock);
            this.timerControls.Controls.Add(this.nextLevel);
            this.timerControls.Location = new System.Drawing.Point(121, 239);
            this.timerControls.Name = "timerControls";
            this.timerControls.Size = new System.Drawing.Size(328, 37);
            this.timerControls.TabIndex = 2;
            // 
            // restartLevel
            // 
            this.restartLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restartLevel.AutoSize = true;
            this.restartLevel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.restartLevel.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.restartLevel.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.restartLevel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.restartLevel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartLevel.Location = new System.Drawing.Point(3, 3);
            this.restartLevel.Name = "restartLevel";
            this.restartLevel.Size = new System.Drawing.Size(84, 31);
            this.restartLevel.TabIndex = 0;
            this.restartLevel.TabStop = true;
            this.restartLevel.Text = "Restart Level";
            this.restartLevel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.restartLevel.UseVisualStyleBackColor = false;
            this.restartLevel.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.restartLevel.RightToLeftChanged += new System.EventHandler(this.radioButton1_RightToLeftChanged);
            this.restartLevel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dock);
            // 
            // pauseClock
            // 
            this.pauseClock.AutoSize = true;
            this.pauseClock.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pauseClock.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pauseClock.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseClock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pauseClock.Location = new System.Drawing.Point(93, 3);
            this.pauseClock.Name = "pauseClock";
            this.pauseClock.Size = new System.Drawing.Size(79, 31);
            this.pauseClock.TabIndex = 2;
            this.pauseClock.TabStop = true;
            this.pauseClock.Text = "Pause Clock";
            this.pauseClock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pauseClock.UseVisualStyleBackColor = false;
            this.pauseClock.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.pauseClock.AutoSizeChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.pauseClock.BackColorChanged += new System.EventHandler(this.radioButton3_BackColorChanged);
            // 
            // startClock
            // 
            this.startClock.AutoSize = true;
            this.startClock.BackColor = System.Drawing.Color.DarkSlateGray;
            this.startClock.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startClock.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startClock.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.startClock.Location = new System.Drawing.Point(178, 3);
            this.startClock.Name = "startClock";
            this.startClock.Size = new System.Drawing.Size(71, 31);
            this.startClock.TabIndex = 1;
            this.startClock.TabStop = true;
            this.startClock.Text = "Start Clock";
            this.startClock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.startClock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.startClock.UseVisualStyleBackColor = false;
            this.startClock.CheckedChanged += new System.EventHandler(this.startClock_CheckedChanged);
            // 
            // nextLevel
            // 
            this.nextLevel.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.nextLevel.AutoSize = true;
            this.nextLevel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nextLevel.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nextLevel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextLevel.Location = new System.Drawing.Point(255, 3);
            this.nextLevel.Name = "nextLevel";
            this.nextLevel.Size = new System.Drawing.Size(68, 31);
            this.nextLevel.TabIndex = 3;
            this.nextLevel.TabStop = true;
            this.nextLevel.Text = "Next Level";
            this.nextLevel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nextLevel.UseVisualStyleBackColor = false;
            this.nextLevel.CheckedChanged += new System.EventHandler(this.nextLevel_CheckedChanged);
            // 
            // clock
            // 
            this.clock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clock.BackColor = System.Drawing.Color.Teal;
            this.clock.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock.Location = new System.Drawing.Point(15, 9);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(539, 209);
            this.clock.TabIndex = 3;
            this.clock.Text = " ";
            this.clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clock.TextChanged += new System.EventHandler(this.label1_TextChanged);
            this.clock.Click += new System.EventHandler(this.clock_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 288);
            this.Controls.Add(this.gridLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "timerWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "timerWindow";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gridLayout.ResumeLayout(false);
            this.timerControls.ResumeLayout(false);
            this.timerControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gridLayout;
        private System.Windows.Forms.RadioButton startClock;
        private System.Windows.Forms.RadioButton restartLevel;
        private System.Windows.Forms.FlowLayoutPanel timerControls;
        private System.Windows.Forms.RadioButton pauseClock;
        private System.Windows.Forms.RadioButton nextLevel;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Timer timer1;
    }
}

