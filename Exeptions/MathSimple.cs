using System;

namespace ConsoleApp6GestionError.Exeptions
{
  public class MathSimple
  {

    public static int CalculMoyenne(List<int> listeDesEntiers)
    {
      if (listeDesEntiers.Count == 0)
      {
        Console.WriteLine("il n'y a aucune température a analyser ");
        return 0;
      }
      else
      {
        int moyenne = 0;
        foreach (int NombreListe in listeDesEntiers)
        {
          moyenne += NombreListe;
        }
        moyenne /= listeDesEntiers.Count;
        return moyenne;
      }
    }
  }
}