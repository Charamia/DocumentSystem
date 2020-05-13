using System;


namespace OnlineJudgeSystem
{
    public interface IDeletableEntity
    {
         DateTime DeletedOn { get; set; }
    }
}
