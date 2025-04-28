using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "請輸入日期")]
        [Display(Name = "日期")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "請輸入類別")]
        [Display(Name = "類別")]
        [StringLength(50)]
        public string Category { get; set; }

        [Required(ErrorMessage = "請輸入金額")]
        [Display(Name = "金額")]
        [Range(0.01, double.MaxValue, ErrorMessage = "金額必須大於0")]
        public decimal Amount { get; set; }

        [Display(Name = "備註")]
        [StringLength(200)]
        public string Note { get; set; }
    }
}