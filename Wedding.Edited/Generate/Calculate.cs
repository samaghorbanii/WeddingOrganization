using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wedding.Edited.Controlers;
using Wedding.Edited.ValueControler;
using WeddingDB.IRepository;
using WeddingDB.Repository;
using static System.Net.Mime.MediaTypeNames;

namespace Wedding.Edited.Generate
{
    public class Calculate
    {
        private  readonly IWeddingServiceRepository weddingServiceRepository;
        private List<ValueControl> valueControls;
        public Calculate()
        {
            weddingServiceRepository = new WeddingServiceRepository();
            Full();
        }

        public void Full()
        {
            var valueControl = Generat.FillDataGridView(1);
            valueControls = valueControl;
        }
        public CalControl CalculatePrice()
        {
            var calControl = new CalControl();
            double sum = 0;
            foreach (var item in valueControls)
            {
                var txtBox = item.txtCount.Text;

                if (!string.IsNullOrEmpty(txtBox))
                {
                    var count = Convert.ToInt32(txtBox);
                    var price = item.gpPropertyValue.Controls.Find("price", true).First() as Label;
                    var dPrice = Convert.ToDouble(price);
                    sum += dPrice * count;
                }
            }
            return calControl;
        }
    }

 

}
