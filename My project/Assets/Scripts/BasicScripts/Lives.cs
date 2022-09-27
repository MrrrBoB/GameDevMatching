using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : ScriptableObject
{
   private int currentLives;

   public void changeLives(int val)
   {
      currentLives += val;
      if (currentLives <= 0)
      {
         Debug.Log("Out of lives");
         //call gameaction for game over
      }
   }

   public int GetLives()
   {
      return currentLives;
   }

   public void DisplayLifeCount(Text txt)
   {
      txt.text = currentLives.ToString();
   }
}
