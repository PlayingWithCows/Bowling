using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public Vector3 launchVelocity;
	private AudioSource audioSource;
    private Rigidbody rigidBody;
	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
		rigidBody.useGravity=false;
		
	}

	public void Launch (Vector3 velocity)
	{
		Debug.Log ("Launching Ball with parameters x, y, z :" + velocity);
		rigidBody.velocity = velocity;
		rigidBody.useGravity=true;

		audioSource = GetComponent<AudioSource>();
		audioSource.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
