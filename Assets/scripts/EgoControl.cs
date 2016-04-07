using UnityEngine;
using System.Collections;

public class EgoControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update (){
	
	}
	public void mainWakeUp()
	{
		this.gameObject.transform.position = new Vector3 (25.5f, 3.44f, 32.5f);
	}
	public void badWakeUp()
	{
		this.gameObject.transform.position = new Vector3 (-11.5f, 3.44f, -40f);
	}
}
