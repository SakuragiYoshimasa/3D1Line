using UnityEngine;
using System.Collections;

public class AudioManager : Singleton<AudioManager> {

	public BaseAudio AudioComponent;

	// Use this for initialization
	void Awake () {

		//AudioComponent = this.gameObject.AddComponent<BaseAudio>();
	
	}

	public void SetAudio(int index){

		//All scene objects shuold be children of manager and when change scene, destroy all children. 
		Destroy (AudioComponent);

		for(int i = 0; i < this.gameObject.transform.childCount; i++){
			Destroy(this.gameObject.transform.GetChild(i).gameObject);
		}
		
		switch(index){
			
			case 0:
				AudioComponent = this.gameObject.AddComponent<TitleAudio>();
				break;
			
			default:
				break;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void play(){
		Debug.Log ("Play");
		AudioComponent.play ();
	}
}
