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
		audioSource = GetComponent<AudioSource>();

		Launch (launchVelocity);
		
	}

	public void Launch (Vector3 velocity)
	{
		rigidBody.velocity = launchVelocity;
		rigidBody.useGravity=true;
		audioSource.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
