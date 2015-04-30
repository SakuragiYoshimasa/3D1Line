using UnityEngine;
using System.Collections;

public class InstantiateApi:MonoBehaviour {


	public static GameObject InstanceAsChild(GameObject parent,GameObject child){
		GameObject Child = Instantiate (child) as GameObject;
		Child.transform.parent = parent.transform;
		return Child;
	}
}
