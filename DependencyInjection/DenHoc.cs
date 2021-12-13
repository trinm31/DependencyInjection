namespace DependencyInjection
{
    public class DenHoc
    {
        private IDen _bongDen;
        
        public DenHoc(IDen bongDen)
        {
            _bongDen = bongDen;
        }

        public void On()
        {
            _bongDen.PhatSang();
        }
    }
}