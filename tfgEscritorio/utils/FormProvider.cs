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
    }
}
