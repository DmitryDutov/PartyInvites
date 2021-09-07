using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestResponce> responces = new List<GuestResponce>();
        public static IEnumerable<GuestResponce> Responces
        {
            get
            {
                return responces;
            }
        }

        public static void AddResponce(GuestResponce responce)
        {
            responces.Add(responce);
        }
    }
}
