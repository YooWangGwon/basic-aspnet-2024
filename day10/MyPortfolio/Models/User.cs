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

        public string? PasswordCheck { get; set; }

        [MaxLength(15)]
        public string? PhoneNum { get; set; }

        [MaxLength(150)]
        public string? Address { get; set; }

        public DateTime? RegDate { get; set; }

        // RelationShip User부모 -> Board자식
        public virtual ICollection<Board> Boards { get; set; }
    }
}
