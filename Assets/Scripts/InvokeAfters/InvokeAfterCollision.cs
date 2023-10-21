using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeAfterCollision : InvokeAfter
{
    public string tag = "";

    private void OnCollisionEnter(Collision collision)
    {
        if (tag == "" || tag == collision.gameObject.tag)
        {
            CallAction();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (tag == "" || tag == collision.gameObject.tag)
        {
            CallSubAction();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (tag == "" || tag == other.gameObject.tag)
        {
            CallAction();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (tag == "" || tag == other.gameObject.tag)
        {
            CallSubAction();
        }
    }
}
