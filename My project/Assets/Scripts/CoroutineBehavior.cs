using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    public bool CanRun { get; set; }
    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfs;
    private WaitForFixedUpdate wffu;
    public UnityEvent startEvent, repeatCountEvent, startCountEvent, endCountEvent, repeatUntilFalseEvent;
    

    private void Start()
    {
        wfs = new WaitForSeconds(seconds);
        wffu = new WaitForFixedUpdate();
        startEvent.Invoke();
    }

    private IEnumerator Counting()
    {
        
       
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
        while (CanRun)
        {
            yield return wfs;
            repeatUntilFalseEvent.Invoke();
        }
    }

    public void StartRepeatUntilFalse()
    {
        CanRun = true;
        StartCoroutine(RepeatUntilFalse());
    }

}
