using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    public bool canRun;
    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfs;
    private WaitForFixedUpdate wffu;
    public UnityEvent startEvent, repeatCountEvent, startCountEvent, endCountEvent, repeatUntilFalseEvent;

    private void Start()
    {
        startEvent.Invoke();
    }

    private IEnumerator Counting()
    {
        
        wfs = new WaitForSeconds(seconds);
        wffu = new WaitForFixedUpdate();
        startCountEvent.Invoke();
        yield return wfs;
        while (counterNum.num > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.num--;
            yield return wfs;
        }
        endCountEvent.Invoke();
    }

    public void StartCounting()
    {
        StartCoroutine(Counting());
    }

    private IEnumerator RepeatUntilFalse()
    {
        while (canRun)
        {
            yield return wfs;
            repeatUntilFalseEvent.Invoke();
        }
    }

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }

}
