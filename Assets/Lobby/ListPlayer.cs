using Photon.Pun;
using Photon.Realtime;
using System;
using TMPro;
using UnityEngine;

public class ListPlayer : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private TextMeshProUGUI[] textPlayers = new TextMeshProUGUI[4];
    [SerializeField]
    private TextMeshProUGUI playerCount;

    void Start()
    {
        UpdatePlayerList();
    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        UpdatePlayerList();
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        if(otherPlayer.IsMasterClient)
        {
            PhotonNetwork.LeaveRoom();
            PhotonNetwork.LoadLevel("MainMenu");
        }
        UpdatePlayerList();
    }

    private void UpdatePlayerList()
    {
        PhotonNetwork.NickName = GlobalVariables.username;
        playerCount.text = $"Player Count: {PhotonNetwork.PlayerList.Length}/4";
        int count = 0;
        foreach (TextMeshProUGUI textPlayer in textPlayers)
        {
            try
            {
                textPlayer.text = PhotonNetwork.PlayerList[count].NickName;
            }
            catch (Exception _)
            {
                textPlayer.text = "";
            }
            count++;
        }
    }

}
