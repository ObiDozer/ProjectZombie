using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Networking : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () 
	{
		PhotonNetwork.ConnectUsingSettings("TESTPHASE");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public virtual void OnJoinedLobby ()
	{
		PhotonNetwork.JoinOrCreateRoom ("MasterServer", null, null);
	}

	public virtual void OnJoinedRoom () 
	{
		PhotonNetwork.Instantiate (player.name, transform.position, transform.rotation, 0);
	}
}
