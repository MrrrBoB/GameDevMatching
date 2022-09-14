using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
  public GameAction gameActionObj;
  public UnityEvent raiseEvent;

  private void Start()
  {
    gameActionObj.raise += Raise;
  }

  private void Raise()
  {
      raiseEvent.Invoke();
  }
}