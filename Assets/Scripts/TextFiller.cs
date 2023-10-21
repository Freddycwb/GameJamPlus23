using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TextFiller : MonoBehaviour
{
    public IntVariable variable;
    public TMPro.TextMeshProUGUI tmp;
 
   
    void Update()
    {
        tmp.text = variable.Value.ToString();
    }
}
