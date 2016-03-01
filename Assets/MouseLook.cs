using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

	float rotationY;


	// Update is called once per frame
	void Update () {

		float mouseX = Input.GetAxis ("Mouse X");
		float mouseY = Input.GetAxis ("Mouse Y");

//		transform.Rotate (mouseY * Time.deltaTime * 90f, 
//						  mouseX * Time.deltaTime * 90f,
//			              0f);

		transform.Rotate ( 0f,mouseX * Time.deltaTime * 90f,0f);


		rotationY += -mouseY * Time.deltaTime * 90f;
		rotationY = Mathf.Clamp (rotationY, -80f, 80f);
		transform.localEulerAngles = new Vector3 (rotationY, transform.localEulerAngles.y, 0f);
	}
}
