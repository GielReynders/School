using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeCoffeeStore.StockManagement.Tests.Mocks
{
    public class MockCoffeeDataService: ICoffeeDataService
    {
        private MockRepository repository = new MockRepository();

        public void DeleteCoffee(Model.Coffee coffee)
        {
            
        }

        public List<Coffee> GetAllCoffees()
        {
            return repository.GetCoffees();
        }

        public Coffee GetCoffeeDetail(int coffeeId)
        {
            Coffee coffee = repository.GetCoffeeById(coffeeId);
            return coffee;
        }

        public void UpdateCoffee(Model.Coffee coffee)
        {
           
        }
    }
}
