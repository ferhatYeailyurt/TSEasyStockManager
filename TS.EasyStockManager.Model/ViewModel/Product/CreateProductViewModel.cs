﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TS.EasyStockManager.Model.ViewModel.Base;

namespace TS.EasyStockManager.Model.ViewModel.Product
{
    public class CreateProductViewModel : BaseViewModel
    {

        [Required]
        [MaxLength(100)]
        [Display(Name = "Malzeme Adı")]
        public string ProductName { get; set; }

        [MaxLength(50)]
        [Display(Name = "Barcode")]
        public string Barcode { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        [Display(Name = "Resim")]
        public string Image { get; set; }

        [Display(Name = "Resim")]
        [RegularExpression(@"^.*\.(jpg|JPG|png|PNG|jpeg|JPEG)$")]
        public IFormFile ImageFile { get; set; }

        [Display(Name = "Price")]
        public decimal? Price { get; set; }

        [Display(Name = "Kategori")]
        public int? CategoryId { get; set; }

        [Required]
        [Display(Name = "Ölçü Birimi")]
        public int UnitOfMeasureId { get; set; }

        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> UnitOfMeasureList { get; set; }
    }
}
