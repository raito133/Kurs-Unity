using System;
using TMPro;
using UnityEngine;

public class AdderButton : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField1;
    [SerializeField] TMP_InputField inputField2;
    [SerializeField] GameObject content;
    [SerializeField] GameObject calculationPrefab;
    [SerializeField] TMP_Dropdown dropdown;
    // Start is called before the first frame update
    public void Add()
    {
        int result;
        int value1 = Convert.ToInt32(inputField1.text);
        int value2 = Convert.ToInt32(inputField2.text);
        char operation;
        switch (dropdown.value)
        {
            case 0:
                result = value1 + value2;
                operation = '+';
                break;
            case 1:
                result = value1 - value2;
                operation = '-';
                break;
            case 2:
                result = value1 * value2;
                operation = '*';
                break;
            case 3:
                result = value1 / value2;
                operation = '/';
                break;
            default:
                result = value1 + value2;
                operation = '+';
                break;
        }
        GameObject calculation = Instantiate(calculationPrefab, content.transform);
        calculation.GetComponent<Calculation>().SetText(
            $"{inputField1.text} {operation} {inputField2.text} = {result}");
        //calculation.GetComponent<Calculation>().SetText(
        //    inputField1.text + " " + operation + " " + inputField2.text + " = " + result);
    }
}
