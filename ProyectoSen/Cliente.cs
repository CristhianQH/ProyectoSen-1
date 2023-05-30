using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSen
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.mostrarCliente(dgvCliente);
        }
        //call the function dll
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWithEllipse,
            int nHeightEllipse

            ); 
        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.modificarCliente(txtId, txtNombre, txtApellido, txtDni, txtTelefono);
            objetoCliente.mostrarCliente(dgvCliente);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.guardarCliente(txtNombre, txtApellido, txtDni, txtTelefono);
            objetoCliente.mostrarCliente(dgvCliente);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.DeleteCliente(txtId);
            objetoCliente.mostrarCliente(dgvCliente);
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            InicioAdmin admin = new InicioAdmin();
            admin.ShowDialog();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.ResetCliente();
            objetoCliente.mostrarCliente(dgvCliente);
        }

        private void dgvCliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.SelecionCliente(dgvCliente, txtId, txtNombre, txtApellido, txtDni, txtTelefono);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            //this is for login load

                       // btnRegistrarC.Region = Region.FromHrgn(CreateRoundRectRgn(0,0,btnRegistrarC.Width, btnRegistrarC.Height,30,30));
            IntPtr region = CreateRoundRectRgn(0, 0, btnSave.Width, btnSave.Height, 30, 30);
            SetWindowRgn(btnSave.Handle, region, true);

        }
    }
}
