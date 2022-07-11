using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_exam
{
    internal class ProductManage
    {
        private List<Product> ListProduct = null;

        public ProductManage()
        {
            ListProduct = new List<Product>();
        }

        //hàm trả về số lượng sản phẩm hiện tại trong list
        public int ProductNumber()
        {
            int Count = 0;
            if (ListProduct != null)
            {
                Count = ListProduct.Count;
            }
            return Count;
        }

        //hàm thêm sản phẩm
        public void AddProduct()
        {
            // Khởi tạo một product mới
            Product p = new Product();

            Console.Write("Input ID product: ");
            p.ProductID = Console.ReadLine();

            Console.Write("Input name product: ");
            p.Name = Console.ReadLine();

            Console.Write("Input price product: ");
            p.Price = Console.ReadLine();

            ListProduct.Add(p);
        }

        //hàm hiển thị sản phẩm
        public void ShowProduct(List<Product> list)
        {
            //hiển thị cột
            Console.WriteLine("|  {0, -10}  |  {1, -20}  |  {2, -10}  |",
                  "Product ID", "Name", "Price");
            Console.WriteLine("---------------------------------------------------");
            //hiển thị danh sách sản phẩm
            if (list != null && list.Count > 0)
            {
                foreach (Product p in list)
                {
                    Console.WriteLine("|  {0, -10}  |  {1, -20}  |  {2, -10}  |",
                                      p.ProductID, p.Name, p.Price);
                }
            }
            Console.WriteLine();
        }
        //Hàm trả về danh sách sản phẩm hiện tại
        public List<Product> getListProduct()
        {
            return ListProduct;
        }


        //hàm xoá sản phẩm
        public bool DeleteById(string ID)
        {
            bool IsDeleted = false;

            // Tìm kiếm sinh viên trong danh sách ListSinhVien
            Product sv = FindByID(ID);
            // Nếu sinh viên tồn tại thì cập nhập thông tin sinh viên
            if (sv != null)
            {
                IsDeleted = ListProduct.Remove(sv);
            }
            else
            {
                Console.WriteLine("Product ID with = {0} does not exist.", ID);
            }
            return IsDeleted;

        }
        //hàm tìm kiếm ID để delete
        public Product FindByID(string ID)
        {
            Product searchResult = null;
            if (ListProduct != null && ListProduct.Count > 0)
            {
                foreach (Product p in ListProduct)
                {
                    if (p.ProductID == ID)
                    {
                        searchResult = p;
                    }
                }
            }
            return searchResult;
        }

    }
}
