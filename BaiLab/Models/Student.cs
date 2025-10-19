﻿using System.ComponentModel.DataAnnotations;

namespace BaiLab.Models
{
    public class Student
    {
        public int Id { get; set; } // Mã sinh viên

        [Required(ErrorMessage ="The Name is invalid")]
        public string Name { get; set; } // Họ tên

        [Required(ErrorMessage = "Email bắt buộc phải được nhập đúng cú pháp")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; } // Email

        [StringLength(100, MinimumLength = 8)]
        [Required(ErrorMessage = "Fail here")]
        public string Password { get; set; } // Mật khẩu

        [Required(ErrorMessage = "Fail here")]
        public Branch Branch { get; set; } // Ngành học

        [Required(ErrorMessage = "Fail here")]
        public Gender Gender { get; set; } // Giới tính

        public bool IsRegular { get; set; } // Hệ: true - chính quy, false - phi chính quy

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage ="Fail here")]
        public string Address { get; set; } // Địa chỉ

        [Range(typeof(DateTime), "1/1/1963", "1/1/2026")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Fail here")]
        public DateTime DateOfBorth { get; set; } // Ngày sinh
    }
}
