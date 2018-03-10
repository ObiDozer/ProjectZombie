using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerNetwork : MonoBehaviour {

	[SerializeField]
	GameObject camera;

	private PhotonView photonView;

	private RigidbodyFirstPersonController rBodyController;

	// Use this for initialization
	void Start () 
	{
		photonView = GetComponent<PhotonView> ();
		rBodyController = GetComponent<RigidbodyFirstPersonController> ();

		if (photonView.isMine) 
		{
			
		} else 
		{
			camera.SetActive (false);
			rBodyController.enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
