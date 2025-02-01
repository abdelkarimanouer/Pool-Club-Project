using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolClubProject
{
    public partial class Frm8PoolTables : Form
    {
        public Frm8PoolTables()
        {
            InitializeComponent();
        }

        private void ucPoolTable_OnTableCompleted(object sender, ucPoolTable.TableCompletedEventArgs e)
        {
            MessageBox.Show($"Total Consumed {e.TimeText}, Total Seconds = {e.TimeInSecond}, HourlyRate = {e.RatePerHour}, Total Fees = {e.TotalFees}$");
        }
    }
}
