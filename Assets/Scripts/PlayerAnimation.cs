using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;

public class PlayerAnimation : MonoBehaviour
{
    public PlayerInput input;
    public Animator anim;

    private Vector3 mousePos;
    public SpriteRenderer sprite;

    void Start()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

  
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10);
        sprite.flipX = transform.position.x > mousePos.x;
        if (input.direction.magnitude > 0) 
        {
            anim.Play("Walk");
        }
        else
        {
            anim.Play("Idle");
        }
    }

}
