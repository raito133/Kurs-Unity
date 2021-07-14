using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calculation : MonoBehaviour
{
    [SerializeField] TMP_Text text;

    public void SetText(string textToSet)
    {
        text.text = textToSet;
    }
}
