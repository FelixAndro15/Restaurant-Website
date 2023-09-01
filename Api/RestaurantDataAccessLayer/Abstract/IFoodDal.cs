using RestaurantEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDataAccessLayer.Abstract
{
    public interface IFoodDal:IGenericDal<Food>
    {
        int FoodCount();
    }
}
