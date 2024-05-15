namespace ConsoleApp6GestionError.Exeptions
{

  public class TableauTemperature
  {
    //liste des températures enregistrées 
    public List<int> TemperatureEnregistrees { get; private set; }

    //constructeur
    public TableauTemperature()
    {
      // Initialiser la liste des températures
      TemperatureEnregistrees = new List<int>();
    }
    //methode pour ajouter des temperatures 
    public void AjouterTemperature(int temperature)
    {
      TemperatureEnregistrees.Add(temperature);
    }
  }
}