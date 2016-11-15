using UnityEngine;
using System.Collections;

public class clickToMove : MonoBehaviour {

	private Vector3 destination;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//check if the player is clicking
		if (Input.GetMouseButton (0)) {

		//see where they're clicking
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit) && hit.collider.tag == "ground") 
			{
				//move the player to that point
				destination = hit.point;

				Vector3 move;

				move = destination - transform.position;

				//make sure the destination is at the player's current height
				//destination = new Vector3(destination.x, transform.position.y, destination.z);

				move = move.normalized;

				transform.position += move;

				//transform.position = Vector3.Lerp(transform.position, destination, .2f);
			}

		}
	
	}
}
