using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliothèqueSqlite.Class
{
    public static class MasterClass
    {
        public static string ErrorText { get { return "هذه الخانة مطلوبه"; } }
        public static string ErrorRepeater { get { return "هذا الاسم مستخدم بالفعل مسبقا"; } }

        public static ErrorProvider EP = new ErrorProvider();
        public static void EpClear()
        {
            EP.Clear();
        }
        public static bool IsTextValide(this TextBox txt)
        {
            if (txt.Text.Trim() == string.Empty)
            {
                EP.SetError(txt, ErrorText);
                return false;
            }
           
            return true;
        }
        public static bool IsEditValue(this NumericUpDown spn)
        {
            if (spn.Value <= 0)
            {
                EP.SetError(spn, ErrorText);
                return false;
            }
         
            return true;
        }
        public static bool IsSelectValue(this ComboBox cmb)
        {
            if (cmb.SelectedValue == null)
            {
                EP.SetError(cmb, ErrorText);
                return false;
            }

            return true;
        }
    }
}
