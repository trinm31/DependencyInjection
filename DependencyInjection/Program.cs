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
            denHocMauVang.On();
            DenHoc denHocMauXanh = new DenHoc(denXanh);
            denHocMauXanh.On();
            DenHoc denHocMauDo = new DenHoc(denDo);
            denHocMauDo.On();
        }
    }
}