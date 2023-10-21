using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider;
    public float increaseValue;
    

    public void IncreaseValue()
    {
        slider.value += increaseValue;
        slider.value = Mathf.Clamp(slider.value, slider.minValue, slider.maxValue);
    }
}
