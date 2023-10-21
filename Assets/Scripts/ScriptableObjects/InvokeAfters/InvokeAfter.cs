using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InvokeAfter : MonoBehaviour
{
    public UnityEvent action;
    public GameObject[] instantiateAfterAction;

    public UnityEvent subAction;
    public GameObject[] instantiateAfterSubAction;

    public bool destroyAfterAction;

    public void CallAction()
    {
        if (action != null)
        {
            action.Invoke();
        }
        InstantiateAfterAction();
    }

    public void CallSubAction()
    {
        if (subAction != null)
        {
            subAction.Invoke();
        }
        InstantiateAfterSubAction();
    }

    public void InstantiateAfterAction()
    {
        foreach (GameObject obj in instantiateAfterAction)
        {
            Instantiate(obj, transform.position, transform.rotation);
        }
    }

    public void InstantiateAfterSubAction()
    {
        foreach (GameObject obj in instantiateAfterSubAction)
        {
            Instantiate(obj, transform.position, transform.rotation);
        }
    }

    protected virtual void Disable()
    {
        if (destroyAfterAction)
        {
            Destroy(gameObject);
        }
    }

    private void OnDisable()
    {
        Disable();
    }
}
