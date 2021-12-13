using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            DenDo denDo = new DenDo();
            DenVang denVang = new DenVang();
            DenXanh denXanh = new DenXanh();

            DenHoc denHocMauVang = new DenHoc(denVang);
            DenHoc denHocMauXanh = new DenHoc(denXanh);
            DenHoc denHocMauDo = new DenHoc(denDo);
        }
    }
}