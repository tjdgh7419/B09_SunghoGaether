using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveChk : MonoBehaviour
{
    public Animator animator;

	private void Start()
	{
		
	}
	// Update is called once per frame
	void Update()
    {
		moveChk();
	}

	public void moveChk()
	{
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D))
		{
			animator.SetBool("moveChk", false);
		}else
		{
			animator.SetBool("moveChk", true);
		}
	}
}
