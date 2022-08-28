using Photon.Pun;
using UnityEngine;

public class ExitGame : MonoBehaviourPunCallbacks
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            PhotonNetwork.LeaveLobby();
            Application.Quit();
        }
    }
}
