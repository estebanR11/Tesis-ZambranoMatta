using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MaterialBalanceSecond : MonoBehaviour
{
    [SerializeField] TMP_InputField CaInputField;
    [SerializeField] TMP_InputField HuInputField;
    [SerializeField] TMP_InputField SuInputField;
    [SerializeField] TMP_InputField MaInputField;
    [SerializeField] TMP_InputField CT1OutputField;
    [SerializeField] TMP_InputField CT2OutputField;
    [SerializeField] TMP_InputField CT3OutputField;

    public void CalculateValues()
    {
        float Ca, Hu, Su, Ma, M3, M4, M5, M6, CT1, CT2, CT3;

        Ca = float.Parse(CaInputField.text);
        Hu = float.Parse(HuInputField.text);
        Su = float.Parse(SuInputField.text);
        Ma = float.Parse(MaInputField.text);

        M3 = (Ma * (1 - Ca - Su)) / (1 - Su);
        M4 = Ma - M3;
        M5 = ((Hu - Su) * M4) / (Hu - 1);
        M6 = ((Su * M4) - M4) / (Hu - 1);
        CT1 = M3 / Ma;
        CT2 = M5 / Ma;
        CT3 = M6 / Ma;

        CT1OutputField.text = CT1.ToString();
        CT2OutputField.text = CT2.ToString();
        CT3OutputField.text = CT3.ToString();
    }
}
