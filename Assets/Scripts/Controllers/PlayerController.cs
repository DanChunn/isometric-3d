using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour {
	public float speed = 5.0F;
	public float gravity = 15.0F;
	private Vector3 moveDirection = Vector3.zero;
	public CharacterController controller;

	void Start(){
		controller = GetComponent<CharacterController>();
	}

	void Update() 
	{
		if (controller.isGrounded) 
		{
			moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")); //raw for unsmoothed input
			moveDirection *= speed;
			moveDirection = transform.TransformDirection(moveDirection);
		}
		moveDirection.y -= gravity * Time.deltaTime; //apply gravity
		controller.Move(moveDirection * Time.deltaTime);

		//Debug.Log(EnrichLogUtil.Colorize(moveDirection.ToString(), Color.blue));
		//Debug.Log(moveDirection.ToString());
	}
}