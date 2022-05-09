using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDB.Models
{
    public class Game
    {
        public int Id { get; set; }
        public String GName { get; set; }
        public double Rating { get; set; }
        public String GReview { get; set; }
        public String image { get; set; }
        public Game()
        {

        }
    }
}
