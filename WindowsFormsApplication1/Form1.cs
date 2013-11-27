using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.ItimeServiceClient c = null;

            try
            {
                c = new ServiceReference1.ItimeServiceClient();
                c.Open();

                // get the server value.
                this.label2.Text = c.DoWork();

                c.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (c != null && c.State != System.ServiceModel.CommunicationState.Faulted)
                {
                    ((IDisposable)c).Dispose();
                }

            }
        }

    }
}