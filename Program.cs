using System;
using ConsoleApp6GestionError.Exeptions;

class Program
{
  static void Main(string[] args)
  {
    //j'instancie une liste de temperature qui prend comme model ma classe TableauTemperature 
    TableauTemperature tableauTemperature = new();
    //j'y ajoute des temperature 
    tableauTemperature.AjouterTemperature(20);
    tableauTemperature.AjouterTemperature(32);
    tableauTemperature.AjouterTemperature(17);
    //j'instancie une autre liste de temperature    
    TableauTemperature temperatureArgs = new TableauTemperature();

    //remplir avec foreach ma liste de temperature avec ce qui vient de args 
    //ici avec try catch je vais gerer les exeption ( si l'utilisateur rentre autre chose qu'un chiffre ) 
    try
    {
      foreach (string uneValeur in args)
      {
        // je valide les uneValeur en tant que int et pas autre chose !
        int temperature = int.Parse(uneValeur);
        //puis j'ajoute les élément dans mon tableau 
        temperatureArgs.AjouterTemperature(temperature);
      };
    }
    //attrape l'exeption  et joue le bloc de code en dessous quand e est une FormatExeption
    catch (Exception e) when (e is FormatException)
    {
      Console.WriteLine("les temperature doivent etre des chiffre  ");
      string exeption = e.ToString();//je transforme l'exeption en string 
      Console.WriteLine(exeption);//je l'affiche dans la console
      Environment.Exit(-1);//je quitte le programme
    }
    //si c'est nimporte quelle exeption cela jouera le bloc de code a l'intérieur du catch ci dessous
    catch (Exception e)
    {
      string exeption = e.ToString();
      Console.WriteLine(exeption);
      Console.WriteLine("Une erreur c'est produite");
    }

    if (tableauTemperature.TemperatureEnregistrees.Count <= 0)
    {
      Console.WriteLine("aucune temperature a analyser");
    }
    else
    {
      int moyenneTemperature = MathSimple.CalculMoyenne(tableauTemperature.TemperatureEnregistrees);
      Console.WriteLine("la température moyenne est de :" + moyenneTemperature);
    }


    if (args.Length <= 0)
    {
      Console.WriteLine("aucun argument reçus");
    }
    else
    {
      int temperatureMoyenne = MathSimple.CalculMoyenne(temperatureArgs.TemperatureEnregistrees);
      Console.WriteLine("La temperature moyenne des valeurs fourni en ligne de commande est : " + temperatureMoyenne);
    }
  }

}
