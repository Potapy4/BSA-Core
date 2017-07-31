using System;
using System.Linq;

namespace BSACore.Models.Context
{
    public static class LogContextInitializer
    {
        public static void Initialize(LogContext context)
        {
            context.Database.EnsureCreated();

            if (context.Logs.Any())
            {
                return;
            }

            context.Logs.AddRange(new Log[]
            {
                new Log(){ LogTime = DateTime.Now, CalledAction = "Initializer" },
                new Log(){ LogTime = DateTime.Now.AddHours(-1), CalledAction = "Initializer" },
                new Log(){ LogTime = DateTime.Now.AddMinutes(-5), CalledAction = "Initializer" }
            });

            context.SaveChanges();
        }
    }
}
