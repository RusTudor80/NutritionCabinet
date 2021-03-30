using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.View
{
    interface ISecretar
    {
        DataGridView tabel { get; set; }
        ComboBox selectie1 { get; }
        ComboBox selectie2 { get; }
        TextBox nume { get; }
        TextBox varsta { get; }
        TextBox greutate { get; }
        TextBox dieta { get; }
        TextBox search { get; }
        TextBox filtru { get; }
    }
}

