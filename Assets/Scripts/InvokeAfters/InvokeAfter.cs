using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InvokeAfter : MonoBehaviour
{
    public UnityEvent action;
    public UnityEvent subAction;

    public void CallAction()
    {
        if (action != null)
        {
            action.Invoke();
        }
    }

    public void CallSubAction()
    {
        if (subAction != null)
        {
            subAction.Invoke();
        }
    }
}
