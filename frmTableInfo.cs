using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolClubProject
{
    public partial class frmTableInfo : Form
    {
        public delegate void SendDataToUCusingDel(string tablename, string playername, byte hourlyrate, bool IsConfirmed);
        public event SendDataToUCusingDel DataBack;

        private bool _IsConfirmed = false;

        public frmTableInfo()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string tablename = txtTableName.Text ; 
            string playername = txtPlayerName.Text; 
            byte hourlyrate = Convert.ToByte(txtHourlyRate.Text);
            _IsConfirmed = true;

            DataBack?.Invoke(tablename, playername, hourlyrate, _IsConfirmed);

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _IsConfirmed = false;
            this.Close();
        }
    }
}
