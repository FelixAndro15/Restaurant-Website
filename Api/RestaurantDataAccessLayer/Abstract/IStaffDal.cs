using RestaurantEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDataAccessLayer.Abstract
{
    public interface IStaffDal:IGenericDal<Staff>
    {
        int GetStaffCount();
        List<Staff> Last4Staff();
    }
}
