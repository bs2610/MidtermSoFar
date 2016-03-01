using UnityEngine;
using System.Collections;

public class BallForce : MonoBehaviour {


	public Rigidbody ballRigidB;


	// Use this for initialization
	void Start () {
		Debug.Log ("Omgknsaflkgd");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float vertical = Input.GetAxis ("Vertical");
						float horizontal = Input.GetAxis ("Horizontal");
		
						Vector3 forwardForce = transform.forward * Time.deltaTime * 1000f * (Input.GetAxis("Vertical") *200f);
		GetComponent<Rigidbody> ().AddForce (forwardForce);

		Debug.Log ("Omgknsaflkgd");
	}
}
