using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	CharacterController myController;

	// Use this for initialization
	void Start () {
	

		myController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		//myController.Move ((movement + Physics.gravity) * Time.deltaTime ); 


		Vector3 movement = transform.forward * 5f * vertical;
		myController.Move( (movement + Physics.gravity * 2f) * Time.deltaTime );

		transform.Rotate (0f, horizontal * 90f * Time.deltaTime, 0f);
		//transform.Rotate (vertical * 45f * Time.deltaTime, 0f , 0f);
	
	}
}
