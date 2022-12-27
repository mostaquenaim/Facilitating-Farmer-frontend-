using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IAdminAuth
    {
        AdminToken Authenticate(Admin user);
        bool IsAuthenticated(string token);
        void Logout(string token);
    }
}
