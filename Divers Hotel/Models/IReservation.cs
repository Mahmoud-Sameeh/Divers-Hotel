using Domain.Models;
using Domain.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Divers_Hotel.Models
{
  public  interface IReservation<T>
    {
        void Add(T t);
        void Remove(T t);
        void Update(T t);
        List<MealPlan> GetAllMealTypeList();
        List<RoomType> GetRoomTypeNumList();
    }
}
