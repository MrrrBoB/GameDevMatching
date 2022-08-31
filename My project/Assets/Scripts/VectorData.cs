using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   private Vector3 savedLocation;
   public Vector3 [] presetLocations;

   public void SaveLocationAt(Vector3 lc)
   {
      savedLocation = lc;
   }

   public Vector3 GetSavedLocation()
   {
      return savedLocation;
   }

   public Vector3 GetSavedLocation(int i)
   {
      return presetLocations[i];
   }

   public void ChangePresetLocation(int i, Vector3 lc)
   {
      presetLocations[i] = lc;
   }
   
}
