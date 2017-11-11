using System;
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
            [Display(Name = "Mã")]
            public int idProduct { get; set; }

            [Display(Name = "Tên")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public string name { get; set; }

            [Display(Name = "Mã hàng")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public string code { get; set; }

            [Display(Name = "Mô tả")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public string description { get; set; }

            [Display(Name = "Ảnh")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public string image { get; set; }

            [Display(Name = "Ảnh dải")]
            public string moreImage { get; set; }

            [Display(Name = "Giá")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public Nullable<decimal> price { get; set; }

            [Display(Name = "Giá khuyến mãi")]
            public Nullable<decimal> promotionPrice { get; set; }

            [Display(Name = "Chi tiết")]
            public string detail { get; set; }

            [Display(Name = "Loại")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public Nullable<int> idCategory { get; set; }

            [Display(Name = "Bảo hành")]
            public Nullable<int> wanranty { get; set; }

            [Display(Name = "Nhà cung cấp")]
            public Nullable<int> idSupplier { get; set; }

            
        }
    }
}
