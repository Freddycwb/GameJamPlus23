using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeAfterTimer : InvokeAfter
{
    public float timeToAction;
    public bool desableAfterAction = true;

    private void OnEnable()
    {
        StartCoroutine("Count");
    }

    private IEnumerator Count()
    {
        yield return new WaitForSeconds(timeToAction);
        CallAction();
        if (desableAfterAction)
        {
            enabled = false;
        }
    }
}
