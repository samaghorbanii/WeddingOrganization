using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingDB.IRepository;
using WeddingDB.Repository;
using WeddingDB;
using Wedding.Edited.ValueControler;

namespace Wedding.Edited.Generate
{
    public class Generat
    {
        private static readonly IWeddingServiceRepository weddingServiceRepository;
        static Generat()
        {
            weddingServiceRepository = new WeddingServiceRepository();
        }


        public static List<ValueControl> FillDataGridView(int id)
        {
            var dt = weddingServiceRepository.GetAll(id);
            var service = MapToService(dt);
            var gp = service.Values.Select(x => x.GroupValue).Distinct();

            var valueControls = new List<ValueControl>();
            foreach (var groupValue in gp)
            {
                var valueControl = new ValueControl();
                valueControl.Name = Guid.NewGuid().ToString();
                int yPosition = 200;

                foreach (var Property in service.Properties)
                {
                    yPosition += 50;


                    var lblName = new Label();
                    lblName.Text = Property.Name;
                    lblName.Name = Guid.NewGuid().ToString();
                    lblName.Location = new Point(100, yPosition);

                    lblName.Size = new Size(120, 50);
                    var value = service.Values.Where(x => x.GroupValue == groupValue).Where(x => x.PropertyId == Property.PropertyId).First();

                    var lblValue = new Label();
                    lblValue.Name = Guid.NewGuid().ToString();
                    lblValue.Text = value.PropertyValue;
                    lblValue.Location = new Point(200, yPosition);
                    lblValue.Size = new Size(120, 50);

                    valueControl.gpPropertyValue.Controls.Add(lblValue);
                    valueControl.gpPropertyValue.Controls.Add(lblName);

                }
                valueControls.Add(valueControl);
            }
            return valueControls;
        }

        private static Service MapToService(DataTable dt)
        {
            var service = new Service();
            var properties = new List<Property>();
            var values = new List<Value>();

            var valueGroup = dt.AsEnumerable().GroupBy(x => x["ValueGroup"]);

            var firstGroup = valueGroup.First();
            var firsDataRow = firstGroup.Select(x => x).First();

            service.Id = Convert.ToInt32(firsDataRow["ServiceId"].ToString());
            service.Name = firsDataRow["ServiceName"].ToString();


            foreach (var group in valueGroup)
            {
                foreach (var dataRow in group)
                {
                    int propertyId = Convert.ToInt32(dataRow["PropertyId"].ToString());
                    if (!properties.Any(x => x.PropertyId == Convert.ToInt32(dataRow["PropertyId"].ToString())))
                    {
                        var property = new Property
                        {
                            PropertyId = propertyId,
                            Name = dataRow["PropertyName"].ToString(),

                        };

                        properties.Add(property);
                    }

                    var value = new Value
                    {
                        PropertyId = propertyId,
                        PropertyValue = dataRow["PropertyValue"].ToString(),
                        GroupValue = dataRow["ValueGroup"].ToString()
                    };

                    values.Add(value);
                }
            }
            service.Properties = properties;
            service.Values = values;
            return service;
        }
    }
}

