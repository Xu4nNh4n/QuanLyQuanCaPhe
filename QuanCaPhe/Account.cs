using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanCaPhe
{
    public class Account
    {
        public  string Username { get; set; }
        public  string Password { get; set; }
        public  int MaNV { get; set; }
        public  int MaQ { get; set; }
        public static Account Current { get; set; }

        public Account(string user, string password, int maNV, int maQ)
        {
            Username = user;
            Password = password;
            MaNV = maNV;
            MaQ = maQ;
        }

    }
}
