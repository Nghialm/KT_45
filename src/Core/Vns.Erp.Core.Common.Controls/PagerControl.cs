using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vns.Erp.Core.Common.Controls
{
    public partial class PagerControl : UserControl
    {
        private int _PageSize = 100;

        public int PageSize
        {
            get { return _PageSize; }
            set { _PageSize = value; }
        }
        private int _PageIndex = 1;

        public int PageIndex
        {
            get { return _PageIndex; }
            set { _PageIndex = value; }
        }
        private int _TotalResult = 0;

        public int TotalResult
        {
            get { return _TotalResult; }
            set { _TotalResult = value; }
        }

        private int _TotalPage = 0;

        public int TotalPage
        {
            get { return _TotalPage; }
            set { _TotalPage = value; }
        }
        public delegate void DisplayResult();
        public DisplayResult display;
        public PagerControl()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PageIndex = PageIndex + 1;
            display();
            RefreshPage();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
             
            PageIndex = PageIndex - 1;
            //btnNext.Click += DisplayResult;
            display();
            RefreshPage();
        }

        private void txtPage_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    String sPage =txtPage.Text;
                    String[] s = sPage.Split(new char[]{'/'}) ;
                    if((s!=null)&&(s.Length>0)){
                        try
                        {
                            int newPage = Int32.Parse(s[0]);
                            if (newPage <= 0) newPage = 1;
                            if (newPage > TotalPage) newPage = TotalPage;
                            this.PageIndex = newPage;
                            display();
                        }
                        catch
                        {
                        }
                    }
                    RefreshPage(); 
                    break;
            }
        }
        public void ResetPageData()
        {
            String sPageSize = txtPageSize.Text;
            try
            {
                this.PageSize = Int32.Parse(sPageSize);
                this.PageIndex = 1;
                display();
                RefreshPage();
            }
            catch
            {
                txtPageSize.Text = PageSize.ToString();
            }
        }
        public void RefreshPage()
        {
            this.TotalPage = ((this.TotalResult - 1) / PageSize) + 1;
            this.txtPage.Text = this.PageIndex.ToString() + "/" + this.TotalPage.ToString();
            if (PageIndex > 1)
            {
                btnBack.Enabled = true;
            }
            else
            {
                btnBack.Enabled = false;
            }
            if (PageIndex * PageSize < TotalResult)
            {
                btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }
        }
        private void PagerControl_Load(object sender, EventArgs e)
        {
            this.txtPage.Text  = this.PageIndex.ToString() + "/" + this.TotalPage.ToString();
            this.txtPageSize.Text = PageSize.ToString(); 
        }

        private void txtPageSize_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ResetPageData();
                    break;
            }
        }

    }
}
