using RentCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    public class ServiceCar
    {
        EntityForCar entity = new EntityForCar;
        static public List<Mashina> Pagging(int a, int b)
        {
            List<Mashina> list = new List<Mashina>();
            list = entity.GetAll();
            var res = list.Skip((b - 1) * a).Take(a).ToList();
            return res;
        }


        static public List<Mashina> Search(string model)
        {
            List<Mashina> list = new List<Mashina>();
            list = entity.GetAll();
            var res = list.OrderBy(x => x.Model = model).ToList();
            return res;
        }
    }
