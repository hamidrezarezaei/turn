﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Nobatgir.Model
{
    public class Site : BaseClass
    {
        [Display(Name = "دامنه")]
        public string Domain { get; set; }

        [Display(Name = "نوع سایت")]
        public int SiteKindID { get; set; }

        [Display(Name = "نوع سایت")]
        public SiteKind SiteKind { get; set; }

        public IEnumerable<SiteSetting> SiteSettings { get; set; }

        [NotMapped]
        public string SiteKindTitle => this.SiteKind?.Title;

        [NotMapped]
        public SiteKinds SiteKindEnum
        {
            get => (SiteKinds)this.SiteKindID;

            set => this.SiteKindID = (int)value;
        }
    }
}
