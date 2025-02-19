using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareLojasRibeiro.br.com.project.VIEW
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            this.FormClosing += new FormClosingEventHandler(BaseForm_FormClosing);
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
