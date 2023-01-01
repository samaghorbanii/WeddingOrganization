using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wedding.Edited.EditeForm;
using Wedding.Edited.ServiceForm;

namespace Wedding.Edited
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Foods_Click(object sender, EventArgs e)
        {
            var frmFood = new FrmFoodLoad();
            frmFood.Show();
        }

        private void Addservice_Click(object sender, EventArgs e)
        {
            var frmAdd = new AddService();
            frmAdd.Show();
        }
    }
}
