using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayButton : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private TextMeshProUGUI errorText;

    public PhotonView photonView;

    private bool isError = false;

    public GameObject isGameObject;

    void Start()
    {
        UpdatePlayerOwner();
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        PhotonNetwork.SetMasterClient(PhotonNetwork.PlayerList[0]);
        UpdatePlayerOwner();
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        if(otherPlayer.IsMasterClient)
        {
            PhotonNetwork.SetMasterClient(PhotonNetwork.PlayerList[1]);
        }
        UpdatePlayerOwner();
    }

    private void UpdatePlayerOwner()
    {
        if (PhotonNetwork.LocalPlayer.IsMasterClient)
        {
            isGameObject.SetActive(true);
        }
        else
        {
            isGameObject.SetActive(false);
        }

        if(PhotonNetwork.PlayerList.Length <= 1)
        {
            isError = true;
            errorText.text = "More than 2 players are required.";
        }
        else
        {
            isError = false;
            errorText.text = "";
        }
    }

    public void PushPlayButton()
    {
        if(!isError)
        {
            photonView.RPC("SendAll", RpcTarget.All);
        }
    }
}
