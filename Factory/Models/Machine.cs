namespace Factory.Models
{
  public class Machine
  {

    public Machine()
    {
      this.Engineers = new HashSet<EngineerMachine>();
    }

  }
}