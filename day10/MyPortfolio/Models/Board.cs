using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models
{
    public class Board
    {
        [Key]
        public int Id { get; set; }   // PK

        [Required(ErrorMessage="이름을 입력하세요.")]
        [MaxLength(50)]     //NVARCHAR(50) 사이즈 지정하려면
        [DisplayName("이름")]
        public string Name { get; set; }    // 작성자 명
        [Required(ErrorMessage = "아이디를 입력하세요.")]
        [DisplayName("아이디")]
        [MaxLength(20)]
        public string UserId { get; set; }  // 작성자 아이디
        [Required(ErrorMessage = "제목을 입력하세요.")]
        [DisplayName("제목")]
        [MaxLength(250)]
        public string Title { get; set; }   // 게시글 제목
        [Required(ErrorMessage = "내용을 입력하세요.")]
        [DisplayName("내용")]
        public string Contents { get; set; } // 게시글 내용
        [DisplayName("조회수")]

        public int? Hit {  get; set; }   // 읽은 횟수
        [DisplayName("작성일")]

        public DateTime RegDate { get; set; }  // 게시글 작성날짜

        [DisplayName("수정일")]
        public DateTime? ModDate { get; set; }  //게시글 최종 수정 일자
        // Class 뒤에 ? => Nullavaileable (널 가능)

        // RelationShip 부모User->자식Board
        public virtual User User { get; set; }
    }
}
