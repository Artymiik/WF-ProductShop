using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatermelonShop.Models;

namespace WatermelonShop.Interfaces
{
    public interface IDataUser
    {
        void AddDataUser(DataUserModel data);

        void CreateCheck();
    }
}
