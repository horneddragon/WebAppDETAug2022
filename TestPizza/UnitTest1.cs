using WebAppDETAug2022.Models;
using WebAppDETAug2022.Services;

namespace TestPizza
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetAllPizza()
        {
            int expected = 2;
            int actual = PizzaService.GetAll().Count(); 

            Assert.Equal(expected, actual); 
        }

        [Fact]
        public void TestAddPizza()
        {
            Pizza p = new Pizza { Name = "XYZ", Size = PizzaSize.Small, IsGlutenFree = true };
            PizzaService.Add(p);
            Pizza verify = PizzaService.Get(3);
            Assert.Equal(3, PizzaService.GetAll().Count);
            Assert.NotNull(verify.Id);
        }
        //[Fact]
        //public void TestDelPizza()
        //{
        //    //Pizza p = new Pizza();
        //    //int pi = p.Id; 
        //    //PizzaService.Delete(pi);
        //    //Assert.Equal(pi, p.Id);

        //    Pizza p = new Pizza();
        //    Pizza verify =  PizzaService.Delete(p);
        //     = PizzaService.Getall().Count;
        //    Assert.Equal(3, PizzaService.GetAll().Count;
        //}
    }
}
