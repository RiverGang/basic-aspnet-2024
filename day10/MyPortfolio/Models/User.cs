﻿using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } // PK

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

        // RelationShip User부모->Board자식
        // 한사람의 사용자의 0또는 여러개의 게시글을 적을 수 있다.
        // ?(Nullable)를 안쓰면 사용자는 무조건 글을 가져야 한다 
        public virtual ICollection<Board>? Boards { get; set; }
    }
}