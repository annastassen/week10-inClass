using UnityEngine;
using System.Collections;

public class CameraTrigger : MonoBehaviour {

	//public GameObject camToActivate;

	public int camNumber;

	public cameraController controller;

	void OnTriggerEnter(Collider other){

		controller.DeactivateCameras ();


	}

}
