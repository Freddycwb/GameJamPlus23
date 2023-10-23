using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderInLayer : MonoBehaviour
{
    private SpriteRenderer render;

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        render.sortingOrder = Mathf.FloorToInt(transform.position.y * -100);
    }
}
