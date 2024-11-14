﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.Entities.Enums
{
    public enum ExpenseType
    {
        [Display(Name = "Yol Masrafı")]
        TravelExpense,      // Yol Masrafı

        [Display(Name = "Konaklama")]
        Accommodation,      // Konaklama

        [Display(Name = "Yemek Masrafı")]
        MealExpense,        // Yemek Masrafı

        [Display(Name = "Eğitim Gideri")]
        TrainingExpense,    // Eğitim Gideri

        [Display(Name = "Ofis Malzemeleri")]
        OfficeSupplies,     // Ofis Malzemeleri

        [Display(Name = "Telefon Faturası")]
        PhoneBill,          // Telefon Faturası

        [Display(Name = "İnternet Gideri")]
        InternetBill,       // İnternet Gideri

        [Display(Name = "Temsil ve Ağırlama")]
        Entertainment,      // Temsil ve Ağırlama

        [Display(Name = "Kırtasiye Gideri")]
        Stationery,         // Kırtasiye Gideri

        [Display(Name = "Yakıt Masrafı")]
        FuelExpense,        // Yakıt Masrafı

        [Display(Name = "Diğer")]
        Other               // Diğer
    }
}
