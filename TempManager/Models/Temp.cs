using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace TempManager.Models
{
    public class Temp
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Date is required!!")]
        [Remote("CheckDate", "Validation")]
        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Low temperature is requied!!")]
        [Range(-200, 200, ErrorMessage = "Low temperature must be between -200 and 200.")]
        public double? Low { get; set; }

        [Required(ErrorMessage = "High temperature is requied!!")]
        [Range(-200, 200, ErrorMessage = "High temperature must be between -200 and 200.")]
        public double? High { get; set; }
    }
}