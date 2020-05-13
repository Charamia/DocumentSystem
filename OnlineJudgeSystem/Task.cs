﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJudgeSystem
{
    public class Task : DeletableEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Contest Contest { get; set; }

       


    }
}
