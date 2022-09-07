using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TemporaryHide : MonoBehaviour
{
    public WaitForSeconds wfs;
    public float waitTime;
    private Coroutine hideRoutine;
    public UnityEvent hideEvent, appearEvent;

    private void Start()
    {
        wfs = new WaitForSeconds(waitTime);
    }

    public void BeginRoutine()
    {
        hideRoutine = StartCoroutine(SubRoutine());
    }

    public void StopRoutine()
    {
        if (hideRoutine != null)
        {
            StopCoroutine(hideRoutine);
            appearEvent.Invoke();
            Debug.Log("Stopped Early");
        }
    }
    private IEnumerator SubRoutine()
    {
        hideEvent.Invoke();
        yield return wfs;
        appearEvent.Invoke();
    }
}
