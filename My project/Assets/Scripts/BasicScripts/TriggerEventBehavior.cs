using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
   public UnityEvent triggerEvent;
   private void OnTriggerEnter(Collider other)
   {
      triggerEvent.Invoke();
   }
}
