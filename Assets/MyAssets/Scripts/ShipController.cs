using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {
	
	public float movementSpeed = 5.0f;
	float _direction = 0;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () 
	{	
		_direction = Input.GetAxis("Horizontal");

		Vector3 newPos = transform.position;

		newPos.x += _direction * movementSpeed * Time.deltaTime;

		transform.position = newPos;
	}
	
	/*void FixedUpdate()
	{
		// If the player is changing direction (h has a different sign to velocity.x) or hasn't reached maxSpeed yet...
		if(_direction * rigidbody2D.velocity.x < maxSpeed)
		{
			// ... add a force to the player.
			rigidbody2D.AddForce(Vector2.right * _direction * movementSpeed);
		}
		
		// If the player's horizontal velocity is greater than the maxSpeed...
		if(Mathf.Abs(rigidbody2D.velocity.x) > maxSpeed)
		{
			// ... set the player's velocity to the maxSpeed in the x axis.
			rigidbody2D.velocity = new Vector2(Mathf.Sign(rigidbody2D.velocity.x) * maxSpeed, rigidbody2D.velocity.y);
		}
	}*/
}
