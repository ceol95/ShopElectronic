using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using 2 thư viện thiết kế class metadata
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model.EF
{
    //Kieu thuoc tinh cho lop nay
    [MetadataTypeAttribute(typeof(Product))]
    // partial giup class noi voi class cung ten trong EF
    public partial class Product
    {
        //internal Chi dung cho class nay
        //sealed khong cho phep ke thua
        internal sealed class ProductMetadata
        {
            [Display(Name = "")]
            public int idProduct { get; set; }

            [Display(Name = "")]
            public string name { get; set; }

            [Display(Name = "")]
            public string code { get; set; }

            [Display(Name = "")]
            public string description { get; set; }

            [Display(Name = "")]
            public string image { get; set; }

            [Display(Name = "")]
            public string moreImage { get; set; }

            [Display(Name = "")]
            public Nullable<decimal> price { get; set; }

            [Display(Name = "")]
            public Nullable<decimal> promotionPrice { get; set; }

            [Display(Name = "")]
            public string detail { get; set; }

            [Display(Name = "")]
            public Nullable<int> idCategory { get; set; }

            [Display(Name = "")]
            public Nullable<int> wanranty { get; set; }

            [Display(Name = "")]
            public Nullable<int> idSupplier { get; set; }


            [Display(Name = "Ảnh bìa")]
            public string Image { get; set; }

            [Display(Name = "Mã")]
            public int IDBaiDang { get; set; }

            [Display(Name = "Chủ đề lớn")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public Nullable<int> IDLoaiBaiDang { get; set; }

            [Display(Name = "Chủ đề nhỏ")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public Nullable<int> IDLoaiCon { get; set; }

            [Display(Name = "Tiêu đề")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public string TieuDe { get; set; }

            [Display(Name = "Nội dung")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public string NoiDung { get; set; }

            [Display(Name = "Miêu tả")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public string MieuTa { get; set; }

            [Display(Name = "Trạng thái")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public string TrangThai { get; set; }

            [Display(Name = "Ngày viết")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            public Nullable<System.DateTime> NgayViet { get; set; }

        }
    }
}
