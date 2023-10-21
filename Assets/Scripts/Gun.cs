using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spawnPoint;
    public PlayerInput input;

    public float delayTime;
    private float currentDelayTime;

    private Vector3 mousePos;

    public SpriteRenderer sprite;

    private void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10);
        Vector2 lookDir = mousePos - transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,angle);

        sprite.flipY = transform.position.x > mousePos.x;

        if (input.fireDown && currentDelayTime <= 0)
        {
            Instantiate(bullet, spawnPoint.transform.position, transform.rotation);
            currentDelayTime = delayTime;
        }
        else if(currentDelayTime > 0) 
        {
            currentDelayTime -= Time.deltaTime;
        }
    }
}
