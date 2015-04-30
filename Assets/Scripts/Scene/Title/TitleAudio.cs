using UnityEngine;
using System.Collections;

public class TitleAudio : BaseAudio {

	public AudioSource[] audioSources;
	public AudioClip[] audioClips;
	public GameObject[] audios;
	public int number_of_audios = 1;

	// Use this for initialization
	void Start () {

		audios = new GameObject[1];
		audioSources = new AudioSource[1];
		audioClips = new AudioClip[1];
	
		for(int i = 0; i < number_of_audios; i++){

			audios[i] = InstantiateApi.InstanceAsChild(this.gameObject,Resources.Load("GameObject") as GameObject);
			audioClips[i] = Resources.Load("Audio/button") as AudioClip;
			audioSources[i] = audios[i].AddComponent<AudioSource>();
			audioSources[i].clip = audioClips[i];

		}

	
	}

	public override void play(){

		audioSources [0].Play ();

		Invoke ("TitleEnd",0.1f);

	}

	void TitleEnd(){
		GameController.Instance.ChangeScene (1);
	}
}
