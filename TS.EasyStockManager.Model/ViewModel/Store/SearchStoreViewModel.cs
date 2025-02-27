﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TS.EasyStockManager.Model.ViewModel.Base;

namespace TS.EasyStockManager.Model.ViewModel.Store
{
    public class SearchStoreViewModel : BaseViewModel
    {

        [Display(Name = "Mağaza Adı")]
        public string StoreName { get; set; }


        [Display(Name = "Mağaza Kodu")]
        public string StoreCode { get; set; }
    }
}
