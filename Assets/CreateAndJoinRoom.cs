using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateAndJoinRoom : MonoBehaviourPunCallbacks
{
    public TMP_InputField joinField;

    public void CreateRoom()
    {
        string joinKey = "";
        foreach(int i in new int[6])
        {
            joinKey += GlobalVariables.Base62[Random.Range(0, GlobalVariables.Base62.Length)];
        }
        PhotonNetwork.CreateRoom(joinKey, new RoomOptions() { MaxPlayers = 4 });
    }
    
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinField.text);
        joinField.text = "";
        PhotonNetwork.NickName = GlobalVariables.username;
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Lobby");
    }
}
