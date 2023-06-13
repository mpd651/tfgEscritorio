using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tfgEscritorio.apiHelper;
using tfgEscritorio.modelo;
using tfgEscritorio.utils;

namespace tfgEscritorio
{
    public partial class RegistrarFrm : Form
    {
        public RegistrarFrm()
        {
            InitializeComponent();
        }

        private async void btnRegistrarContrasena_Click(object sender, EventArgs e)
        {

            string url = "http://localhost:8080/api/v1/usuario/registrarPassword";

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
                
                this.Close();
                FormProvider.Login.Show();

            }
            else
            {
                txtUsuario.Text = string.Empty;
                txtContrasena.Text = string.Empty;
                MessageBox.Show(oReply.StatusCode);
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormProvider.Login.Show();
        }
    }
}
