using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Ball))]
public class DragLaunch : MonoBehaviour {

	private Vector3 fingerStartPos, fingerEndPos;
	private float startDragTime, dragEndTime;
	private Ball ball;
	// Use this for initialization
	void Start () {
		ball = GetComponent<Ball>();
	}

	public void DragStart(){
		fingerStartPos = Input.mousePosition;
		Debug.Log (fingerStartPos);
		startDragTime = Time.time;
	}


	public void DragEnd(){
		fingerEndPos = Input.mousePosition;
		dragEndTime = Time.time;

		Vector3 dragDistance = fingerEndPos-fingerStartPos;
		float dragTime = dragEndTime-startDragTime;
		float launchSpeed =(fingerEndPos.x - fingerStartPos.x)/dragTime;


		Debug.Log (fingerEndPos);
		Debug.Log ("Moved "+ dragDistance.x + "in x direction, and "+ dragDistance.y + "in y direction.");
		Debug.Log ("took " + dragTime + " seconds to drag.");

		Vector3 dragParameters = new Vector3(fingerEndPos.x, 0f, dragTime);
		ball.Launch(dragParameters);
	
	}

}
