using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class RayCast : MonoBehaviour {

	public GameObject ball;
	bool ballLook = false;

	public GameObject doll;
	bool dollHave;

	public GameObject car;


	//public Rigidbody ballRB = ball.GetComponent<Rigidbody>();



	void Update () {
		
		float vertical = Input.GetAxis ("Vertical");
		float horizontal = Input.GetAxis ("Horizontal");


		Ray ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
		RaycastHit rayHitInfo = new RaycastHit ();


		//for car
		if (Physics.Raycast (ray, out rayHitInfo, 5f) && (rayHitInfo.transform == car.transform)) {
		
			if (Input.GetKeyDown (KeyCode.Space)) {
				
				transform.position = car.transform.position;
			}
		}



		//for doll
		if (Physics.Raycast (ray, out rayHitInfo, 5f) && (rayHitInfo.transform == doll.transform) ) {

			if (Input.GetKeyDown (KeyCode.Space)) {
				OnDollHave ();
				if (dollHave == false) {
					dollHave = true;
					OnStartDollHave ();
				} else {
					OnNoDollHave ();
					if (dollHave == true) {
						dollHave = false;
						OnEndDollHave();
					}
				}
			}
		}else if (Physics.Raycast (ray, out rayHitInfo, 5f) && (rayHitInfo.transform == ball.transform) ) {
		
			//to put in :
			//display text 
			//not here, but set bounciness of ball
			//onstartlook goes here actually

			//getkey wants you to keep holding down the button while getkeydown only needs you to press it once
			if (Input.GetKeyDown (KeyCode.Space)) {
				Debug.Log ("poop");
				OnBallLook ();
				if (ballLook == false) {
					ballLook = true;
					OnStartBallLook ();
				} else {
					OnNoBallLook ();
					if (ballLook == true) {
						ballLook = false;
						OnEndBallLook();
					}
				}
			}

		}

		//checks to see if looking at the ball is true
		if (ballLook == true) {
			ball.transform.position = Camera.main.transform.position + Camera.main.transform.forward;
			if (Input.GetKey (KeyCode.Space)) {

				OnBallLook ();
				
				//Vector3 forwardForce = transform.forward * Time.deltaTime * 1000f * (Input.GetAxis("Vertical") *200f);

				//ball.GetComponent<Rigidbody> ().AddForce (-2f, 2f, 0f); //(forwardForce);

				//ball.GetComponent<BallForce> ().ballRigidB.AddForce(forwardForce);

				//Debug.Log ("This is ho0w we spell diahrehhea");

				}


		}else if (dollHave == true) {
			doll.transform.position = Camera.main.transform.position + Camera.main.transform.forward;
			if (Input.GetKey (KeyCode.Space)) {

				OnDollHave ();

				//Vector3 forwardForce = transform.forward * Time.deltaTime * 1000f * (Input.GetAxis("Vertical") *200f);

				//ball.GetComponent<Rigidbody> ().AddForce (-2f, 2f, 0f); //(forwardForce);

				//ball.GetComponent<BallForce> ().ballRigidB.AddForce(forwardForce);

				//Debug.Log ("This is ho0w we spell diahrehhea");

			}


		}



				
		}
			
		



	//ball stuff
	void OnStartBallLook(){
	}



	void OnBallLook(){
		//float speed = 10f;
		//float vertical = Input.GetAxisRaw ("Vertical") * speed;
		//float horizontal = Input.GetAxis ("Horizontal");

		Vector3 forwardForce = transform.forward * Time.deltaTime * 50f; //* vertical;
		ball.GetComponent<Rigidbody> ().AddForce(forwardForce);

	}
		

	void OnEndBallLook(){
	}


	void OnNoBallLook(){
	}



 
	//doll stuff
	void OnDollHave(){
	}

	void OnStartDollHave(){
	}

	void OnEndDollHave(){
	}

	void OnNoDollHave(){
	}


}