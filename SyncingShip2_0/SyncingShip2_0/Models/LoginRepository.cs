﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SyncingShip2_0.Models
{
    public class LoginRepository : ILogin
    {
        public LoginCredential CheckLogin(LoginCredential item)
        {
            try
            {
                if (item.Password.Contains("1"))
                {
                    return item;
                }
            }
            catch
            { }

            throw new Exception("Invalid Username/Password");
        }
    }
}