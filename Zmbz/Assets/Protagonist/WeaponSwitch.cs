using UnityEngine;
using System.Collections;

public class WeaponSwitch : MonoBehaviour {
	Animator anim;
	[SerializeField] GameObject axe; 
	[SerializeField] GameObject pistol;
	// Use this for initialization
	void Start () {
		anim = pistol.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Q)) {
			if (axe.activeSelf) {
				axe.SetActive (false);
				pistol.SetActive (true);
			} else {
				if (!anim.GetCurrentAnimatorStateInfo (0).IsName ("Reload")) {
					axe.SetActive (true);
					pistol.SetActive (false);
				}
			} 
		}
	}
}
