﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace Customer.src.DataSource
{
    public interface DBConnInterface
    {
        public SQLiteConnection createConnection();
    }
}
