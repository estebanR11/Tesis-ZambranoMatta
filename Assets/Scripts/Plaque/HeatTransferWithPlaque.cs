using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeatTransferWithPlaque : MonoBehaviour
{
    [SerializeField] TMP_InputField areaInput, espesorInput,espesor2Input, conductInput,conductInput2, temp1Input, temp2Input;
    [SerializeField] float area, espesor,espesor2, conductividad, conductividad2, temp1, temp2;
    [SerializeField] TMP_InputField diffTemperaturaText, resistenciaText, flujoText;
    public void Calculate()
    {
        area = Convert.ToInt32(areaInput.text);
        espesor = Convert.ToInt32(espesorInput.text);
        espesor2 = Convert.ToInt32(espesor2Input.text);
        conductividad = Convert.ToInt32(conductInput.text);
        conductividad2 = Convert.ToInt32(conductInput2.text);
        temp1 = Convert.ToInt32(temp1Input.text);
        temp2 = Convert.ToInt32(temp2Input.text);

        float diffTemp = temp2 - temp1;
        float res = (espesor / (conductividad * area) )+ (espesor2 / conductividad2 * area) ;
        float flujo = diffTemp / res;

        diffTemperaturaText.text = diffTemp.ToString();
        resistenciaText.text = res.ToString();
        flujoText.text = flujo.ToString();
    }
}
