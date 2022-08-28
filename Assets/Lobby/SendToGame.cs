using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendToGame : MonoBehaviourPun
{
    [PunRPC]
    public void SendAll()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
