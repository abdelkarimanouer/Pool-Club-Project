namespace PoolClubProject
{
    partial class ucPoolTable
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
            this.components = new System.ComponentModel.Container();
            this.gbTableName = new System.Windows.Forms.GroupBox();
            this.lbSeconds = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lbPlayer = new System.Windows.Forms.Label();
            this.lbMinutes = new System.Windows.Forms.Label();
            this.lbHours = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbTableName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTableName
            // 
            this.gbTableName.Controls.Add(this.label5);
            this.gbTableName.Controls.Add(this.label4);
            this.gbTableName.Controls.Add(this.lbSeconds);
            this.gbTableName.Controls.Add(this.btnEnd);
            this.gbTableName.Controls.Add(this.btnStartStop);
            this.gbTableName.Controls.Add(this.lbPlayer);
            this.gbTableName.Controls.Add(this.lbMinutes);
            this.gbTableName.Controls.Add(this.lbHours);
            this.gbTableName.Controls.Add(this.pictureBox1);
            this.gbTableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTableName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTableName.ForeColor = System.Drawing.Color.White;
            this.gbTableName.Location = new System.Drawing.Point(0, 0);
            this.gbTableName.Name = "gbTableName";
            this.gbTableName.Size = new System.Drawing.Size(481, 385);
            this.gbTableName.TabIndex = 0;
            this.gbTableName.TabStop = false;
            this.gbTableName.Text = "Table Name";
            // 
            // lbSeconds
            // 
            this.lbSeconds.AutoSize = true;
            this.lbSeconds.BackColor = System.Drawing.Color.Transparent;
            this.lbSeconds.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeconds.Location = new System.Drawing.Point(213, 299);
            this.lbSeconds.Name = "lbSeconds";
            this.lbSeconds.Size = new System.Drawing.Size(64, 48);
            this.lbSeconds.TabIndex = 4;
            this.lbSeconds.Text = "00";
            this.lbSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Black;
            this.btnEnd.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(314, 218);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(149, 68);
            this.btnEnd.TabIndex = 9;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.Color.Black;
            this.btnStartStop.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.Location = new System.Drawing.Point(314, 111);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(149, 68);
            this.btnStartStop.TabIndex = 8;
            this.btnStartStop.Tag = "";
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lbPlayer
            // 
            this.lbPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayer.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayer.Location = new System.Drawing.Point(12, 36);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(451, 43);
            this.lbPlayer.TabIndex = 7;
            this.lbPlayer.Text = "Player";
            this.lbPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinutes.Location = new System.Drawing.Point(115, 299);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(64, 48);
            this.lbMinutes.TabIndex = 3;
            this.lbMinutes.Text = "00";
            this.lbMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHours.Location = new System.Drawing.Point(17, 299);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(64, 48);
            this.lbHours.TabIndex = 2;
            this.lbHours.Text = "00";
            this.lbHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PoolClubProject.Properties.Resources.pool;
            this.pictureBox1.Location = new System.Drawing.Point(15, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 48);
            this.label5.TabIndex = 6;
            this.label5.Text = ":";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 48);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucPoolTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.gbTableName);
            this.Name = "ucPoolTable";
            this.Size = new System.Drawing.Size(481, 385);
            this.gbTableName.ResumeLayout(false);
            this.gbTableName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTableName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.Label lbSeconds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lbPlayer;
        private System.Windows.Forms.Timer timer1;
    }
}
