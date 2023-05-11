using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Note.Model
{
    public class Memo
    {
        /// <summary>
        /// 게시물 번호
        /// </summary>
        [Key]
        public int MemoNo { get; set; }

        /// <summary>
        /// 게시물 제목
        /// </summary>
        [Required(ErrorMessage = "제목을 입력하세요.")]
        public string MemoTitle { get; set; }

        /// <summary>
        /// 게시물 내용
        /// </summary>
        [Required(ErrorMessage = "내용을 입력하세요.")]
        public string MemoContents { get; set; }

        /// <summary>
        /// 작성자 번호 (User.사용자 번호)
        /// </summary>
        [Required]
        public int UserNo { get; set; }

        [ForeignKey("UserNo")]
        public virtual User User { get; set; }
    }
}
