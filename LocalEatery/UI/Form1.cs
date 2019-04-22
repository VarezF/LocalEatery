using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Tabs.TabPages;
            DataGridViewRow row = (DataGridViewRow)Tables.Rows[0].Clone();
            row.Cells["Column2"].Value = "Waiter";
            row.Cells["Column3"].Value = "Status";
            Tables.Rows.Add(row);
        }

    }
}
