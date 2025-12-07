using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viajes.View
{
    internal class UiHelpers
    {
        public static void MostrarError(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        public static void MostrarErrorSql(Exception ex)
        {
            MessageBox.Show(
                "Error de base de datos:\n" + ex.Message,
                "Error de base de datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}
