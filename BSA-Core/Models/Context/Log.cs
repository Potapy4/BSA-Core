using System;

namespace BSACore.Models.Context
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime LogTime { get; set; }
        public string CalledAction { get; set; }
    }
}
