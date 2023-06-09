﻿using System.ComponentModel.DataAnnotations;

namespace Note.Model
{
    public class User
    {
        /// <summary>
        /// 사용자 번호
        /// </summary>
        [Key]       // PK 설정
        public int UserNo { get; set; }

        /// <summary>
        /// 사용자 이름
        /// </summary>
        [Required(ErrorMessage = "사용자 이름을 입력하세요.")]      // Not Null 설정
        public string UserName { get; set; }

        /// <summary>
        /// 사용자 ID
        /// </summary>
        [Required(ErrorMessage = "사용자 ID를 입력하세요.")]
        public string UserId { get; set; }

        /// <summary>
        /// 사용자 Password
        /// </summary>
        [Required(ErrorMessage = "사용자 비밀번호을 입력하세요.")]
        public string UserPassword { get; set; }
    }
}
