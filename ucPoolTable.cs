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
    public partial class ucPoolTable : UserControl
    {
        public ucPoolTable()
        {
            InitializeComponent();
            _hourlyRate = 10;
            _tablePlayer = "Player";
            _tableTitle = "Table";
        }

        public class TableCompletedEventArgs : EventArgs
        {
            public string TimeText { get; }
            public int TimeInSecond { get; }
            public float RatePerHour { get; }
            public float TotalFees { get; }

            public TableCompletedEventArgs(string timetext, int timeinsecond, float rateperhour, float totalfees)
            {
                this.TimeText = timetext;
                this.TimeInSecond = timeinsecond;
                this.RatePerHour = rateperhour;
                this.TotalFees = totalfees;
            }

        }

        public event EventHandler<TableCompletedEventArgs> OnTableCompleted;
        public void RaiseTableCompleted(string timetext, int timeinsecond, float rateperhour, float totalfees)
        {
            TableCompletedEventArgs e = new TableCompletedEventArgs(timetext, timeinsecond, rateperhour, totalfees);
            OnTableCompleted?.Invoke(this, e);
        }

        private byte _hourlyRate = 0;
        [
            Category("Pool Config"),
            Description("Number hours of play")
        ]
        public byte HourlyRate
        {
            get { return _hourlyRate; }
            set { _hourlyRate = value; }
        }

        private string _tablePlayer = string.Empty;
        [
            Category("Pool Config"),
            Description("The Player Name")
        ]
        public string TablePlayer
        {
            get { return _tablePlayer; }
            set { _tablePlayer = value; }
        }

        private string _tableTitle = string.Empty;
        [
            Category("Pool Config"),
            Description("The Table Name")
        ]
        public string TableTitle
        {
            get { return _tableTitle; }
            set { _tableTitle = value; }
        }

        private byte _Seconds = 0;
        private byte _Minutes = 0;
        private byte _Hours = 0;

        private void LoadDataOfTable()
        {
            gbTableName.Text = TableTitle;
            lbPlayer.Text = TablePlayer;
        }
        private bool _isConfirmed = false;
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Stop")
            {
                timer1.Stop();
                btnStartStop.Text = "Start";
                return;
            }

            frmTableInfo tableinfo = new frmTableInfo();
            tableinfo.DataBack += DataBackFromTableInfoForm;
            tableinfo.ShowDialog();

            if (!_isConfirmed)
            {
                return;
            }

            LoadDataOfTable();
            timer1.Start();
            btnStartStop.Text = "Stop";
        }

        private void DataBackFromTableInfoForm(string tablename, string playername, byte hourlyrate, bool isconfirmed)
        {
            TableTitle = tablename;
            TablePlayer = playername;
            HourlyRate = hourlyrate;
            _isConfirmed = isconfirmed;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _Seconds++;

            if (_Seconds == 60)
            {
                _Seconds = 0;
                _Minutes++;

                if (_Minutes == 60)
                {
                    _Minutes = 0;
                    _Hours++;
                }
            }

            lbSeconds.Text = _Seconds.ToString("D2");
            lbMinutes.Text = _Minutes.ToString("D2");
            lbHours.Text = _Hours.ToString("D2");
        }

        private void Reset()
        {
            btnStartStop.Text = "Start";

            _Seconds = 0;
            _Minutes = 0;
            _Hours = 0;

            lbSeconds.Text = "00";
            lbMinutes.Text = "00";
            lbHours.Text = "00";

            gbTableName.Text = "Table";
            lbPlayer.Text = "Player";
        }

        private void EndTable()
        {
            timer1.Stop();

            string timetext = _Hours.ToString("D2") + ":" + _Minutes.ToString("D2") + ":" + _Seconds.ToString("D2");
            int totalSeconds = (_Hours * 3600) + (_Minutes * 60) + _Seconds;
            float totalfees = HourlyRate * ((float)totalSeconds / 3600);

            RaiseTableCompleted(timetext, totalSeconds, HourlyRate, totalfees);

            Reset();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            EndTable();
        }
    }
}
