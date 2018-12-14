using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MiProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Slider_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else 
            {
                MenuVertical.Width = 250;
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestaurar.Visible = true;
            iconMaximizar.Visible = false;
        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestaurar.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MenuVertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /*navegacion de mi menu de presentacion*/
        private void AbrirFormInPanel(object formhijo) 
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnproducto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Producto());
        }
        
        private void btnventas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Venta());
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Cliente());
        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Proveedor());
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Empleado());
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Compras());
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Reporte());
        }

    }
}
