using RestaurantBusinessLayer.Abstract;
using RestaurantDataAccessLayer.Abstract;
using RestaurantEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBusinessLayer.Concrete
{
    public class FoodManager : IFoodService
    {
        private readonly IFoodDal _foodDal;

        public FoodManager(IFoodDal foodDal)
        {
            _foodDal = foodDal;
        }

        public void TDelete(Food t)
        {
           _foodDal.Delete(t);
        }

        public int TFoodCount()
        {
            return _foodDal.FoodCount();
        }

        public Food TGetById(int id)
        {
            return _foodDal.GetById(id);
        }

        public List<Food> TGetList()
        {
            return _foodDal.GetList();
        }

        public void TInsert(Food t)
        {
            _foodDal.Insert(t);
        }

        public void TUpdate(Food t)
        {
            _foodDal.Update(t);
        }
    }
}
