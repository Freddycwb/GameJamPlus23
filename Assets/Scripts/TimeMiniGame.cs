using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeMiniGame : MonoBehaviour
{
    public InvokeAfterCounter counter;

    public float refTime;
    public float startTimeToCheck;  
    public float endTimeToCheck;
    public float delayToFinish;
    public GameObject circle;

    public float miniGameTime;
    public Vector3 startPos;
    public Vector3 endPos;
    private bool isTiming;            
    private float targetTime;         

    void Start()
    {
        isTiming = true;
        SetTiming();  
    }

    void Update()
    {
        
        circle.transform.position = Vector3.Lerp(startPos,endPos,refTime / miniGameTime);
        refTime = Mathf.Clamp(refTime + Time.deltaTime, 0, miniGameTime);

        if (isTiming && Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time > targetTime + miniGameTime * startTimeToCheck && Time.time < targetTime + miniGameTime * endTimeToCheck)
            {
                counter.IncreaseValue(1);
            }
            else
            {
                Debug.Log("errou"); 
            }

            //SetTiming();
        }
    }

    public void SetTiming()
    {
        targetTime = Time.time;
        refTime = 0;
    }
}


