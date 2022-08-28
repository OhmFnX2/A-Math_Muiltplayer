using Photon.Pun;
using UnityEngine;

public class ExitLobbyToMainMenu : MonoBehaviourPunCallbacks
{
    public void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Exit();
        }
    }

    public void Exit()
    {
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.LoadLevel("MainMenu");
    }
}
