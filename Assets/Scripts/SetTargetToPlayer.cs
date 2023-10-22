using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTargetToPlayer : MonoBehaviour
{
    public GameObjectVariable player;
    private AIDestinationSetter destiny;

    void Start()
    {
        destiny = GetComponent<AIDestinationSetter>();
        destiny.target = player.Value.transform;
    }
}
