using System;

using TMPro;
using UnityEngine;


public class HeatTransfer : MonoBehaviour
{

    [SerializeField] TMP_InputField areaInput,espesorInput,conductInput,temp1Input,temp2Input;
    [SerializeField]float area, espesor, conductividad,temp1,temp2;
    [SerializeField] TMP_InputField diffTemperaturaText, resistenciaText, flujoText;
    public void Calculate()
    {
        area = Convert.ToInt32(areaInput.text);
        espesor = Convert.ToInt32(espesorInput.text);
        conductividad = Convert.ToInt32(conductInput.text);
        temp1 = Convert.ToInt32(temp1Input.text);
        temp2 = Convert.ToInt32(temp2Input.text);

        float diffTemp = temp2- temp1;
        float res = espesor / (conductividad * area);
        float flujo = diffTemp / res;

        diffTemperaturaText.text = diffTemp.ToString();
        resistenciaText.text = res.ToString();
        flujoText.text = flujo.ToString();
    }
}
