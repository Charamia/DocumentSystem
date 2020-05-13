using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJudgeSystem
{
   public  class DeletableEntity : CreatableAndModifiableEntity, IDeletableEntity
    {
        public DateTime DeletedOn { get; set; }
    }
}
