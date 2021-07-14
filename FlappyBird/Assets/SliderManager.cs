using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    [SerializeField] Slider slider;
    public void OnValueChange()
    {
        text.text = slider.value.ToString();
    }
}
