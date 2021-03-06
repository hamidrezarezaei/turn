﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nobatgir.Model
{
    public class SiteSetting : BaseSetting
    {
        public int SiteID { get; set; }

        [Display(Name = "سایت")]
        public Site Site { get; set; }
    }
}
