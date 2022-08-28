using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IfJoinRoomButton : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField inputF;

    public void Start()
    {
        gameObject.GetComponent<Button>().interactable = false;
    }

    public void UpdateUseButton() {
        if(inputF.text.Length >= 6)
        {
            gameObject.GetComponent<Button>().interactable = true;
        } else
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
    }
}
