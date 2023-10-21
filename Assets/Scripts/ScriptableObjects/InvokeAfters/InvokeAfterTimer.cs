using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeAfterTimer : InvokeAfter
{
    public float timeToAction;
    public bool loop;

    private void OnEnable()
    {
        StartCoroutine("Count");
    }

    private IEnumerator Count()
    {
        yield return new WaitForSeconds(timeToAction);
        CallAction();
        if (loop)
        {
            StartCoroutine("Count");
        }
        else
        {
            enabled = false;
        }
    }

    protected override void Disable()
    {
        StopCoroutine("Count");
        base.Disable();
    }
}
