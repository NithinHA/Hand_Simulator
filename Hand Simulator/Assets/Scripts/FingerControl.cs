using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerControl : MonoBehaviour {

	public float rotationSpeed = 10f;

	public GameObject thumbTip, thumbLower;
	public GameObject indexTip, indexLower;
	public GameObject middleTip, middleLower;
	public GameObject ringTip, ringLower;
	public GameObject lastTip, lastLower;

	void Start () {
		
	}

	void FixedUpdate() {

		////////////////////		THUMB		/////////////////////
		if (Input.GetKey(KeyCode.Space))
			if (thumbLower.transform.localEulerAngles.y >= 270f)
			{
				thumbLower.transform.Rotate(0f, -Time.deltaTime * rotationSpeed, 0f);
				goto ThumbLowerCheck;
			}
		if (thumbLower.transform.localEulerAngles.y <= 358f)
				thumbLower.transform.Rotate(0f, Time.deltaTime * rotationSpeed, 0f);
		ThumbLowerCheck:

		if (Input.GetKey(KeyCode.B))
			if (thumbTip.transform.localEulerAngles.x <= 50f)
			{
				thumbTip.transform.Rotate(Time.deltaTime * rotationSpeed, 0f, 0f);
				goto ThumbTipCheck;
			}
		if (thumbTip.transform.localEulerAngles.x >= 1f)
		{
			thumbTip.transform.Rotate(-Time.deltaTime * rotationSpeed, 0f, 0f);
		}
		ThumbTipCheck:



		////////////////		INDEX FINGER		////////////////////
		if (Input.GetKey(KeyCode.V))
			if (indexLower.transform.localEulerAngles.x <= 88f)
			{
				//Debug.Log(indexLower.transform.rotation.x);
				indexLower.transform.Rotate(Time.deltaTime * rotationSpeed, 0f, 0f);
				goto IndexLowerCheck;
			}
		if (indexLower.transform.localEulerAngles.x >= 1f) {
			//Debug.Log(indexLower.transform.rotation.x);
			indexLower.transform.Rotate(-Time.deltaTime * rotationSpeed, 0f, 0f);
		}
		IndexLowerCheck:

		if (Input.GetKey(KeyCode.G))
			if (indexTip.transform.localEulerAngles.x <= 88f)
			{
				//Debug.Log(indexTip.transform.rotation.x);
				indexTip.transform.Rotate(Time.deltaTime * rotationSpeed, 0f, 0f);
				goto IndexTipCheck;
			}
		if (indexTip.transform.localEulerAngles.x >= 1f)
		{
			//Debug.Log(indexTip.transform.eulerAngles.x);
			indexTip.transform.Rotate(-Time.deltaTime * rotationSpeed, 0f, 0f);
		}
		IndexTipCheck:



		/////////////////		MIDDLE FINGER		//////////////////
		if (Input.GetKey(KeyCode.F))
			if (middleLower.transform.localEulerAngles.x <= 88f)
			{
				middleLower.transform.Rotate(Time.deltaTime * rotationSpeed, 0f, 0f);
				goto MiddleLowerCheck;
			}
		if (middleLower.transform.localEulerAngles.x >= 1f)
		{
			//Debug.Log(indexLower.transform.rotation.x);
			middleLower.transform.Rotate(-Time.deltaTime * rotationSpeed, 0f, 0f);
		}
		MiddleLowerCheck:

		if (Input.GetKey(KeyCode.R))
			if (middleTip.transform.localEulerAngles.x <= 88f)
			{
				//Debug.Log(indexTip.transform.rotation.x);
				middleTip.transform.Rotate(Time.deltaTime * rotationSpeed, 0f, 0f);
				goto MiddleTipCheck;
			}
		if (middleTip.transform.localEulerAngles.x >= 1f)
		{
			//Debug.Log(indexTip.transform.eulerAngles.x);
			middleTip.transform.Rotate(-Time.deltaTime * rotationSpeed, 0f, 0f);
		}
		MiddleTipCheck:



		/////////////////		RING FINGER			//////////////////
		if (Input.GetKey(KeyCode.D))
			if (ringLower.transform.localEulerAngles.x <= 88f)
			{
				//Debug.Log(indexLower.transform.rotation.x);
				ringLower.transform.Rotate(Time.deltaTime * rotationSpeed, 0f, 0f);
				goto RingLowerCheck;
			}
		if (ringLower.transform.localEulerAngles.x >= 1f)
		{
			//Debug.Log(indexLower.transform.rotation.x);
			ringLower.transform.Rotate(-Time.deltaTime * rotationSpeed, 0f, 0f);
		}
		RingLowerCheck:

		if (Input.GetKey(KeyCode.E))
			if (ringTip.transform.localEulerAngles.x <= 88f)
			{
				//Debug.Log(indexTip.transform.rotation.x);
				ringTip.transform.Rotate(Time.deltaTime * rotationSpeed, 0f, 0f);
				goto RingTipCheck;
			}
		if (ringTip.transform.localEulerAngles.x >= 1f)
		{
			//Debug.Log(indexTip.transform.eulerAngles.x);
			ringTip.transform.Rotate(-Time.deltaTime * rotationSpeed, 0f, 0f);
		}
		RingTipCheck:



		/////////////////		LAST FINGER			//////////////////
		if (Input.GetKey(KeyCode.Z))
			if (lastLower.transform.localEulerAngles.x <= 88f)
			{
				//Debug.Log(indexLower.transform.rotation.x);
				lastLower.transform.Rotate(Time.deltaTime * rotationSpeed, 0f, 0f);
				goto LastLowerCheck;
			}
		if (lastLower.transform.localEulerAngles.x >= 1f)
		{
			//Debug.Log(indexLower.transform.rotation.x);
			lastLower.transform.Rotate(-Time.deltaTime * rotationSpeed, 0f, 0f);
		}
		LastLowerCheck:

		if (Input.GetKey(KeyCode.S))
			if (lastTip.transform.localEulerAngles.x <= 88f)
			{
				//Debug.Log(indexTip.transform.rotation.x);
				lastTip.transform.Rotate(Time.deltaTime * rotationSpeed, 0f, 0f);
				goto LastTipCheck;
			}
		if (lastTip.transform.localEulerAngles.x >= 1f)
		{
			//Debug.Log(indexTip.transform.eulerAngles.x);
			lastTip.transform.Rotate(-Time.deltaTime * rotationSpeed, 0f, 0f);
		}
		LastTipCheck:

		return;
	}
}
