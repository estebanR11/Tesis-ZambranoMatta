using TMPro;
using UnityEngine;

public class MaterialBalanceFirst : MonoBehaviour
{
    [SerializeField] TMP_InputField MInputField;
    [SerializeField] TMP_InputField A1InputField;
    [SerializeField] TMP_InputField A2InputField;
    [SerializeField] TMP_InputField C1InputField;
    [SerializeField] TMP_InputField X2OutputField;
    [SerializeField] TMP_InputField X3OutputField;
    public void CalculateValues()
    {
        float M, A1, A2, C1, C2, P1, P2, X1, X2, X3, CT1, CT2;

        M = float.Parse(MInputField.text);
        A1 = float.Parse(A1InputField.text);
        A2 = float.Parse(A2InputField.text);
        C1 = float.Parse(C1InputField.text);

        P1 = M * A1;
        P2 = M * A2;

        C2 = 1 - C1;
        X1 = (P1 * C2) / C1;
        CT1 = P1 + X1;
        CT2 = P2 - X1;

        X2 = CT1 / M;
        X3 = CT2 / M;

        X2OutputField.text = X2.ToString();
        X3OutputField.text = X3.ToString();
    }
}
