using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Apifirst.Models
{
   // [Table("Student")]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RollNo { get; set; }
        public string Class { get; set; }
    }
    public class StudentdbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}