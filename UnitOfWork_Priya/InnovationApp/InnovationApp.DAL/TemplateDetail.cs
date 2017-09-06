namespace InnovationApp.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TemplateDetail
    {
        public int Id { get; set; }

        public int TemplateId { get; set; }

        public int? FeatureId { get; set; }

        [StringLength(50)]
        public string FeatureValues { get; set; }

        public virtual MasterFeature MasterFeature { get; set; }

        public virtual TemplateMaster TemplateMaster { get; set; }
    }
}
