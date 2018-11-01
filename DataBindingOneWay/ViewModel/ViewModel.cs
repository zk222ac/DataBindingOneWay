
using DataBindingOneWay.Model;

namespace DataBindingOneWay.ViewModel
{
    public class ViewModel
    {
        // Source property 
        public Car Bmw { get; set; }
        public Car Audi { get; set; }

        public ViewModel()
        {
            Bmw = new Car(12,"BMW");
            Audi = new Car(23, "Audi");
        }

    }
}
