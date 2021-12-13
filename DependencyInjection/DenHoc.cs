namespace DependencyInjection
{
    public class DenHoc:IDenHoc
    {
        private IDen _bongDen;
        
        public DenHoc(IDen bongDen)
        {
            _bongDen = bongDen;
        }
        
        public void PhatSang()
        {
            throw new System.NotImplementedException();
        }
    }
}