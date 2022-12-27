using DAL.EF.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICustAuth
    {
        CustomerToken Authenticate(Customer user);
        bool IsAuthenticated(string token);
        void Logout(string token);
        
    }
}
