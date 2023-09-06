using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject Target; 
    public GameObject Target2;

	public float offsetX = 0.0f;
    public float offsetY = 0.0f;
    public float offsetZ = -10.0f;

    public float CameraSpeed = 10.0f;
    Vector3 TargetPos;
	private void FixedUpdate()
	{
        if (Target2.activeSelf == false)
        {
            TargetPos = new Vector3
            (
                Target.transform.position.x + offsetX,
                Target.transform.position.y + offsetY,
                Target.transform.position.z + offsetZ
            );

            transform.position = Vector3.Lerp(transform.position, TargetPos, 1);
        }
        else
        {
			TargetPos = new Vector3
			(
				Target2.transform.position.x + offsetX,
				Target2.transform.position.y + offsetY,
				Target2.transform.position.z + offsetZ
			);

			transform.position = Vector3.Lerp(transform.position, TargetPos, 1);
		}
	}
}
