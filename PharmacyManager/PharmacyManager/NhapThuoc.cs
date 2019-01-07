using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManager.UserControlMain;
namespace PharmacyManager
{
    public partial class NhapThuoc : DevExpress.XtraEditors.XtraForm
    {
        ThemThuocMoi ucThemThuoc = new ThemThuocMoi();
        public NhapThuoc()
        {
            InitializeComponent();
        }
        string MaThuoc; 
        string TenThuoc;
        string HoatChat;
        int GiaNhap;
        int GiaSauThue;
        int GiaHop;
        int Hop;
        int Vi;
        int GiaVi;
        int Vien;
        int GiaVien;
        int Goi;
        int GiaGoi;
        int QuyDinh;
        float THSuDung;
        int KhoiTao = 0;
        public NhapThuoc(string MaThuoc, string TenThuoc, string HoatChat, int GiaNhap, int GiaSauThue, int GiaHop, int Hop, int Vi, int GiaVi, int Vien, int GiaVien, int Goi, int GiaGoi, int QuyDinh, float THSuDung)
        {
            InitializeComponent();
            this.MaThuoc=MaThuoc;
            this.TenThuoc=TenThuoc;
            this.HoatChat=HoatChat;
            this.GiaNhap=GiaNhap;
            this.GiaSauThue=GiaSauThue;
            this.GiaHop=GiaHop;
            this.Hop=Hop;
            this.Vi=Vi;
            this.GiaVi=GiaVi;
            this.Vien=Vien;
            this.GiaVien=GiaVien;
            this.Goi=Goi;
            this.GiaGoi=GiaGoi;
            this.QuyDinh=QuyDinh;
            this.THSuDung = THSuDung;
            KhoiTao = 1;
        }
        private void NhapThuoc_Load(object sender, EventArgs e)
        {
            this.Controls.Add(ucThemThuoc);
            if(KhoiTao==1)
                ucThemThuoc.Setgt(MaThuoc,TenThuoc,HoatChat,GiaNhap,GiaSauThue,GiaHop,Hop,Vi,GiaVi,Vien,GiaVien,Goi,GiaGoi,QuyDinh,THSuDung);
        }
    }
}
