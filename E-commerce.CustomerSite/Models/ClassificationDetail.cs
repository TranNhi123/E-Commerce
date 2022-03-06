using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace E_commerce.CustomerSite.Models
{
    public class ClassificationDetail
    {
        [Key, Column(Order=0)]
        public int ID_thc {get;set;}

        [Key, Column(Order=1)]
        public int ID_phan_loai{get; set;}

        public List<Classify>? Classifies {get;set;}
        public List<Medicine>? Medicines {get; set;}
    }
}