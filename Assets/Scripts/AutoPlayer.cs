using UnityEngine;
using System.Collections;

public class AutoPlayer : MonoBehaviour {

	float t;
	public Vector3 startPosition;
	public Vector3 target;
	public float timeToReachTarget;

	void Start()
	{

		startPosition = target = transform.position;
	}
	void Update() 
	{
		print ("method called");
		t += Time.deltaTime/timeToReachTarget;
		transform.position = Vector3.Lerp(startPosition, target, t);
	}
	public void SetDestination(Vector3 destination, float time)
	{
		t = 0;
		startPosition = transform.position;
		timeToReachTarget = time;
		target = destination; 
	}
}
