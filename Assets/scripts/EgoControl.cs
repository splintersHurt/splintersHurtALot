using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class EgoControl : MonoBehaviour {
	public ColorCorrectionCurves redColor;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update (){
	
	}
	public void mainWakeUp()
	{
		redColor.enabled = false;
		this.gameObject.transform.position = new Vector3 (25.5f, 3.44f, 32.5f);
	}
	public void badWakeUp()
	{
		redColor.enabled = true;
		this.gameObject.transform.position = new Vector3 (-11.5f, 3.44f, -40f);
	}
}
