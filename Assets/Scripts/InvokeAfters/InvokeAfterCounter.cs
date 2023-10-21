using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeAfterCounter : InvokeAfter
{
    public int maxValue;
    public int currentValue;
    public int minValue;

    public void IncreaseValue(int value)
    {
        currentValue -= value;
        CallSubAction();
        if (currentValue >= maxValue)
        {
            CallAction();
        }
    }

    public void DecreaseValue(int value)
    {
        currentValue -= value;
        CallSubAction();
        if (currentValue <= minValue)
        {
            CallAction();
        }
    }
}
