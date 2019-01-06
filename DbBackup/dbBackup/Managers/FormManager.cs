using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dbBackup.Managers
{
    public class FormManager
    {
        public void ShowDialogForm(Form _frm)
        {
            _frm.WindowState = FormWindowState.Normal;
            _frm.StartPosition = FormStartPosition.CenterScreen;
            _frm.ShowInTaskbar = false;
            try
            {
                _frm.ShowDialog();
            }
            catch
            {

            }

        }

        public void ShowMaximizedForm(Form _frm)
        {
            _frm.StartPosition = FormStartPosition.CenterScreen;
            _frm.WindowState = FormWindowState.Maximized;

            _frm.Show();
        }


        public void ShowTabbedMDIForm(Form _frm, Form _fromForm)
        {
             

            _frm.MdiParent = _fromForm;
            _frm.StartPosition = FormStartPosition.CenterScreen;
            _frm.WindowState = FormWindowState.Normal;
            _frm.ShowInTaskbar = false;
            _frm.Show();
             
        }


    }
}
