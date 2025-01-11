using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.Models;
using Tienda.Utils;
using Tienda.Views.VwFabricantes;

namespace Tienda.Views.VwFabricante
{
    public partial class FrmFabricante : Form
    {

        bool IsEditar = false;
        int Id;
        string Nombres;
        public FrmFabricante()
        {
            InitializeComponent();
            Id = 0;
            Nombres = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmFabricante_Load(object sender, EventArgs e)
        {
            Buscar();

            MEmpleados ep = new MEmpleados();



        }
        void Buscar()
        {
            DtFabricante.DataSource = new Controllers.CFabricante().Show(TxtBusqueda.Text.Trim());
            DtFabricante.Refresh();

            LblTotalRegistros.Text = DtFabricante.Rows.Count.ToString() + " Registros en total.";
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtFabricante.Text != string.Empty)
            {
                if (!IsEditar)
                {
                    string Insertar = new Controllers.CFabricante().Add(new Models.MFabricante() { Nombres = TxtFabricante.Text.Trim() });
                    Utils.Utilities.Mensaje(Insertar.Equals("Ok") ? "Registro almacenado Correctamente" : Insertar);
                    LimpiarTxt();
                }
                else
                {
                    string Actualizar = new Controllers.CFabricante().Update(
                        new Models.MFabricante()
                        {
                            Id = Convert.ToInt32(TxtId.Text.Trim()),
                            Nombres = TxtFabricante.Text.Trim()
                        }
                    );
                    Utils.Utilities.Mensaje(Actualizar.Equals("Ok") ? "Registro Actualizado Correctamente" : Actualizar);
                    LimpiarTxt();
                    IsEditar = false;
                }
            }
            else
            {
                Utilities.Mensaje("No hay Información para agregar.", true);
            }
            Buscar();
        }

        void LimpiarTxt()
        {
            TxtId.Clear();
            TxtFabricante.Clear();
        }

        private void DtFabricante_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
            IsEditar = false;
        }

        private void DtFabricante_DoubleClick(object sender, EventArgs e)
        {
            TxtId.Text = DtFabricante.CurrentRow.Cells["id"].Value.ToString();
            TxtFabricante.Text = DtFabricante.CurrentRow.Cells["nombre"].Value.ToString();
            IsEditar = true;
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            VwFabricanteAdd frm = new VwFabricanteAdd();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            this.Buscar();

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnAddNew_Click(sender, e);
        }

        private void refrescarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Id= Convert.ToInt32(DtFabricante.CurrentRow.Cells["Id"].Value);
                Nombres = DtFabricante.CurrentRow.Cells["nombre"].Value.ToString();
                VwFabricanteAdd frm = new VwFabricanteAdd(Id,Nombres);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                this.Buscar();
            }
            catch (Exception ex)
            {
                if (Id == 0) { 
                    Utilities.Mensaje("Seleccione un Fabricante",true); } else
                {
                    Utilities.Mensaje(ex.Message,true);
                }

            }
            
        }
    }
}
