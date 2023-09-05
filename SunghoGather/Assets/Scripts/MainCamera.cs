using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject Target;

    public float offsetX = 0.0f;
    public float offsetY = 0.0f;
    public float offsetZ = -10.0f;

    public float CameraSpeed = 10.0f;
    Vector3 TargetPos;

	private void FixedUpdate()
	{
        TargetPos = new Vector3
        (
            Target.transform.position.x + offsetX,
            Target.transform .position.y + offsetY,
            Target.transform.position .z + offsetZ
        );

        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * CameraSpeed);
	}
}
