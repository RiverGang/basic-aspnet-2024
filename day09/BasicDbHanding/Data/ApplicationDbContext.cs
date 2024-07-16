using BasicDbHanding.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicDbHanding.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            // 내용 없음
        }

        // CodeFirst로 만들어둔 엔티티클래스를 작성, 테이블 생성할 엔티티가 늘때 마다 여기에 추가
        public DbSet<Category> Categories { get; set; } // DB의 테이블로 만들거야 라는 뜻
    }
}
