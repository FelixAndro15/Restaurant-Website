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
    public class EfSendMessageDal:GenericRepository<SendMessage>,ISendMessageDal
    {
        public EfSendMessageDal(Context context):base (context)
        {
        }
    }
}
