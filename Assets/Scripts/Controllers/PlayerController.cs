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
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
		}
		
		moveDirection.y -= gravity * Time.deltaTime; //apply gravity
		controller.Move(moveDirection * Time.deltaTime);
	}
}