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

            oReply = await Consumer.Execute<Usuario>(url, apiHelper.methodHttp.POST, usuarioObject);


            if (oReply != null && oReply.StatusCode == "created")
            {
                Consumer.username = txtUsuario.Text;
                Consumer.username = txtContrasena.Text;
                MessageBox.Show(oReply.StatusCode);


            }
            else
            {
                txtUsuario.Text = string.Empty;
                txtContrasena.Text = string.Empty;
                MessageBox.Show(oReply.StatusCode);

            }



        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            FormProvider.Login.Hide();
            RegistrarFrm registrar = new RegistrarFrm();
            registrar.Location = this.Location;
            registrar.StartPosition = FormStartPosition.Manual;
            registrar.ShowDialog();
            
        }
    }
}
