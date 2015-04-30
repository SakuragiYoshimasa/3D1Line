using UnityEngine;
using System.Collections;

public class TitleAudio : BaseAudio {
	
	void Start () {

		number_of_audios = 1;
		audios = new GameObject[number_of_audios];
		audioSources = new AudioSource[number_of_audios];
		audioClips = new AudioClip[number_of_audios];
	
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

	void TitleEnd(){  GameController.Instance.ChangeScene (1);	}
}
