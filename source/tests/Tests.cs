namespace CarRent.Tests
{
    using System;
    using CarRent.Car.Domain;

    public class Tests
    {
        [Fact]
        public void CarDomain()
        {
            var car1 = new Car();
            var car2 = new Car();

            car1.Equals(car2);
            var result = (car1 == car2);

            Assert.True(result);
        }

        [Fact]
        public void Foo()
        {
            var g = new MyGraph();
            g.MyEvent += G_MyEvent;
            g.MyEvent += G_MyEvent;
            g.Foo();
        }

        private void G_MyEvent()
        {
            Console.WriteLine("Hallo");
        }
    }

    public class MyGraph
    {
        public event Action MyEvent;

        public void Foo()
        {
            MyEvent();

            var list = MyEvent.GetInvocationList();
            foreach (Delegate? item in list)
            {
                item.DynamicInvoke();
            }
        }
    }
}
