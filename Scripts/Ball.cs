using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public Vector3 launchVelocity;
	private AudioSource audioSource;
    private Rigidbody rigidBody;
	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
		audioSource = GetComponent<AudioSource>();

        Launch ();

	}

	void Launch ()
	{
		rigidBody.velocity = launchVelocity;
		audioSource.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
