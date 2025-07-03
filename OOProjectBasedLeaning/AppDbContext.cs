using Microsoft.EntityFrameworkCore;

namespace OOProjectBasedLeaning
{
    public class AppDbContext : DbContext
    {
        // DbSet（= テーブル）を定義
        public DbSet<EmployeeModel> Employees { get; set; }

        // コンストラクタ
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // モデル設定（必要に応じて）
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeModel>().ToTable("Employees");

            modelBuilder.Entity<EmployeeModel>(entity =>
            {
                entity.HasKey(e => e.Id);  // 主キー設定

                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(e => e.WorkTimeSum).HasColumnType("time");
                entity.Property(e => e.WorkTimeIn).HasColumnType("time");
                entity.Property(e => e.WorkTimeOut).HasColumnType("time");
                entity.Property(e => e.WorkTimeRestSum).HasColumnType("time");
                entity.Property(e => e.WorkStatus).HasColumnType("nvarchar(max)");
            });
        }
    }
}
