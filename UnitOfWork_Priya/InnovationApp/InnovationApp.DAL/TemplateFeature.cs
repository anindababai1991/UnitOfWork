namespace InnovationApp.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TemplateFeature
    {
        public int TemplateFeatureId { get; set; }

        public int TemplateId { get; set; }

        public int? FeatureOptionsId { get; set; }

        public virtual FeatureOption FeatureOption { get; set; }

        public virtual TemplateMaster TemplateMaster { get; set; }
    }
}
