﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TS.EasyStockManager.Model.ViewModel.Base;

namespace TS.EasyStockManager.Model.ViewModel.Store
{
  public  class EditStoreViewModel:BaseViewModel
    {
        [Required]
        [MaxLength(30)]
        [Display(Name = "Mağaza Adı")]
        public string StoreName { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Mağaza Kodu")]
        public string StoreCode { get; set; }
    }
}
