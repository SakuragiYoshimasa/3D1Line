using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TitleGUI : BaseGUI {

	private GameObject title;
	public GameObject startButtonInstance;
	
	public Button startButton;

	void Start () {

		title = InstantiateApi.InstanceAsChild (this.gameObject,Resources.Load ("Title") as GameObject);
		startButtonInstance = InstantiateApi.InstanceAsChild (this.gameObject, Resources.Load ("StartButton") as GameObject);
		
		startButton = startButtonInstance.transform.FindChild ("Canvas").gameObject.transform.FindChild ("Button").gameObject.GetComponent<Button> ();
		startButton.onClick.AddListener (StartClicked);

	}

	void StartClicked(){

		AudioManager.Instance.play();

	}

}
