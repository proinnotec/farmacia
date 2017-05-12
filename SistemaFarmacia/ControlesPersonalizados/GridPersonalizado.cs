using System.Drawing;
using System.Windows.Forms;

namespace SistemaFarmacia.ControlesPersonalizados
{
    public class GridPersonalizado : DataGridView
    {
        public GridPersonalizado()
        {
            this.AutoGenerateColumns = false;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = true;
            this.EnableHeadersVisualStyles = false;
            this.MultiSelect = false;

            this.ReadOnly = true;
            this.RowHeadersVisible = false;
            this.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.RowTemplate.Height = 20;
            this.RowTemplate.ReadOnly = true;

            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //this.BackgroundColor = Color.Gainsboro;
            this.BackgroundColor = Color.White;
            this.BorderStyle = BorderStyle.Fixed3D;
            this.ColumnHeadersHeight = 50;

            DataGridViewCellStyle dtvAlternatingRowStyle = new DataGridViewCellStyle();
            dtvAlternatingRowStyle.BackColor = Color.White;
            //dtvAlternatingRowStyle.BackColor = Color.NavajoWhite;

            this.AlternatingRowsDefaultCellStyle = dtvAlternatingRowStyle;

            DataGridViewCellStyle dtvGridStyle = new DataGridViewCellStyle();
            dtvGridStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtvGridStyle.BackColor = Color.DimGray;
            dtvGridStyle.Font = new Font("Microsoft Sans Serif", 8.0F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dtvGridStyle.ForeColor = Color.White;
            dtvGridStyle.SelectionBackColor = SystemColors.Highlight;
            dtvGridStyle.SelectionForeColor = SystemColors.HighlightText;
            dtvGridStyle.WrapMode = DataGridViewTriState.True;

            this.ColumnHeadersDefaultCellStyle = dtvGridStyle;

            DataGridViewCellStyle dtvRowCellStyle = new DataGridViewCellStyle();
            //dtvRowCellStyle.BackColor = Color.LightGoldenrodYellow;
            dtvRowCellStyle.BackColor = Color.WhiteSmoke;
            dtvRowCellStyle.Font = new Font("Microsoft Sans Serif", 8.0F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dtvRowCellStyle.WrapMode = DataGridViewTriState.True;

            this.RowsDefaultCellStyle = dtvRowCellStyle;
        }

    }
}
