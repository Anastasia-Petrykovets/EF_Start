﻿using System;
using System.Collections.Generic;

namespace EF_Start_From_DB.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
    }
}
