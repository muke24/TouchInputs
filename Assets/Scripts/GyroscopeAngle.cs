using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroscopeAngle : MonoBehaviour
{	
	void Start()
	{
		transform.rotation = new Quaternion(0, 0, 0, 0);

		if (!Input.gyro.enabled)
		{
			Input.gyro.enabled = true;
		}
	}

	void Update()
	{
		transform.rotation = Input.gyro.attitude;
	}
}
