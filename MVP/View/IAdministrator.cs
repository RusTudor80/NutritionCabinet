using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.View
{
    interface IAdministrator
    {
        DataGridView tabel { get; set; }

        TextBox cont { get; }
        TextBox parola { get; }
        TextBox rol { get; }
    }
}
