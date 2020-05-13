using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJudgeSystem
{
    public static  class Data
    {

        private static List<CreatableAndModifiableEntity> listOfData = new List<CreatableAndModifiableEntity>();
        public static void Create(CreatableAndModifiableEntity entity)
        {
            listOfData.Add(entity);
        }

        public static void Delete(DeletableEntity entity)
        {
            listOfData.Remove(entity);
        }
    }
}
