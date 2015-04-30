using UnityEngine;
using System.Collections;

public class GameController : Singleton<GameController> {

	public GameObject gameManagerObject;
	public GameObject GUImanagerObject;
	public GameObject audioManagerObject;

	public GameManager gameManager;
	public GUIManager GUImanager;
	public AudioManager audioManager;

	// Use this for initialization
	void Start () {

		gameManagerObject = InstantiateApi.InstanceAsChild (this.gameObject,Resources.Load("Manager/GameManager") as GameObject);
		GUImanagerObject = InstantiateApi.InstanceAsChild (this.gameObject, Resources.Load ("Manager/GUIManager") as GameObject);
		audioManagerObject =  InstantiateApi.InstanceAsChild (this.gameObject, Resources.Load ("Manager/AudioManager") as GameObject);

		ChangeScene (0);

	}

	public void ChangeScene(int index){

		GameManager.Instance.SetGame (index);
		GUIManager.Instance.SetGUI (index);
		AudioManager.Instance.SetAudio (index);

	}

	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.A)){
			ChangeScene(0);
		}
	}
}
