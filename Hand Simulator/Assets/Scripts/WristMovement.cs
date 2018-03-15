using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WristMovement : MonoBehaviour {

	public float rotationSpeed = 10f;
	
	void Start () {
		
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.I))
		{
			transform.Rotate(Time.deltaTime * rotationSpeed, 0f, 0f);
		}
		if (Input.GetKey(KeyCode.K))
		{
			transform.Rotate(-Time.deltaTime * rotationSpeed, 0f, 0f);
		}
		if (Input.GetKey(KeyCode.J))
		{
			transform.Rotate(0f, Time.deltaTime * rotationSpeed, 0f);
		}
		if (Input.GetKey(KeyCode.L))
		{
			transform.Rotate(0f, -Time.deltaTime * rotationSpeed, 0f);
		}
		if (Input.GetKey(KeyCode.U))
		{
			transform.Rotate(0f, 0f, Time.deltaTime * rotationSpeed);
		}
		if (Input.GetKey(KeyCode.O))
		{
			transform.Rotate(0f, 0f, -Time.deltaTime * rotationSpeed);
		}
	}
}
