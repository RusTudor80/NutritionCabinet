using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MVP.Presenter;
using MVP.Model;

namespace MVP.View
{
    interface IDieteticean
    {
        DataGridView tabel { get; set; }
        ComboBox selectie { get; }
        ComboBox grafic { get; }
        TextBox search { get; }
        TextBox filtru { get; }
        Chart statistica { get; set; }
    }
}
