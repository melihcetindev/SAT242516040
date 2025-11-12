namespace DbContexts;

using Microsoft.EntityFrameworkCore;
using SAT242516040.Models;

public class MyDbModel_DbContext(DbContextOptions<MyDbModel_DbContext> options) : DbContext(options)
{
    public DbSet<Yazar> Yazarlar { get; set; }
    public DbSet<Yayin> Yayinlar { get; set; }


}