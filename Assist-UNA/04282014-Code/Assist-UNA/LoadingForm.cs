using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

/*************************************************************************************************
 * 
 * Name: InputForm class
 * 
 * ================================================================================================
 * 
 * Description: This class is a loading form used when starting ASSIST-UNA.
 *                            
 * ================================================================================================
 * 
 * Modification History
 * --------------------
 * 03/22/2014   ACA     Original version.
 *   
 *************************************************************************************************/
namespace Assist_UNA
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingFormShown(object sender, EventArgs e)
        {
            //int counter = 0;
            //while (counter < 100)
            //{
            //    Thread.Sleep(500);
            //    if (counter % 3 != 0)
            //        txtLoading.Text += ".";
            //    else
            //        txtLoading.Text = "Loading ASSIST-UNA, Please wait";
            //    this.Refresh();
            //    Application.DoEvents();
            //}
        }
    }
}
