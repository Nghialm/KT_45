using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Vns.Erp.Core.Controls.UserControl
{
    //[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    partial class C_SoChungTu : DevExpress.XtraEditors.XtraUserControl
    {

        //UserControl overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //Required by the Windows Form Designer

        private System.ComponentModel.IContainer components;
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.txtSO_CT = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)this.txtSO_CT.Properties).BeginInit();
            this.SuspendLayout();
            //
            //txtSO_CT
            //
            this.txtSO_CT.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.txtSO_CT.Location = new System.Drawing.Point(0, 0);
            this.txtSO_CT.Name = "txtSO_CT";
            this.txtSO_CT.Size = new System.Drawing.Size(89, 20);
            this.txtSO_CT.TabIndex = 0;
            //
            //C_SoChungTu
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSO_CT);
            this.Name = "C_SoChungTu";
            this.Size = new System.Drawing.Size(90, 20);
            ((System.ComponentModel.ISupportInitialize)this.txtSO_CT.Properties).EndInit();
            this.ResumeLayout(false);

        }

        internal DevExpress.XtraEditors.TextEdit txtSO_CT;
    }
}