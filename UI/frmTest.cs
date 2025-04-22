using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using System.Data.SqlClient;

namespace UI
{
    public partial class frmTest: Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection =  ConnectionHelper.GetConnection();
            int[] arr = new int[3];
            try
            {
                int x = arr[5];
                label1.Text = "Connected";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can't Connect");
                Logger.LogToEventViewer(ex.Message);
            }


        }
    }
}
