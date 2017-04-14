using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core;
using System.Windows.Forms;
using System;

namespace Vns.Erp.Core.Controls.UserControl
{
    public class KTY_UserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public HtBienBaocao Parameter_info = new HtBienBaocao();

        public ValueInfo Value_info = new ValueInfo();

        public bool NotAllowSendTab = false;

        public virtual void ReLoad(object objID)
        {
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Name = "KTY_UserControl";
            this.ResumeLayout(false);
        }

        private void KTY_UserControl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        if (!NotAllowSendTab) SendKeys.Send("{TAB}");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            { }
        }

    }
}