using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIManager : Singleton<GUIManager> {

	public BaseGUI GUIComponent;
	
	void Start(){

		GUIComponent = this.gameObject.AddComponent<BaseGUI> ();

	}

	public void SetGUI(int index){

		//All scene objects shuold be children of manager and when change scene, destroy all children. 
		Destroy (GUIComponent);
		for(int i = 0; i < this.gameObject.transform.childCount; i++){
			Destroy(this.gameObject.transform.GetChild(i).gameObject);
		}
		
		switch(index){

			case 0:
				GUIComponent = this.gameObject.AddComponent<TitleGUI>();
				break;

			default:
				break;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
