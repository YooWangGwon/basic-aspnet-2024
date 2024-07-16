using BasicDBHandling.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicDBHandling.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            // 내용없음
        }

        // Code First로 만들어둔 엔티티 클래스를 작성, 테이블 생성할 엔티티가 생겨날 때 마다 여기에 추가해주어야 함
        public DbSet<Category> Categories { get; set; }
    }
}
