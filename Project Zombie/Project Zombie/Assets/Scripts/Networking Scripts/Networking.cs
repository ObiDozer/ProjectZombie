using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Networking : MonoBehaviour {



	// Use this for initialization
	void Start () 
	{
		PhotonNetwork.ConnectUsingSettings("TESTPHASE");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public virtual void OnJoinedLobby()
	{
		PhotonNetwork.JoinRoom ("MasterServer", null);
	}
}
