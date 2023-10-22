using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
   
    public Transform player;

    public void Teleport(Transform position)
    {
        player.position = position.position;
        Debug.Log("moveu");
    }
}
