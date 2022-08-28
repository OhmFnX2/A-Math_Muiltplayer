using TMPro;
using UnityEngine;

public class LimitChar: MonoBehaviour {

    [SerializeField]
    private int limitChar;

    public void setLimitChar()
    {
        gameObject.GetComponent<TMP_InputField>().characterLimit = limitChar;
    }

}