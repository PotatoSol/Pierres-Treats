using System.Collections.Generic;

namespace SweetSavoryTreats.Models
{
  public class Tag
    {
        public int TagId { get; set; }
        public string Title { get; set; }
        public List<ItemTag> JoinEntities { get;}
    }
}