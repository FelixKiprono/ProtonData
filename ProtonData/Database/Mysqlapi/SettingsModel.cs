﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtonData.Database.Mysqlapi
{
    public class SettingsModel
    {
        ///
        /// 
        ///server credentials model
        public string server { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string port { get; set; }
        public string database { get; set; }

    }
}
