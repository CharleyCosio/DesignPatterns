using DesignPatterns.Repository;
using DesingPatternsAsp.Models.ViewModels;

namespace DesingPatternsAsp.Strategies
{
    public class BeerContext
    {
        private IBeerStrategy _beerStrategy;

        public IBeerStrategy Strategy
        {
            set { _beerStrategy = value; }
        }

        public BeerContext(IBeerStrategy beerStrategy)
        {
            _beerStrategy = beerStrategy;
        }

        public void Add(FormBeerViewModel beerVM,IUnitOfWork unitOfWork)
        {
            _beerStrategy.Add(beerVM,unitOfWork);
        }

    }
}
