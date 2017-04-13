using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{

    public class Meal
    {
        public string name;
        public decimal price;
        public decimal cost;

        public Meal(string name, decimal price, decimal cost)
        {
            this.name = name;
            this.price = price;
            this.cost = cost;
        }

        public static void cookMeal(Meal meal)
        {
            Console.WriteLine("The meal {0} has been cooked.", meal.name);

        }
    }

    public class Order
    {
        public void takeOrder(Meal meal)
        {
            Console.WriteLine("The meal {0} has been ordered.", meal.name);
        }
    }

    public class Account
    {
        private static decimal _balance = 0;

        public static void accountTransaction(Meal meal)
        {
            _balance = _balance + meal.price;
            _balance = _balance - meal.cost;
        }

        public static decimal reportBalance()
        {
            return _balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 0;

            //add some meals data
            Meal steak = new Meal("steak", 20.00M, 5.00M);
            Meal fajitas = new Meal("fajitas", 12.00M, 2.00M);
            Meal pumpkinRisotto = new Meal("pumpkinRisotto", 10.00M, 1.00M);

            Order order1 = new Order();
            order1.takeOrder(steak);
            Meal.cookMeal(steak);
            Account.accountTransaction(steak);

            Order order2 = new Order();
            order2.takeOrder(pumpkinRisotto);
            Meal.cookMeal(pumpkinRisotto);
            Account.accountTransaction(pumpkinRisotto);

            balance = Account.reportBalance();

            Console.WriteLine("Tonight in the restaurant, we made £{0:N2}.", balance);

        }
    }
}


