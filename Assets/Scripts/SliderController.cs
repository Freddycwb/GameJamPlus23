using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider;
    public float increaseValue;
    

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            slider.value += increaseValue;
            slider.value = Mathf.Clamp(slider.value, slider.minValue, slider.maxValue);
        }
    }
}
