using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tfgEscritorio.apiHelper;
using tfgEscritorio.modelo;
using tfgEscritorio.utils;

namespace tfgEscritorio
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private async void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:8080/api/v1/usuario/login";

            Usuario usuarioObject = new Usuario();
            usuarioObject.userName = txtUsuario.Text;
            usuarioObject.password = txtContrasena.Text;
            usuarioObject.rol = "ADMINISTRADOR";

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Usuario>(url, apiHelper.methodHttp.POST, usuarioObject, false);


            if (oReply != null && oReply.StatusCode == "Created")
            {
                Consumer.username = txtUsuario.Text;
                Consumer.password = txtContrasena.Text;
                txtUsuario.Text = string.Empty;
                txtContrasena.Text = string.Empty;
                FormProvider.Login.Hide();

                FormProvider.VentanaPrincipal.Location = this.Location;
                FormProvider.VentanaPrincipal.StartPosition = FormStartPosition.Manual;
                FormProvider.VentanaPrincipal.Show();
            }
            else
            {
                txtUsuario.Text = string.Empty;
                txtContrasena.Text = string.Empty;
                MessageBox.Show(oReply.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;

            FormProvider.Login.Hide();
            FormProvider.Registrar.Location=this.Location;
            FormProvider.Registrar.StartPosition = FormStartPosition.Manual;
            FormProvider.Registrar.Show();
            
        }
    }
}
