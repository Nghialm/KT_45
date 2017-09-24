using Vns.Erp.Core.Accounting.Domain;
using DevExpress.XtraGrid.Views;
using Vns.Erp.Core;
using DevExpress.XtraEditors;
using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Collections.Generic;
using Vns.Erp.Core.Accounting.Domain.Extend;
using System;
using System.Windows.Forms;

namespace Vns.Erp.Core.Controls.Commons
{
    public class GridHelper
    {
        public static void RefreshLeftGrid(ref DevExpress.XtraGrid.Views.Grid.GridView _GridView, ref List<CT_H_GInfo> _DataSource, CT_H_GInfo _EditObject, Vns.Erp.Core.FormGlobals.DataInputState _Status)
        {
            CT_H_GInfo grtCTH_NX = new CT_H_GInfo();
            switch (_Status)
            {
                case Vns.Erp.Core.FormGlobals.DataInputState.AddMode:
                case Vns.Erp.Core.FormGlobals.DataInputState.CopyMode:
                    _DataSource.Add(_EditObject);
                    if ((_DataSource.Count == 1))
                    {
                        _GridView.GridControl.DataSource = _DataSource;
                    }

                    _GridView.RefreshData();
                    if (_DataSource != null & _DataSource.Count > 0)
                    {
                        for (int i = 0; i <= _GridView.RowCount - 1; i++)
                        {
                            grtCTH_NX = (CT_H_GInfo)_GridView.GetRow(i);

                            if (_EditObject.Id == grtCTH_NX.Id)
                            {
                                _GridView.FocusedRowHandle = i;
                                break; // TODO: might not be correct. Was : Exit For
                            }
                        }
                    }
                    break;
                case Vns.Erp.Core.FormGlobals.DataInputState.EditMode:
                    grtCTH_NX = (CT_H_GInfo)_GridView.GetRow(_GridView.GetSelectedRows()[0]);
                    grtCTH_NX.NgayCt = _EditObject.NgayCt;
                    grtCTH_NX.NgayGhi = _EditObject.NgayGhi;
                    grtCTH_NX.SoTien = _EditObject.SoTien;
                    grtCTH_NX.MaLoaiCt = _EditObject.MaLoaiCt;
                    grtCTH_NX.Ghi = _EditObject.Ghi;
                    grtCTH_NX.DaKhoaSo = _EditObject.DaKhoaSo;
                    grtCTH_NX.Id = _EditObject.Id;
                    grtCTH_NX.CtSo = _EditObject.CtSo;
                    break;
            }
            _GridView.RefreshData();
        }

        /// <summary>
        /// Xoa ban ghi duoc lua chon tren Phieu (Luoi ben Trai)
        /// </summary>
        /// <param name="_tempList">Danh sach ban ghi</param>
        /// <param name="_ID">ID So sanh</param>
        /// <returns>True: Duoc phep lay lai du lieu theo ID dc tra ve</returns>
        /// <remarks></remarks>
        public static Guid RemoveLeftGrid(ref List<CT_H_GInfo> _tempList, Guid _ID)
        {
            for (int i = _tempList.Count - 1; i >= 0; i += -1)
            {
                if (_tempList.Count == 1)
                {
                    _tempList.RemoveAt(0);
                    return new Guid();
                }
                if (_tempList[i].Id == _ID)
                {
                    //
                    _tempList.RemoveAt(i);
                    //
                    if ((i == 0))
                    {
                        i = 1;
                    }
                    _ID = _tempList[i - 1].Id;
                    //SetObjectToControl()
                    return _ID;
                }
            }

            return new Guid();
        }

        public static bool CheckAddNewRow(DevExpress.XtraGrid.Views.Grid.GridView _GridView)
        {
            return CheckAddNewRow(_GridView, true);
        }

        public static bool CheckAddNewRow(DevExpress.XtraGrid.Views.Grid.GridView _GridView, bool _ShowConfirm)
        {
            //bool Check = true;
            if ((_GridView.IsLastRow))
            {
                int i = _GridView.Columns.Count;
                int j = -1;
                while (i >= 0)
                {
                    try
                    {
                        if (_GridView.GetVisibleColumn(i).Visible)
                        {
                            j = _GridView.GetVisibleColumn(i).AbsoluteIndex;
                            if (_GridView.FocusedColumn.AbsoluteIndex == j & !(j == -1))
                            {
                                if ((_ShowConfirm))
                                {
                                    DialogResult dr = MessageBox.Show("Bạn có muốn thêm dòng mới không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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
                            break; // TODO: might not be correct. Was : Exit While
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                    i = i - 1;
                }
            }
            return false;
        }

        public static void FormatGridView(DevExpress.XtraGrid.Views.Grid.GridView _GridView)
        {
            _GridView.OptionsView.ShowAutoFilterRow = true;
            _GridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
        }

        public static Object GetRow(DevExpress.XtraGrid.Views.Grid.GridView _GridView)
        {
            Object currentRow = _GridView.GetRow(_GridView.FocusedRowHandle);
            if (currentRow == null)
            {
                return null;
            }
            return currentRow;
        }

        public static void SetFocus_AfterAddRow(DevExpress.XtraGrid.Views.Grid.GridView _GridView, int i)
        {
            if (_GridView.RowCount > 0)
            {
                _GridView.FocusedRowHandle = i;
                _GridView.FocusedColumn = _GridView.VisibleColumns[0];
            }
        }
    }
}
