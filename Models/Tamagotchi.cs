using System.Collections.Generic;
using System;

namespace TamagotchiPet.Models
{
  public class Tamagotchi
  {
    private string _Name;
    private int _hungry;
    private int _sleep;
    private int _happiness;
    private int _id;
    private static List<Tamagotchi> _instances = new List<Tamagotchi> {};

    public Tamagotchi (string name)
    {
      _Name = name;
      _hungry = 70;
      _sleep = 70;
      _happiness = 70;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public void GiveFood()
    {
      _hungry = _hungry + 10;
    }
    public void GiveRest()
    {
      _sleep = _sleep + 10;
    }
    public void GiveHappiness()
    {
    _happiness = _happiness  + 10;
    }
    public void Timepass(){
      _hungry = _hungry - 10;
      _sleep = _sleep - 10;
      _happiness = _happiness - 10;
    }
    public string GetName()
    {
      return _Name;
    }
    public int GetHungry()
    {
      return _hungry;
    }
    public int GetSleep()
    {
      return _sleep;
    }
    public int GetHappy()
    {
      return _happiness;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Tamagotchi> GetAll()
    {
        return _instances;
    }
    public static Tamagotchi Find(int searchId)
    {
      return _instances[searchId-1];
    }


  }
}
