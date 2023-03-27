
using System.Collections.Generic;

namespace SweetSavoryTreats.Models
{
  public class Category
  {
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public List<Treat> Treats { get; set; }
  }
}