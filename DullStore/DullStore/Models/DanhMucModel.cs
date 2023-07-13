using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DullStore.Models
{
    public class DanhMucModel
    {
        public List<SanPhamModel> ListAdidas { get; set; }

        public List<SanPhamModel> ListNike { get; set; }

        public List<SanPhamModel> ListSupreme { get; set; }

        public List<SanPhamModel> ListJordan { get; set; }

        public List<SanPhamModel> ListPuma { get; set; }
        public List<SanPhamModel> ListBalenciaga { get; set; }

        public List<SanPhamModel> D1 { get; set; }
        public List<SanPhamModel> D2 { get; set; }
        public List<SanPhamModel> D3 { get; set; }
        public List<SanPhamModel> D4 { get; set; }
        public List<SanPhamModel> D5 { get; set; }
        public List<SanPhamModel> D6 { get; set; }

        public DanhMucModel()
        {
            ListAdidas = new List<SanPhamModel>();
            ListAdidas.Add(new SanPhamModel("/Content/Image/Adidas_1"));
            ListAdidas.Add(new SanPhamModel("/Content/Image/Adidas_2.jpg"));
            ListAdidas.Add(new SanPhamModel("/Content/Image/Adidas_3.jpg"));

            ListNike = new List<SanPhamModel>();
            ListNike.Add(new SanPhamModel("/Content/Image/Nike_1.jpg"));
            ListNike.Add(new SanPhamModel("/Content/Image/Nike_2.jpg"));
            ListNike.Add(new SanPhamModel("/Content/Image/Nike_3.jpg"));

            ListSupreme = new List<SanPhamModel>();
            ListSupreme.Add(new SanPhamModel("/Content/Image/Supreme_1.jpg"));
            ListSupreme.Add(new SanPhamModel("/Content/Image/Supreme_2.jpg"));
            ListSupreme.Add(new SanPhamModel("/Content/Image/Supreme_3.jpg"));

            ListJordan = new List<SanPhamModel>();
            ListJordan.Add(new SanPhamModel("/Content/Image/Jordan_1.jpg"));
            ListJordan.Add(new SanPhamModel("/Content/Image/Jordan_2.jpg"));
            ListJordan.Add(new SanPhamModel("/Content/Image/Jordan_3.jpg"));

            ListPuma = new List<SanPhamModel>();
            ListPuma.Add(new SanPhamModel("/Content/Image/Puma_1.jpg"));
            ListPuma.Add(new SanPhamModel("/Content/Image/Puma_2.jpg"));
            ListPuma.Add(new SanPhamModel("/Content/Image/Puma_3.jpg"));

            ListBalenciaga = new List<SanPhamModel>();
            ListBalenciaga.Add(new SanPhamModel("/Content/Image/Balenciaga_1.jpg"));
            ListBalenciaga.Add(new SanPhamModel("/Content/Image/Balenciaga_2.jpg"));
            ListBalenciaga.Add(new SanPhamModel("/Content/Image/Balenciaga_3.jpg"));

            D1 = new List<SanPhamModel>();
            D1.Add(new SanPhamModel("/Content/Image/Adidas_1.jpg"));
            D1.Add(new SanPhamModel("/Content/Image/Adidas_2.jpg"));
            D1.Add(new SanPhamModel("/Content/Image/Adidas_3.jpg"));

            D2 = new List<SanPhamModel>();
            D2.Add(new SanPhamModel("/Content/Image/Nike_1.jpg"));
            D2.Add(new SanPhamModel("/Content/Image/Nike_2.jpg"));
            D2.Add(new SanPhamModel("/Content/Image/Nike_3.jpg"));

            D3 = new List<SanPhamModel>();
            D3.Add(new SanPhamModel("/Content/Image/Supreme_1.jpg"));
            D3.Add(new SanPhamModel("/Content/Image/Supreme_2.jpg"));
            D3.Add(new SanPhamModel("/Content/Image/Supreme_3.jpg"));

            D4 = new List<SanPhamModel>();
            D4.Add(new SanPhamModel("/Content/Image/Jordan_1.jpg"));
            D4.Add(new SanPhamModel("/Content/Image/Jordan_2.jpg"));
            D4.Add(new SanPhamModel("/Content/Image/Jordan_3.jpg"));

            D5 = new List<SanPhamModel>();
            D5.Add(new SanPhamModel("/Content/Image/Puma_1.jpg"));
            D5.Add(new SanPhamModel("/Content/Image/Puma_2.jpg"));
            D5.Add(new SanPhamModel("/Content/Image/Puma_3.jpg"));

            D6 = new List<SanPhamModel>();
            D6.Add(new SanPhamModel("/Content/Image/Balenciaga_1.jpg"));
            D6.Add(new SanPhamModel("/Content/Image/Balenciaga_2.jpg"));
            D6.Add(new SanPhamModel("/Content/Image/Balenciaga_3.jpg"));
        }
    }
}