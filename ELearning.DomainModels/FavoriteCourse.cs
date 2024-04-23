using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels;

namespace ELearning.DomainModels
{
    public class FavoriteCourse
    {
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedAt { get; set; }


        // relationships
        public User User { get; set; }
        public Course Course { get; set; }
    }
}
