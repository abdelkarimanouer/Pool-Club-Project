namespace PoolClubProject
{
    partial class Frm8PoolTables
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
            this.ucPoolTable5 = new PoolClubProject.ucPoolTable();
            this.ucPoolTable4 = new PoolClubProject.ucPoolTable();
            this.ucPoolTable3 = new PoolClubProject.ucPoolTable();
            this.ucPoolTable2 = new PoolClubProject.ucPoolTable();
            this.ucPoolTable1 = new PoolClubProject.ucPoolTable();
            this.SuspendLayout();
            // 
            // ucPoolTable5
            // 
            this.ucPoolTable5.BackColor = System.Drawing.Color.Black;
            this.ucPoolTable5.HourlyRate = ((byte)(10));
            this.ucPoolTable5.Location = new System.Drawing.Point(423, 363);
            this.ucPoolTable5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucPoolTable5.Name = "ucPoolTable5";
            this.ucPoolTable5.Size = new System.Drawing.Size(374, 324);
            this.ucPoolTable5.TabIndex = 4;
            this.ucPoolTable5.TablePlayer = "Player";
            this.ucPoolTable5.TableTitle = "Table";
            this.ucPoolTable5.OnTableCompleted += new System.EventHandler<PoolClubProject.ucPoolTable.TableCompletedEventArgs>(this.ucPoolTable_OnTableCompleted);
            // 
            // ucPoolTable4
            // 
            this.ucPoolTable4.BackColor = System.Drawing.Color.Black;
            this.ucPoolTable4.HourlyRate = ((byte)(10));
            this.ucPoolTable4.Location = new System.Drawing.Point(19, 363);
            this.ucPoolTable4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucPoolTable4.Name = "ucPoolTable4";
            this.ucPoolTable4.Size = new System.Drawing.Size(374, 324);
            this.ucPoolTable4.TabIndex = 3;
            this.ucPoolTable4.TablePlayer = "Player";
            this.ucPoolTable4.TableTitle = "Table";
            this.ucPoolTable4.OnTableCompleted += new System.EventHandler<PoolClubProject.ucPoolTable.TableCompletedEventArgs>(this.ucPoolTable_OnTableCompleted);
            // 
            // ucPoolTable3
            // 
            this.ucPoolTable3.BackColor = System.Drawing.Color.Black;
            this.ucPoolTable3.HourlyRate = ((byte)(10));
            this.ucPoolTable3.Location = new System.Drawing.Point(830, 12);
            this.ucPoolTable3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucPoolTable3.Name = "ucPoolTable3";
            this.ucPoolTable3.Size = new System.Drawing.Size(374, 324);
            this.ucPoolTable3.TabIndex = 2;
            this.ucPoolTable3.TablePlayer = "Player";
            this.ucPoolTable3.TableTitle = "Table";
            this.ucPoolTable3.OnTableCompleted += new System.EventHandler<PoolClubProject.ucPoolTable.TableCompletedEventArgs>(this.ucPoolTable_OnTableCompleted);
            // 
            // ucPoolTable2
            // 
            this.ucPoolTable2.BackColor = System.Drawing.Color.Black;
            this.ucPoolTable2.HourlyRate = ((byte)(10));
            this.ucPoolTable2.Location = new System.Drawing.Point(423, 12);
            this.ucPoolTable2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucPoolTable2.Name = "ucPoolTable2";
            this.ucPoolTable2.Size = new System.Drawing.Size(374, 324);
            this.ucPoolTable2.TabIndex = 1;
            this.ucPoolTable2.TablePlayer = "Player";
            this.ucPoolTable2.TableTitle = "Table";
            this.ucPoolTable2.OnTableCompleted += new System.EventHandler<PoolClubProject.ucPoolTable.TableCompletedEventArgs>(this.ucPoolTable_OnTableCompleted);
            // 
            // ucPoolTable1
            // 
            this.ucPoolTable1.BackColor = System.Drawing.Color.Black;
            this.ucPoolTable1.HourlyRate = ((byte)(10));
            this.ucPoolTable1.Location = new System.Drawing.Point(19, 12);
            this.ucPoolTable1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucPoolTable1.Name = "ucPoolTable1";
            this.ucPoolTable1.Size = new System.Drawing.Size(374, 324);
            this.ucPoolTable1.TabIndex = 0;
            this.ucPoolTable1.TablePlayer = "Player";
            this.ucPoolTable1.TableTitle = "Table";
            this.ucPoolTable1.OnTableCompleted += new System.EventHandler<PoolClubProject.ucPoolTable.TableCompletedEventArgs>(this.ucPoolTable_OnTableCompleted);
            // 
            // Frm8PoolTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1231, 714);
            this.Controls.Add(this.ucPoolTable5);
            this.Controls.Add(this.ucPoolTable4);
            this.Controls.Add(this.ucPoolTable3);
            this.Controls.Add(this.ucPoolTable2);
            this.Controls.Add(this.ucPoolTable1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Frm8PoolTables";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ucPoolTable ucPoolTable1;
        private ucPoolTable ucPoolTable2;
        private ucPoolTable ucPoolTable3;
        private ucPoolTable ucPoolTable4;
        private ucPoolTable ucPoolTable5;
    }
}

