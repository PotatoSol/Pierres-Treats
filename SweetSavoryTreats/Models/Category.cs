
using System.Collections.Generic;

namespace SweetSavoryTreats.Models
{
  public class Category
  {
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public List<Item> Items { get; set; }
  }
}