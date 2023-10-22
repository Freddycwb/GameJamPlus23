using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeMiniGame : MonoBehaviour
{
	[SerializeField] private Transform area;

    public InvokeAfterCounter counter;

    public float refTime;
    public float startTimeToCheck;
    public float endTimeToCheck;
    public GameObject circle;

    public float miniGameTime;
    public Vector3 startPos;
    public Vector3 endPos;
    private bool isTiming;
    private float targetTime;

    void OnEnable()
    {
        isTiming = true;
        SetTiming();
	area.position = (startTimeToCheck+endTimeToCheck)/2 * (endPos-startPos) + startPos;
	area.localScale = new Vector2((endTimeToCheck - startTimeToCheck) * (endPos.x - startPos.x), area.localScale.y);
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


