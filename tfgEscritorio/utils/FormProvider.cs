using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfgEscritorio.utils
{
    public class FormProvider
    {
        public static LoginFrm Login
        {
            get
            {
                if (_loginFrm == null)
                {
                    _loginFrm = new LoginFrm();
                }
                return _loginFrm;
            }
        }

        private static LoginFrm _loginFrm;

        public static RegistrarFrm Registrar
        {
            get
            {
                if (_registrarFrm == null)
                {
                    _registrarFrm = new RegistrarFrm();
                }
                return _registrarFrm;
            }
        }

        private static RegistrarFrm _registrarFrm;


        public static VentanaPrincipalFrm VentanaPrincipal
        {
            get
            {
                if (_ventanaFrm == null)
                {
                    _ventanaFrm = new VentanaPrincipalFrm();
                }
                return _ventanaFrm;
            }
        }

        private static VentanaPrincipalFrm _ventanaFrm;
    }



}
