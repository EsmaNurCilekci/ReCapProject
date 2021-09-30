using DataAccess.Concrete.InMemory;

namespace Console
{
    internal class CarManager
    {
        private InMemoryCarDal ınMemoryCarDal;

        public CarManager(InMemoryCarDal ınMemoryCarDal)
        {
            this.ınMemoryCarDal = ınMemoryCarDal;
        }
    }
}