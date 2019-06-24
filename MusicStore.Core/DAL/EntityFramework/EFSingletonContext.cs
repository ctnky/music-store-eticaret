using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace MusicStore.Core.DAL.EntityFramework
{
    public class EFSingletonContext<TContext>
        where TContext : DbContext, new()
    {
        private static TContext _instance;
        public static TContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TContext();
                }
                return _instance;
            }
        }
    }
}
