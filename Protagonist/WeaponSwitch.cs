using UnityEngine;
using System.Collections;

public class WeaponSwitch : MonoBehaviour {
	[SerializeField] GameObject axe; 
	[SerializeField] GameObject pistol;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Q)) {
			if (axe.activeSelf) {
				axe.SetActive (false);
				pistol.SetActive (true);
			} 
			else {
				axe.SetActive (true);
				pistol.SetActive (false);
			}
		} 
	}
}
