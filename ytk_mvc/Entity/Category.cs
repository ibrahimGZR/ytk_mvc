﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ytk_mvc.Entity
{
    public class Category
    {
        public int Id { get; set; }

        //Data annotations
        [DisplayName("Kategori Adı")]
        [StringLength(maximumLength: 20, ErrorMessage = "en fazla 20 karakter girebilirsiniz.")]
        public string Name { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }
        public bool IsVisible { get; set; }

        public List<Product> Products { get; set; }

        public List<Project> Projects { get; set; }
    }
}