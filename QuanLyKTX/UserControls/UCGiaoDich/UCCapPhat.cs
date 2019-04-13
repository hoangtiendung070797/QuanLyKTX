using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using DAL;
using QuanLyKTX.Forms.FormGiaoDich;

namespace QuanLyKTX.UserControls.UCGiaoDich
{
    public partial class UCCapPhat : UserControl
    {
        public UCCapPhat()
        {
            InitializeComponent();
            listViewVatTu.Columns.Add("Mã vật tư", 200);
            listViewVatTu.Columns.Add("Tên vật tư", 200);
            listViewVatTu.Columns.Add("Số lượng", 200);

            listViewCapPhat.Columns.Add("STT", 100);
            listViewCapPhat.Columns.Add("Mã vật tư", 100);
            listViewCapPhat.Columns.Add("Tên vật tư", 100);
            listViewCapPhat.Columns.Add("Số lượng", 100);
            listViewCapPhat.Columns.Add("Đơn vị tính", 100);
            listViewCapPhat.Columns.Add("Tình trạng", 100);
            
            listViewCapPhat.Columns.Add("Đơn giá", 100);
            listViewCapPhat.Columns.Add("Thành tiền", 100);
            listViewCapPhat.Columns.Add("Ghi chú", 100);
            listViewCapPhat.GridLines = true;
            listViewCapPhat.FullRowSelect = true;

            dateEdit1.Text = DateTime.Now.ToString();



        }
        #region Properties
        BUS_VatTu BUS_VatTu = new BUS_VatTu();
        BUS_PhieuCapPhatVatTu BUS_PhieuCapPhatVatTu = new BUS_PhieuCapPhatVatTu();
        BUS_ChiTietPhieuCapPhatVatTu BUS_ChiTietPhieuCapPhatVatTu = new BUS_ChiTietPhieuCapPhatVatTu();
        BUS_Phong BUS_Phong = new BUS_Phong();
        ChiTietPhieuCapPhatVatTu ChiTietPhieuCapPhatVatTu = new ChiTietPhieuCapPhatVatTu();

        List<string> inRoom = new List<string>(); // luu vattuid

        List<string> deleteRoom = new List<string>(); // luu vat tu da xoa


        #endregion

        public void LoadVatTu(ListView listView)  // Load dữ liệu vật tư ra bảng
        {
            listView.Items.Clear();
            listView.GridLines = true;
            listView.FullRowSelect = true;
            foreach (DataRow row in BUS_VatTu.GetData().Rows)
            {
                ListViewItem item = new ListViewItem(row["VatTuId"].ToString());
                item.SubItems.Add(row["tenVatTu"].ToString());
                item.SubItems.Add(row["soLuong"].ToString());
                listView.Items.Add(item);
            }
        }

        public void LoadVatTuTimKiem(ListView listView,string text)  // Load dữ liệu vật tư ra bảng
        {
            listView.Items.Clear();
            listView.GridLines = true;
            listView.FullRowSelect = true;
            foreach (DataRow row in BUS_VatTu.SeachData(text).Rows)
            {
                ListViewItem item = new ListViewItem(row["VatTuId"].ToString());
                item.SubItems.Add(row["tenVatTu"].ToString());
                item.SubItems.Add(row["soLuong"].ToString());
                listView.Items.Add(item);
            }
        }
        public void LoadComBoBoxPhong() // load dữ liệu phòng
        {
            cbPhong.DataSource = BUS_Phong.GetData();
            cbPhong.DisplayMember = "tenPhong";
            cbPhong.ValueMember = "PhongId";
            cbPhong.Text = "";
            cbPhong.SelectedValue = "";

        }
        private void UCCapPhat_Load(object sender, EventArgs e)
        {
            LoadVatTu(listViewVatTu);
            LoadComBoBoxPhong();
            gridDSPhong.DataSource = BUS_Phong.GetDataNew();
        }

