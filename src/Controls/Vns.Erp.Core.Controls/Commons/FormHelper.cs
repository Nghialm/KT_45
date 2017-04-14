using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Vns.Erp.Core.Controls.Commons
{
    public class FormHelper
    {
        public static bool CheckStatusEscape(Vns.Erp.Core.FormGlobals.DataInputState inputState)
        {
            try
            {
                Vns.Erp.Core.FormGlobals.DataInputState m_InputState = default(Vns.Erp.Core.FormGlobals.DataInputState);
                m_InputState = inputState;
                if (m_InputState == Vns.Erp.Core.FormGlobals.DataInputState.AddMode)
                {
                    DialogResult dr = MessageBox.Show("Bạn muốn thoát khỏi chương trình nhập và mọi dữ liệu chưa lưu sẽ bị xóa mất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dr == DialogResult.Yes)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
                return false;
            }
        }

        #region "Validate"

        private static Control[] _RequireInputControl;

        private static DXErrorProvider _ErrorProvider;
        public static DXErrorProvider ErrorProvider
        {
            get
            {
                if (_ErrorProvider == null)
                {
                    _ErrorProvider = new DXErrorProvider();
                }
                return _ErrorProvider;
            }
            set { _ErrorProvider = value; }
        }

        public static Control[] RequireInputControls
        {
            get { return _RequireInputControl; }
            set { _RequireInputControl = value; }
        }

        public static void ApplyRequireInputValidate(Control[] RequireInputControls)
        {
            if (RequireInputControls == null)
            {
                return;
            }

            foreach (Control _Control in RequireInputControls)
            {
                //Dim lbl As New LabelControl()
                //lbl.Text = "*"
                //lbl.ForeColor = System.Drawing.Color.Red
                //_Control.Parent.Controls.Add(lbl)
                //lbl.Location = New Point(_Control.Location.X - 10, _Control.Location.Y)
                _Control.Validating += new CancelEventHandler(ValidateRequireInput);
            }
        }

        public static void ValidateRequireInput(Object sender, CancelEventArgs e)
        {
            object value = string.Empty;
            bool support = false;
            if (sender is TextEdit)
            {
                value = ((TextEdit)sender).Text.Trim();
                support = true;
            }
            if (sender is LookUpEdit)
            {
                value = ((LookUpEdit)sender).EditValue;
                support = true;
            }

            if (sender is GridLookUpEdit)
            {
                value = ((GridLookUpEdit)sender).EditValue;
                support = true;
            }
            if (sender is DateEdit)
            {
                value = ((DateEdit)sender).EditValue;
                support = true;
            }
            if (!support)
            {
                throw new Exception(String.Format(GeneralString.VALIDATE_REQUIRE_NOT_SUPPORT_CONTROL, sender.GetType().ToString()));
            }

            Control ctl = sender as Control;

            if (value == null || value.ToString().Length == 0)
            {
                ErrorProvider.SetIconAlignment(ctl, ErrorIconAlignment.MiddleRight);
                ErrorProvider.SetError(ctl, GeneralString.NO_INPUT_DATA);
                //e.Cancel = True
            }
            else
            {
                ErrorProvider.SetErrorType(ctl, ErrorType.None);
            }
        }
        #endregion
    }
}
