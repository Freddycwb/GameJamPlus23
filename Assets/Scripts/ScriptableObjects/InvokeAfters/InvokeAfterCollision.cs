using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeAfterCollision : InvokeAfter
{
    public string tag = "";
    public GameObject lastCollision;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "" || tag == collision.gameObject.tag)
        {
		lastCollision = collision.gameObject;
            CallAction();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (tag == "" || tag == collision.gameObject.tag)
        {
	        lastCollision = collision.gameObject;
            CallSubAction();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (tag == "" || tag == other.gameObject.tag)
        {
	        lastCollision = other.gameObject;
            CallAction();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (tag == "" || tag == other.gameObject.tag)
        {
	        lastCollision = other.gameObject;
            CallSubAction();
        }
    }
}
