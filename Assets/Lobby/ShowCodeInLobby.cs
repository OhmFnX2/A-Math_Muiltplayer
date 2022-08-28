using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowCodeInLobby : MonoBehaviourPunCallbacks
{
    
    void Start()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = PhotonNetwork.CurrentRoom.Name;
    }

}
