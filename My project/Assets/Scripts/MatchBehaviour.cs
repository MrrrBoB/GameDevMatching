using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    public UnityEvent startEvent, matchEvent, mismatchEvent;

    public void Start()
    {
        startEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj == null)
            return;
        

        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            mismatchEvent.Invoke();
        }
    }
}
