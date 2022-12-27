using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ISpecAuth
    {
        SpecialistToken Authenticate(Specialist user);
        bool IsAuthenticated(string token);
        void Logout(string token);
        bool Verfied(Specialist user);
    }
}
