using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.Controllers;
using Tienda.Models;
using Tienda.Utils;

namespace Tienda.Views.VwFabricantes
{
    public partial class VwFabricanteAdd : Form
    {
        public int Id { get; set; }
        public string Nombres { get; set; } 

        bool editar = false;
        public VwFabricanteAdd(int id = 0,string nombres = "")
        {
            InitializeComponent();
            Id = id;
            Nombres = nombres;
            TxtFabricante.Text= Nombres;
            if (Id > 0)
            {
                editar = true;
                this.Text = "Actualizar Fabricante.";
                BtnGuardar.Text = "Actualizar";
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                MFabricante fabricante = new MFabricante()
                {
                    Id=this.Id,
                    Nombres = TxtFabricante.Text.Trim().ToUpper()
                };
                CFabricante guardar = new CFabricante();
                string respuesta = "";
                if (!editar)
                {
                    respuesta = guardar.Add(fabricante);

                    if (respuesta.Equals("Ok"))
                    {
                        Utilities.Mensaje("Registro Guardado con Éxito.");
                        this.Dispose();
                    }
                    else
                    {
                        Utilities.Mensaje(respuesta, true);
                    }

                }
                else
                {
                    respuesta = guardar.Update(fabricante);

                    if (respuesta.Equals("Ok"))
                    {
                        Utilities.Mensaje("Registro Actualizado con Éxito.");
                        this.Dispose();
                    }
                    else
                    {
                        Utilities.Mensaje(respuesta, true);
                    }

                }
            }            
        }

        bool validar() {
            bool rp = false;
            if (TxtFabricante.Text != string.Empty) {
                rp = true;
            }
            else { rp=false; }
            return rp;
        }
    }
}
