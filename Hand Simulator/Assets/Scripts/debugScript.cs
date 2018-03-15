using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugScript : MonoBehaviour {

	public GameObject thumbTip, thumbLower;
	public GameObject indexTip, indexLower;
	public GameObject middleTip, middleLower;
	public GameObject ringTip, ringLower;
	public GameObject lastTip, lastLower;

	private void Start() {
		
	}

	void Update () {
		Debug.Log(thumbTip.transform.localEulerAngles.x);
		//Debug.Log(thumbLower.transform.localEulerAngles.y);
		//Debug.Log(indexLower.transform.localEulerAngles.x);
		//Debug.Log(indexTip.transform.localEulerAngles.x);
	}
}
