
using System;
using System.Collections;
using UnityEngine;

public class DestroyBehavior : MonoBehaviour
{
   public float seconds = 1;
   private WaitForSeconds wfs;
   private IEnumerator Start()
   {
      wfs = new WaitForSeconds(seconds);
      yield return wfs;
      Destroy(gameObject);
   }
}
