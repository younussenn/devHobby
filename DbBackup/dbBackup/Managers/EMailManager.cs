using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dbBackup.Managers
{
    public class EMailManager
    {
        static string _eMail, _pasword,_smtp;
        static int  _port;
        static bool _enableSSL;

        public static string EMail { get => _eMail; set => _eMail = value; }
        public static string Pasword { get => _pasword; set => _pasword = value; }
        public static string Smtp { get => _smtp; set => _smtp = value; }
        public static int Port { get => _port; set => _port = value; }
        public static bool EnableSSL { get => _enableSSL; set => _enableSSL = value; }
    }
}
