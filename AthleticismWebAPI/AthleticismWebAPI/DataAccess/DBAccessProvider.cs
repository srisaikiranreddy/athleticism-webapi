using System;
namespace AthleticismWebAPI.DataAccess
{
    public class DBAccessProvider
    {
        private readonly PGDBContext _context;
        public DBAccessProvider(PGDBContext context)
        {
            _context = context;
        }

        //public string CheckDBActive()
        //{

        //}
    }
}
