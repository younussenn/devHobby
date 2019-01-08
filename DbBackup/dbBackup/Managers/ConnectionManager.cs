using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dbBackup.Managers
{
    public class ConnectionManager
    {
        static string _server, _database, _user, _password;
        static int _isWindowsAuth;
        public static string Password
        {
            get { return ConnectionManager._password; }
            set { ConnectionManager._password = value; }
        }

        public static string User
        {
            get { return ConnectionManager._user; }
            set { ConnectionManager._user = value; }
        }

        public static string Database
        {
            get { return ConnectionManager._database; }
            set { ConnectionManager._database = value; }
        }

        public static string ServerName
        {
            get { return ConnectionManager._server; }
            set { ConnectionManager._server = value; }
        }

        public static int IsWindowsAuthentication
        {
            get { return ConnectionManager._isWindowsAuth; }
            set { ConnectionManager._isWindowsAuth = value; }
        }



    }
}
