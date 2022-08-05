using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }
    [DisplayFormat(DataFormatString = "0:MM/DD/YYYY")]
    public DateTime HireDate { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}