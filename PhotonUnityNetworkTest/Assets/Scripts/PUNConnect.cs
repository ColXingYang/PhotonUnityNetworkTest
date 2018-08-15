using UnityEngine;
using System.Collections;

public class PUNConnect : MonoBehaviour {


    void Start()
    {
        PhotonNetwork.ConnectUsingSettings("v1.0");
    }
    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 75, 20, 150, 20), PhotonNetwork.connectionStateDetailed.ToString());
        if (GUI.Button(new Rect(Screen.width/2-50,50,100,30),"加入游戏房间" ))
        {
            if (PhotonNetwork.connected)
            {
                PhotonNetwork.JoinOrCreateRoom("xiaogeformax", new RoomOptions {MaxPlayers = 16}, null);
            }

        }

        if (GUI.Button(new Rect(Screen.width / 2 - 50, 90, 100, 30), "退出游戏房间"))
        {
            if (PhotonNetwork.connected)
            {
                PhotonNetwork.LeaveRoom();
            }
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 50, 130, 100, 30), "Connect"))
        {
            if (PhotonNetwork.connectionStateDetailed == ClientState.PeerCreated)
            {
                PhotonNetwork.ConnectToBestCloudServer("v1.0");
            }
        }
    }
}