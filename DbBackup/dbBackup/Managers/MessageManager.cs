using DevExpress.XtraBars;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dbBackup.Managers
{
    public class MessageManager
    {
        public static void ShowErrorMessage(string message)
        {
            
            XtraMessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        public static void ShowAlertMessage(string message)
        {
            AlertControl alert = new AlertControl();

            //alert.Show()
        }

        public static void ShowToastMessage(string message)
        {

        }


        public static void ShowInfoMessage(string message)
        {
          
            FlyoutMessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
        }




        public static void ShowQuestionMessage(string message)
        {
            FlyoutMessageBox.Show(message, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
   

        }

        public static bool QuestionMessage(string message)
        {
            DialogResult res = new DialogResult();

            res = XtraMessageBox.Show(message, "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
                return true; 
            else
                return false;


             
        }



    }

    
}
