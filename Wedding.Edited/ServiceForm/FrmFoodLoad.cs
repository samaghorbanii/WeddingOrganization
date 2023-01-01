using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wedding.Edited.Controlers;
using Wedding.Edited.Generate;
using WeddingDB.IRepository;

namespace Wedding.Edited.ServiceForm
{
    public partial class FrmFoodLoad : Form
    {
        private readonly IWeddingServiceRepository weddingServiceRepository;
        public FrmFoodLoad()
        {
            InitializeComponent();
            Foodload();
        }
        public void Foodload()
        {
            var food = Generat.FillDataGridView(1);
            flowLayoutPanel1.Controls.AddRange(food.ToArray());
        }
    }
}
