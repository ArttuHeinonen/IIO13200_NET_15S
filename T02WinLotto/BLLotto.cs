using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*
* Copyleft MJ
* This file is part of the BLLotto project.
* Created: 7.9.2015
* Authors: Nicke Nackenström
*/

namespace JAMK.IT.WinLotto
{
  public class Lotto
  {
    #region Variables
    private string Type;
    public string LotteryType
    {
      get
      {
        return Type != null ? Type : "Type not set!";
      }
      set
      {
        Type = value;
      }
    }
    private int LargestNumber;
    private int NumberAmount;
    private Random rnd = new Random();
    #endregion
    #region Constructors
    public Lotto()
    {
    }
    #endregion
    #region Methods
    public string GetWeekUnfinished()
    {
      throw new NotImplementedException();
    }
    public string GetWeekFixed()
    {
      return @"41/2015";
    }
  public ArrayList ArvoRiviAL()
    {
      ArrayList hits = new ArrayList();
      if (this.Type == "Suomi")
      {
        LargestNumber = 39;
        NumberAmount = 7;
      }
      else if (this.Type == "Viking")
      {
        LargestNumber = 48;
        NumberAmount = 6;
      }

      else if (this.Type == "EuroJackpot")
      {
        LargestNumber = 50;
        NumberAmount = 5;
      }
      else
      {
        Console.WriteLine("Valittu lottoType ei validi, käytetään Suomilottoa");
        LargestNumber = 39;
        NumberAmount = 7;
      }

      do
      {
        int random = this.rnd.Next(1, LargestNumber + 1);
        if (!hits.Contains(random))
        {
          hits.Add(random);
        }
      }
      while (hits.Count < NumberAmount);
      //sorttaus 
      hits.Sort();
      //EuroJackPot tähtinumerot
      if (this.Type == "EuroJackpot")
      {
        hits.Add("Bonus: ");
        ArrayList star = new ArrayList();
        do
        {
          int random = this.rnd.Next(1, 11);

          if (!star.Contains(random))
          {
            star.Add(random);
          }
        }
        while (star.Count < 2);
        hits.AddRange(star);
      }
      //ja palautus
      return hits;
    }
    public List<int> ArvoRivi()
    {
      List<int> hits = new List<int>();
      if (this.Type == "Suomi")
      {
        LargestNumber = 39;
        NumberAmount = 7;
      }
      else if (this.Type == "Viking")
      {
        LargestNumber = 48;
        NumberAmount = 6;
      }

      else if (this.Type == "EuroJackpot")
      {
        LargestNumber = 50;
        NumberAmount = 5;
      }
      else
      {
        Console.WriteLine("Valittu lottoType ei validi, käytetään Suomilottoa");
        LargestNumber = 39;
        NumberAmount = 7;
      }

      do
      {
        int random = this.rnd.Next(1, LargestNumber + 1);
        if (!hits.Contains(random))
        {
          hits.Add(random);
        }
      }
      while (hits.Count < NumberAmount);
      //sorttaus 
      hits.Sort();
      //EuroJackPot tähtinumerot
      if (this.Type == "EuroJackpot")
      {
        List<int> star = new List<int>();
        do
        {
          int random = this.rnd.Next(1, 11);

          if (!star.Contains(random))
          {
            star.Add(random);
          }
        }
        while (star.Count < 2);
        hits.AddRange(star);
      }
      //ja palautus
      return hits;
    }
    #endregion
  }
}
