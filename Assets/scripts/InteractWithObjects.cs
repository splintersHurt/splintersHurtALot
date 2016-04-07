using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class InteractWithObjects : MonoBehaviour{
	bool amIMain;
	ColorCorrectionCurves redColor;
	public EgoControl k;
	// Update is called once per frame
	void Start ()
	{
		redColor = this.gameObject.GetComponent<ColorCorrectionCurves> ();
		amIMain = true;
	}
	void Update () 
	{
		interactionCheck ();
		Vector3 forward = transform.TransformDirection(Vector3.forward) * 5;
		Debug.DrawRay (this.transform.position, forward, Color.red, 0f);
		if(Input.GetKeyDown(KeyCode.K))
			{
				switchBetweenEgos();
			}
	}
	void interactionCheck()
	{
		RaycastHit interactionObject;
		Interactable targetScript;
		if(Physics.Raycast(this.transform.position, this.transform.forward, out interactionObject, 5f))
		{//	Debug.Log (interactionObject.transform.name);
			if (interactionObject.transform.gameObject.GetComponent<Interactable> () != null) 
			{	
			//	Debug.Log("I acknowledge stuff");
				targetScript = interactionObject.collider.gameObject.GetComponent<Interactable>();
				targetScript.IsRayCastHitting (true);
				if (Input.GetKeyDown (KeyCode.E)) 
				{
					targetScript.interactionTriggered ();
				//	Debug.Log("I trigger stuff");
				}
			}
		}
	}
	void switchBetweenEgos()
	{
		if (amIMain) 
		{
			Debug.Log ("me red");
			redColor.enabled = true;
			k.badWakeUp ();
			amIMain = false;
		}
		else
		{	
			Debug.Log ("me no red");
			redColor.enabled = false;
			k.mainWakeUp ();
			amIMain = true;
		}
	}

}
