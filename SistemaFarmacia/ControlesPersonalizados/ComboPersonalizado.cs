using System.Drawing;
using System.Windows.Forms;

namespace SistemaFarmacia.ControlesPersonalizados
{
    public class ComboPersonalizado : ComboBox
    {
        public ComboPersonalizado()
        {
            this.BackColor = Color.White;
            this.DropDownStyle = ComboBoxStyle.DropDownList;            
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
