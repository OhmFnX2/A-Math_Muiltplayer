using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyCodeRoom : MonoBehaviourPunCallbacks
{
    public void CopyCode()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.text = PhotonNetwork.CurrentRoom.Name;
        textEditor.SelectAll();
        textEditor.Copy();
    }
}
