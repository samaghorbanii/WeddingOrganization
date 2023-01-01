using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wedding.Edited.EditeForm
{
    public partial class AddService : Form
    {
        int yPosition = 50;
        public AddService()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var textBox = new TextBox();
            textBox.Name =Guid.NewGuid().ToString();
            textBox.Location = new Point(200, yPosition);
            var op=new OpenFileDialog();
            this.Controls.Add(textBox);
           // this.Controls.Add(op);
            yPosition += 50;

        }
    }
}
