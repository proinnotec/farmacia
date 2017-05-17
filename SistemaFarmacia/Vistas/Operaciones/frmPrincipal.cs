using System.Windows.Forms;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using SistemaFarmacia.Vistas.Base;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Controladores;

namespace SistemaFarmacia.Vistas.Operaciones
{
    public partial class frmPrincipal : frmBase
    {
        public ContextoAplicacion _contextoAplicacion { get; set; }
        private frmPrincipalController _frmPrincipalController { get; set; }   
                        
        public frmPrincipal(Usuario usuario)
        {
            usuario.IdUsuario = 1;
            usuario.Nombre = "Luis F.";
            usuario.ApellidoPaterno = "Osuna";
            usuario.ApellidoPaterno = "Leyva";
            usuario.NombreUsuario = "LFOL";

            InitializeComponent();
            _frmPrincipalController = new frmPrincipalController(this);
            _contextoAplicacion = new ContextoAplicacion();
            _contextoAplicacion.Usuario = usuario;               
        }                          

        private void CargarMenu()
        {
            mnsOpciones.Items.Clear();

            _frmPrincipalController.CargarMenu(_contextoAplicacion.Usuario.IdUsuario);

        }

        private void recorrerItems(ElementoMenu opcionReferencia)
        {
            foreach (ToolStripMenuItem toolStripMenuItem in mnsOpciones.Items)
            {
                AgregaHijos(toolStripMenuItem, opcionReferencia);
            }
        }

        private void AgregaHijos(ToolStripMenuItem toolStripMenuItemPrincipal, ElementoMenu opcionReferencia)
        {
            if (toolStripMenuItemPrincipal.Name == opcionReferencia.IdPadre.ToString())
            {                
                if (opcionReferencia.Vista == string.Empty)
                {
                    ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
                    toolStripMenuItem.Name = opcionReferencia.IdMenu.ToString();
                    toolStripMenuItem.Text = opcionReferencia.TextoVinculo;
                    toolStripMenuItem.ToolTipText = opcionReferencia.Descripcion;
                    toolStripMenuItem.Click += new EventHandler(MenuItemClickHandler);
                    toolStripMenuItemPrincipal.DropDownItems.Add(toolStripMenuItem);                    
                }
                else
                {
                    ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
                    toolStripMenuItem.Name = opcionReferencia.IdMenu.ToString();
                    toolStripMenuItem.Text = opcionReferencia.TextoVinculo;
                    toolStripMenuItem.Tag = opcionReferencia.Vista;
                    toolStripMenuItem.ToolTipText = opcionReferencia.Descripcion;
                    toolStripMenuItem.Click += new EventHandler(processMenuItem);
                    toolStripMenuItemPrincipal.DropDownItems.Add(toolStripMenuItem);                    
                }

            }

            foreach (ToolStripMenuItem toolStripMenuItem in toolStripMenuItemPrincipal.DropDown.Items)
            {
                if (toolStripMenuItemPrincipal is ToolStripMenuItem)
                {
                    AgregaHijos(toolStripMenuItem as ToolStripMenuItem, opcionReferencia);
                }

            }

        }

        public void CrearMenu(List<ElementoMenu> Lista, int IdPadre)
        {
            foreach (ElementoMenu opcionDeMenu in Lista)
            {
                if (opcionDeMenu.Vista == string.Empty)
                {                   
                    if (opcionDeMenu.IdPadre == IdPadre)
                    {
                        ToolStripMenuItem item = new ToolStripMenuItem();
                        item.Name = opcionDeMenu.IdMenu.ToString();
                        item.Text = opcionDeMenu.TextoVinculo;
                        item.ToolTipText = opcionDeMenu.Descripcion;
                        item.Click += new EventHandler(MenuItemClickHandler);
                        mnsOpciones.Items.Add(item);
                    }
                    else
                    {
                        ToolStripMenuItem item = new ToolStripMenuItem();
                        item.Name = opcionDeMenu.IdMenu.ToString();
                        item.Text = opcionDeMenu.TextoVinculo;
                        item.ToolTipText = opcionDeMenu.Descripcion;
                        item.Click += new EventHandler(MenuItemClickHandler);
                        recorrerItems(opcionDeMenu);
                    }

                }
                else
                {
                    recorrerItems(opcionDeMenu);
                }

            }
        }      

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;    
        }

        private void processMenuItem(object sender, EventArgs e)
        {          
            Assembly assembly = Assembly.GetEntryAssembly();
            string nombreForma = ((ToolStripMenuItem)sender).Tag.ToString();            
            string[] elementosForma = nombreForma.Split('.');
            string carpeta = elementosForma[0];
            string vista = elementosForma[1];
            bool estaFormuarioAbierto = EstaFormuarioAbierto(vista);       
            string nameSpace = "SistemaFarmacia.Vistas";
            string vistaCompleta = string.Format("{0}.{1}.{2}", nameSpace, carpeta, vista);
            Type tipoDeForma = assembly.GetType(vistaCompleta);       
            Form forma = (Form)Activator.CreateInstance(tipoDeForma, _contextoAplicacion);
            forma.MdiParent = this;          
            
            if (!estaFormuarioAbierto)
            {
                forma.Show();
            }
            
        }

        private bool EstaFormuarioAbierto(string nombreVista)
        {
            List<Form> vistasAbiertas = Application.OpenForms.Cast<Form>().ToList();

            bool existeVista = vistasAbiertas.Exists(elemento => elemento.Name == nombreVista);

            if (existeVista)
            {
                Form vistaAbierta = vistasAbiertas.Find(elemento => elemento.Name == nombreVista);
                vistaAbierta.Focus();
            }

            return existeVista;
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            string nombreUsuario = string.Format("Nombre: {0} {1} {2}", _contextoAplicacion.Usuario.ApellidoPaterno, _contextoAplicacion.Usuario.ApellidoMaterno, _contextoAplicacion.Usuario.Nombre);
            tsslNombre.Text = nombreUsuario;
            tsslServidor.Text = string.Format("Servidor: {0}", _frmPrincipalController.Servidor);
            tsslBaseDatos.Text = string.Format("Base datos: {0}", _frmPrincipalController.NombreBaseDatos);
            tsslUsuario.Text = string.Format("Usuario: {0}", _contextoAplicacion.Usuario.NombreUsuario);
            CargarMenu();
        }
    }
}