        private void listViewVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int i = 1;
        private void btnCapPhat_Click(object sender, EventArgs e)
        {
            if (cbPhong.Text == "")
            {
                MessageBox.Show("Mời chọn phòng cấp phát !", "Thông báo");
                return;
            }

            foreach (DataRow row in BUS_PhieuCapPhatVatTu.GetDataPhong().Rows)
            {

                if (cbPhong.SelectedValue.ToString() == row["PhongId"].ToString())
                {
                    MessageBox.Show("Phòng chưa có phiếu cấp phát xin mời tạo phiếu cấp phát");
                    return;
                }
            }
            foreach (ListViewItem item in listViewVatTu.SelectedItems)
            {
                FrmCapPhatVatTu frmCapPhatVatTu = new FrmCapPhatVatTu();
                frmCapPhatVatTu.txtMaVatTu.Text = item.SubItems[0].Text;
                frmCapPhatVatTu.txtTenVatTu.Text = item.SubItems[1].Text;
                for (int i = 0; i < listViewCapPhat.Items.Count; i++)
                {
                    if (listViewCapPhat.Items[i].SubItems[1].Text == item.SubItems[0].Text)
                    {
                        MessageBox.Show(listViewCapPhat.Items[i].SubItems[1].Text);
                        MessageBox.Show(item.SubItems[0].Text);
                        frmCapPhatVatTu.txtDonViTinh.Enabled = false;
                        
                        frmCapPhatVatTu.txtDonGia.Enabled = false;
                        frmCapPhatVatTu.txtTinhTrang.Enabled = false;
                        frmCapPhatVatTu.txtGhiChu.Enabled = false;
                        frmCapPhatVatTu.ShowDialog();
                        listViewCapPhat.Items[i].SubItems[3].Text = (double.Parse(listViewCapPhat.Items[i].SubItems[3].Text) + double.Parse(frmCapPhatVatTu.txtSoLuong.Text)).ToString();
                        listViewCapPhat.Items[i].SubItems[7].Text = (double.Parse(listViewCapPhat.Items[i].SubItems[3].Text) * double.Parse(listViewCapPhat.Items[i].SubItems[6].Text)).ToString();
                        return;
                    }
                }               
                frmCapPhatVatTu.ShowDialog();

                if (frmCapPhatVatTu.ckOk.Checked)
                {
                    ListViewItem capphat = new ListViewItem(i.ToString());
                    capphat.SubItems.Add(frmCapPhatVatTu.txtMaVatTu.Text);
                    capphat.SubItems.Add(frmCapPhatVatTu.txtTenVatTu.Text);
                    capphat.SubItems.Add(frmCapPhatVatTu.txtSoLuong.Text);
                    capphat.SubItems.Add(frmCapPhatVatTu.txtDonViTinh.Text);
                    capphat.SubItems.Add(frmCapPhatVatTu.txtTinhTrang.Text);
                    capphat.SubItems.Add(frmCapPhatVatTu.txtDonGia.Text);
                    capphat.SubItems.Add(frmCapPhatVatTu.txtThanhTien.Text);
                    capphat.SubItems.Add(frmCapPhatVatTu.txtGhiChu.Text);
                    listViewCapPhat.Items.Add(capphat);
                    i++;

                }
                else
                {
                    return;
                }
                listViewCapPhat.Refresh();
            }


        }

