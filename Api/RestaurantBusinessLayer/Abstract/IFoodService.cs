using RestaurantEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBusinessLayer.Abstract
{
    public interface IFoodService:IGenericService<Food>
    {
        int TFoodCount();
    }
}
