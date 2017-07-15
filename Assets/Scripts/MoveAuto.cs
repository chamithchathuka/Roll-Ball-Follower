using UnityEngine;
using System.Collections;

public class MoveAuto : MonoBehaviour {
	//Object that you want to move/lerp from start to end
	public GameObject wall;


	//Start position of the object
	public Vector3 startPos;

	//End position of the object
	public Vector3 endPos;
	
	//Distance from start to end
	public float distance;
	
	//Time taken to move the object from the start to end
	public float lerpTime;
	
	//Time will be added till it meets lerpTime and do certain conditions
	private float currentLerpTime = 0;
	
	//Prevent user to spam the movement of the object and causes bug
	private bool keyHit = false;


	void Start(){
		wall.transform.position = startPos;
	}
	
	void Update () 
	{
		//Object movement procedure
		if (Input.GetKeyDown (KeyCode.Tab) && keyHit == false) 
		{
		
			//Start position will be updated
		
			//End position will be updated

			keyHit = true;

		}
		
		if (keyHit == true) 
		{
			currentLerpTime += Time.deltaTime;
			if(currentLerpTime >= lerpTime)
			{
				currentLerpTime = lerpTime;
				keyHit = false;
			}
			
			float Perc = currentLerpTime/lerpTime;
			//Object will move from start to end
			wall.transform.position = Vector3.Lerp (startPos, endPos, Perc);

		}
		
		if (keyHit == false)
		{
			//Set currentLerpTime to 0 so that the process can be restarted again
			currentLerpTime = 0;
		}
	}
}
