﻿
namespace FromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vedomost
    {
        public decimal price
        {
            get => count * cena;
        }
    }
}
