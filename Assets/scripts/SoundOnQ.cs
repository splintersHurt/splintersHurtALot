using UnityEngine;
using System.Collections;

public class SoundOnQ : MonoBehaviour {
	public AudioSource playerSource;
	// Use this for initialization
	void Start () {
		playerSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	public void playSoundOnQ(AudioClip k)
	{
		playerSource.clip = k;
		playerSource.Play ();
	}
}
