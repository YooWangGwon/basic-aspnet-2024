using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models
{
    public class User
    {
        [Key]
        public int Idx { get; set; } // PK, 관계에서 테이블 생성시 Board 테이블에 있는 속성명과 충돌나지 않기 위해 이름 변경

        [Required]
        [MaxLength(20)]
        public string UserEmail { get; set; }
      
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; } = string.Empty;
        
        [Required]
        public string Password { get; set; }

        //[Required(ErrorMessage = "비밀번호가 일치하지 않습니다.")]
        // Nullable인데 Required는 말이 안됨. 로그인 할 때 문제를 발생
        public string? PasswordCheck { get; set; }

        [MaxLength(15)]
        public string? PhoneNum { get; set; }

        [MaxLength(150)]
        public string? Address { get; set; }

        public DateTime? RegDate { get; set; }

        // RelationShip User부모 -> Board자식
        public virtual ICollection<Board>? Boards { get; set; }
    }
}
