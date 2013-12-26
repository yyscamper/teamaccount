using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamAccount
{
    public static class yMessageBox
    {
        public static DialogResult ShowError(string txt, string title = "Error", Control parent = null)
        {
            return MessageBox.Show(txt, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowConfirm(string txt, string title = "Confirm", Control parent = null)
        {
            return MessageBox.Show(txt, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult ShowInfo(string txt, string title = "Information", Control parent = null)
        {
            return MessageBox.Show(txt, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
