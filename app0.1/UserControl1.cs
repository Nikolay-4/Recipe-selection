using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app0._1
{
    public partial class UserControl1 : UserControl
    {
        public bool btnFlag;
        Recipe data;
        public static UserControl1 old;
        public static Form1 frm;
        public static Control.ControlCollection ctrl;
        public UserControl1(Recipe arg)
        {
            InitializeComponent();
            txtName.Text = arg.name;
            txtDesc.Text = arg.preview;
            data = arg;
            btnFlag = false;
            old = null;
            ctrl = null;
        }

        private void reWriteTop()
        {
            int topSize = 0;
            foreach (var i in ctrl)
            {
                var k = i as UserControl1;
                k.Top = topSize;
                topSize += k.Height + 1;

            }
        }

        public void btnCmd_Click(object sender, EventArgs e)
        {
            int cnt = 240;
            if (btnFlag)
            {
                btnCmd.Text = "Развернуть";
                btnFlag = false;
                txtDesc.Text = data.preview;
                this.Height -= cnt;
                txtDesc.Height -= cnt;
                old = null;
            } else
            {
                if (old != null)
                    old.btnCmd_Click(sender, e);
                btnCmd.Text = "Свернуть";
                btnFlag = true;
                txtDesc.Text = data.description;
                this.Height += cnt;
                txtDesc.Height += cnt;
                old = this;
            }
            reWriteTop();
        }
    }
}
