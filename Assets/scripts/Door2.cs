using UnityEngine;
using System.Collections;

public class Door2 : MonoBehaviour, Interactable {
	bool isInteractable;
	bool isDoorOpen;
	bool openingAndClosing;
	// Use this for initialization
	void Start ()
	{
		isInteractable = false;
		isDoorOpen = false;
		openingAndClosing = false;
	}

	// Update is called once per frame
	void Update () 
	{
		if (isInteractable) 
		{	
			showInteractionAvailable ();
			isInteractable = false;
		}
		doorOpens ();
		doorCloses ();
		Debug.Log (transform.eulerAngles.y);
	}
	public void IsRayCastHitting(bool k)
	{
		isInteractable = true;
	}
	public void interactionTriggered ()
	{
		whatToDoWithDoors ();
	//	Debug.Log ("I am being triggered");
	}
	public void showInteractionAvailable()
	{

	}
	void doorOpens()
	{
		if (((transform.eulerAngles.y == 0)||(transform.eulerAngles.y > 270)) && openingAndClosing) {
			transform.Rotate (0, -(Time.deltaTime * 150), 0);
		}
		else 
		{
			isDoorOpen = true;
		}
	}
	void doorCloses()
	{
		if (!(transform.eulerAngles.y < 5) && !openingAndClosing) 
		{
			transform.Rotate (0, (Time.deltaTime * 150), 0);
		}
		else 
		{
			isDoorOpen = false;
		}
	}
	void whatToDoWithDoors()
	{
		openingAndClosing = !openingAndClosing;
	}
}
