using RestaurantDataAccessLayer.Abstract;
using RestaurantDataAccessLayer.Concrete;
using RestaurantDataAccessLayer.Repositories;
using RestaurantEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDataAccessLayer.EntityFramework
{
    public class EfFoodDal:GenericRepository<Food>,IFoodDal
    {
        public EfFoodDal(Context context) : base(context)
        {

        }

        public int FoodCount()
        {
            var context = new Context();
            var value = context.Foods.Count();
            return value;
        }
    }
}
