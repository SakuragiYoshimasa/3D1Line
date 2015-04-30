using UnityEngine;
using System.Collections;

public class BaseAudio : MonoBehaviour {
	
	public AudioSource[] audioSources;
	public AudioClip[] audioClips;
	public GameObject[] audios;
	public int number_of_audios;


	//use this method override
	public virtual void play(){
	}
}
