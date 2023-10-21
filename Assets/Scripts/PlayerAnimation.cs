using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public PlayerInput input;
    public Animator anim;
   
    void Start()
    {
        anim = GetComponent<Animator>();
    }

  
    void Update()
    {
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
