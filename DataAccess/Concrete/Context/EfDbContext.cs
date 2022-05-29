using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class EfDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=ileriveritabaniproje;user=tuyak;password=nBBEeHFvZQzwrlkT");
        }

        public DbSet<Building> buildings { get; set; }
        public DbSet<ClassRoom> classRooms { get; set; }
        public DbSet<ClassRoomType> classRoomTypes { get; set; }
        public DbSet<Day> days { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Faculitie> faculities { get; set; }
        public DbSet<Hour> hours { get; set; }
        public DbSet<Lesson> lessons { get; set; }
        public DbSet<LessonDetail> lessonDetails { get; set; }
        public DbSet<Semester> semesters { get; set; }
        public DbSet<Teacher> teachers { get; set; }
    }
}
