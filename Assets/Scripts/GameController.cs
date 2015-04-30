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

	/*	gameManagerObject = Instantiate (Resources.Load("Manager/GameManager")) as GameObject;
		GUImanagerObject = Instantiate (Resources.Load("Manager/GUIManager")) as GameObject;
		audioManagerObject = Instantiate (Resources.Load("Manager/AudioManager")) as GameObject;

		gameManagerObject.transform.parent = this.gameObject.transform;
		GUImanagerObject.transform.parent = this.gameObject.transform;
		audioManagerObject.transform.parent = this.gameObject.transform;*/

		gameManagerObject = InstantiateApi.InstanceAsChild (this.gameObject,Resources.Load("Manager/GameManager") as GameObject);
		GUImanagerObject = InstantiateApi.InstanceAsChild (this.gameObject, Resources.Load ("Manager/GUIManager") as GameObject);
		audioManagerObject =  InstantiateApi.InstanceAsChild (this.gameObject, Resources.Load ("Manager/AudioManager") as GameObject);

		GUImanager = GUImanagerObject.GetComponent<GUIManager> ();
		gameManager = gameManagerObject.GetComponent<GameManager> ();
		audioManager = audioManagerObject.GetComponent<AudioManager> ();

		ChangeScene (0);

	}

	public void ChangeScene(int index){
	/*	gameManager.SetGame (index);
		GUImanager.SetGUI (index);
		audioManager.SetAudio (index);*/

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
