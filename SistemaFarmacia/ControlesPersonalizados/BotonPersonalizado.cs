using System.Drawing;
using System.Windows.Forms;

namespace SistemaFarmacia.ControlesPersonalizados
{
    public class BotonPersonalizado : Button
    {
        public BotonPersonalizado()
        {
            this.BackColor = Color.LightGray;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
