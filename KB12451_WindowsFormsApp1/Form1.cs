using Infragistics.UltraChart.Resources.Appearance;
using Infragistics.UltraChart.Shared.Styles;
using Infragistics.Win.UltraWinChart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KB12451_WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			this.ultraChart1.DataSource = GetColumnData();
            this.ultraChart1.Tooltips.Overflow = TooltipOverflow.ChartArea;
			//this.ultraChart1.Tooltips.Overflow = TooltipOverflow.ClientArea;
        }

		private DataTable GetColumnData()
		{
			DataTable mydata = new DataTable();

			mydata.Columns.Add("Series Labels", typeof(string));
			mydata.Columns.Add("Column A", typeof(int));
			mydata.Columns.Add("Column B", typeof(int));
			mydata.Columns.Add("Column C", typeof(int));
			mydata.Columns.Add("Column D", typeof(int));

			mydata.Rows.Add(new Object[] { "Series A", 1, 4, 10, 4 });
			mydata.Rows.Add(new Object[] { "Series B", 3, 6, 4, 5 });
			mydata.Rows.Add(new Object[] { "Series C", 5, 8, 6, 7 });
			mydata.Rows.Add(new Object[] { "Series D", 7, 10, 7, 7 });
			return mydata;
		}
    }
}
