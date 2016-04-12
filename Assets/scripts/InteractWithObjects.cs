using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class InteractWithObjects : MonoBehaviour{
	
	// Update is called once per frame
	void Start ()
	{

	}
	void Update () 
	{
		interactionCheck ();
		Vector3 forward = transform.TransformDirection(Vector3.forward) * 5;
		Debug.DrawRay (this.transform.position, forward, Color.red, 0f);
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
}
