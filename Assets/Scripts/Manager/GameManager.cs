using UnityEngine;
using System.Collections;

public class GameManager : Singleton<GameManager> {
	
	public BaseGame GameComponent;
	

	void Start () {
		//GameComponent = this.gameObject.AddComponent<BaseGame> ();
	}

	public void SetGame(int index){

		//All scene objects shuold be children of manager and when change scene, destroy all children. 

		Destroy (GameComponent);

		for(int i = 0; i < this.gameObject.transform.childCount; i++){
			Destroy(this.gameObject.transform.GetChild(i).gameObject);
		}


		switch(index){
			
			case 0:
				GameComponent = this.gameObject.AddComponent<TitleGame>();
				break;
			
			default:
				break;

		}

	}


	
	// Update is called once per frame
	void Update () {

	}
}