        public bool CheckInRoom(string temp) // check những thằng vật tư có trong phòng
        {
            for (int i = 0; i < inRoom.Count; i++)
            {
                if (temp == inRoom[i])
                {
                    return true;
                }

            }
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)  // xóa listview
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa vật tư này hay không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem item in listViewCapPhat.SelectedItems)
                {
                    if (CheckInRoom(item.SubItems[1].Text))
                    {
                        MessageBox.Show(BUS_ChiTietPhieuCapPhatVatTu.GetChiTietID(int.Parse(phieuID), item.SubItems[1].Text).ToString());
                        BUS_ChiTietPhieuCapPhatVatTu.Delete(BUS_ChiTietPhieuCapPhatVatTu.GetChiTietID(int.Parse(phieuID), item.SubItems[1].Text));

                        inRoom.Remove(item.SubItems[1].Text.ToString());
                    }
                    listViewCapPhat.Items.Remove(item);
                    i--;
                }
                for (int i = 0; i < listViewCapPhat.Items.Count; i++)
                {
                    listViewCapPhat.Items[i].SubItems[0].Text = (i + 1).ToString();
                }
            }
            listViewCapPhat.Refresh();
        }
        private void btnCapNhatCapPhat_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in BUS_PhieuCapPhatVatTu.GetData().Rows)
            {

                if (cbPhong.SelectedValue.ToString() == row["PhongId"].ToString() && dateEdit1.Text == DateTime.Parse(row["ngayCapPhat"].ToString()).ToString("dd/MM/yyyy"))
                {
                    if (listViewCapPhat.Items.Count == 0)
                    {
                        MessageBox.Show("Chưa có vật tư cấp phát mời kiểm tra lại !", "Thông báo");
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < listViewCapPhat.Items.Count; i++)
                        {
                            ChiTietPhieuCapPhatVatTu.ChiTietPhieuCapPhatVatTuId = BUS_ChiTietPhieuCapPhatVatTu.GetChiTietID(int.Parse(phieuID), listViewCapPhat.Items[i].SubItems[1].Text);
                            ChiTietPhieuCapPhatVatTu.PhieuCapPhatVatTuId = int.Parse(row["PhieuCapPhatVatTuId"].ToString());
                            ChiTietPhieuCapPhatVatTu.VatTuId = listViewCapPhat.Items[i].SubItems[1].Text;
                            ChiTietPhieuCapPhatVatTu.PhongId1 = cbPhong.SelectedValue.ToString();
                            ChiTietPhieuCapPhatVatTu.SoLuong = int.Parse(listViewCapPhat.Items[i].SubItems[3].Text);
                            ChiTietPhieuCapPhatVatTu.DonViTinh = listViewCapPhat.Items[i].SubItems[4].Text;
                            //ChiTietPhieuCapPhatVatTu.TinhTrang = listViewCapPhat.Items[i].SubItems[5].Text;
                            ChiTietPhieuCapPhatVatTu.DonGiaVatTu = decimal.Parse(listViewCapPhat.Items[i].SubItems[6].Text);
                            ChiTietPhieuCapPhatVatTu.ThanhTien = decimal.Parse(listViewCapPhat.Items[i].SubItems[7].Text);
                            ChiTietPhieuCapPhatVatTu.GhiChu = listViewCapPhat.Items[i].SubItems[8].Text;
                            if (BUS_ChiTietPhieuCapPhatVatTu.CheckVatTu(ChiTietPhieuCapPhatVatTu.PhieuCapPhatVatTuId, ChiTietPhieuCapPhatVatTu.VatTuId)==true)
                            {
                                BUS_ChiTietPhieuCapPhatVatTu.Update(ChiTietPhieuCapPhatVatTu);
                            }
                            else
                            {                             
                                BUS_ChiTietPhieuCapPhatVatTu.Insert(ChiTietPhieuCapPhatVatTu);                              
                            }
                        }
                        LoadData();
                    }
                   // cbPhong_SelectedValueChanged(sender, e);
                    MessageBox.Show("Đã cập nhật cấp phát !", "Thông báo");
                    return;
                }
            }
            MessageBox.Show("Chưa có phiếu cấp phát xin mời kiểm tra lại !", "Thông báo");

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            cbPhong_SelectedValueChanged(sender, e);
        }

        public void LoadData()
        {
            try
            {

                listViewCapPhat.Items.Clear();
                listViewCapPhat.Refresh();
                i = 1;
                inRoom.Clear();
                phieuID = "";


                foreach (DataRow row in BUS_PhieuCapPhatVatTu.GetData().Rows)
                {
                    if (cbPhong.SelectedValue.ToString() == row["PhongId"].ToString() && dateEdit1.Text == DateTime.Parse(row["ngayCapPhat"].ToString()).ToString("dd/MM/yyyy"))
                    {
                        phieuID = row["PhieuCapPhatVatTuId"].ToString();
                        foreach (DataRow s in BUS_ChiTietPhieuCapPhatVatTu.GetDataListView().Rows)
                        {
                            if (phieuID == s["PhieuCapPhatVatTuId"].ToString())
                            {
                                ListViewItem loadcapphat = new ListViewItem(i.ToString());
                                loadcapphat.SubItems.Add(s["VatTuId"].ToString());
                                loadcapphat.SubItems.Add(s["tenVatTu"].ToString());
                                loadcapphat.SubItems.Add(s["soLuong"].ToString());
                                loadcapphat.SubItems.Add(s["donViTinh"].ToString());
                                loadcapphat.SubItems.Add(s["tinhTrang"].ToString());
                                loadcapphat.SubItems.Add(s["donGiaVatTu"].ToString());
                                loadcapphat.SubItems.Add(s["thanhTien"].ToString());
                                loadcapphat.SubItems.Add(s["ghiChu"].ToString());
                                listViewCapPhat.Items.Add(loadcapphat);
                                inRoom.Add(s["VatTuId"].ToString());

                                i++;
                            }
                        }
                        break;
                    }

                }

            }
            catch
            {


            }
        }
        string phieuID; // Lưu mã phiếu cấp phát
        private void cbPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                listViewCapPhat.Items.Clear();
                listViewCapPhat.Refresh();
                i = 1;
                inRoom.Clear();
                phieuID = "";
                foreach (DataRow row in BUS_PhieuCapPhatVatTu.GetData().Rows)
                {
                    if (cbPhong.SelectedValue.ToString() == row["PhongId"].ToString() && dateEdit1.Text == DateTime.Parse(row["ngayCapPhat"].ToString()).ToString("dd/MM/yyyy"))
                    {
                        phieuID = row["PhieuCapPhatVatTuId"].ToString();
                        foreach (DataRow s in BUS_ChiTietPhieuCapPhatVatTu.GetDataListView().Rows)
                        {
                            if (phieuID == s["PhieuCapPhatVatTuId"].ToString())
                            {
                                ListViewItem loadcapphat = new ListViewItem(i.ToString());
                                loadcapphat.SubItems.Add(s["VatTuId"].ToString());
                                loadcapphat.SubItems.Add(s["tenVatTu"].ToString());
                                loadcapphat.SubItems.Add(s["soLuong"].ToString());
                                loadcapphat.SubItems.Add(s["donViTinh"].ToString());
                                loadcapphat.SubItems.Add(s["tinhTrang"].ToString());
                                loadcapphat.SubItems.Add(s["donGiaVatTu"].ToString());
                                loadcapphat.SubItems.Add(s["thanhTien"].ToString());
                                loadcapphat.SubItems.Add(s["ghiChu"].ToString());
                                listViewCapPhat.Items.Add(loadcapphat);
                                inRoom.Add(s["VatTuId"].ToString());

                                i++;
                            }
                        }
                        break;
                    }

                }

            }
            catch
            {
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa tất cả vật tư phòng này hay không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                
                for (int i = 0; i < listViewCapPhat.Items.Count; i++)              
                {
                    if (CheckInRoom(listViewCapPhat.Items[i].SubItems[1].Text))
                    {
                        MessageBox.Show(BUS_ChiTietPhieuCapPhatVatTu.GetChiTietID(int.Parse(phieuID), listViewCapPhat.Items[i].SubItems[1].Text).ToString());
                        BUS_ChiTietPhieuCapPhatVatTu.Delete(BUS_ChiTietPhieuCapPhatVatTu.GetChiTietID(int.Parse(phieuID), listViewCapPhat.Items[i].SubItems[1].Text));

                        inRoom.Remove(listViewCapPhat.Items[i].SubItems[1].Text);
                    }
                                      
                }
                listViewCapPhat.Items.Clear();
                i = 1;
            }
          
        }

        private void searchControlVatTu_TextChanged(object sender, EventArgs e)
        {
            if (searchControlVatTu.Text !="")
            {
                LoadVatTuTimKiem(listViewVatTu,searchControlVatTu.Text);

            }
            else
            {
                LoadVatTu(listViewVatTu);
            }
        }
    }
}
