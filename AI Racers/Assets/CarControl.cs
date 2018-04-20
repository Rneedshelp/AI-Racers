using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour {

    public float acceleration;//acceleration rate
    public float topSpeed;//maximum speed
    public float turnRate;
    public float resistance;
    private Vector2 moveVector; //The vector used to apply movement to the controller.
    private enum MoveStates { idle, forward,reverse} //States for standing, walking and running.
    private MoveStates moveStates=MoveStates.idle;

    Rigidbody2D rigid;


    // Use this for initialization
    void Start ()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        rigid.drag = resistance;
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        //set state for accelerating and reversing
        if(Input.GetKey(KeyCode.UpArrow))
        {
            moveStates = MoveStates.forward;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            moveStates = MoveStates.reverse;
        }
        else
        {
            moveStates = MoveStates.idle;
        }

        //steering
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Turn(1);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            Turn(-1);
        }

        //apply movement forces
        if(moveStates==MoveStates.forward)
        {
            Forward();
        }
        if(moveStates==MoveStates.reverse)
        {
            Reverse();
        }

        //print(transform.forward);
	}

	void Update()
	{
        //Used to counter spinning that occurs as the result of a collision.
		if (rigid.angularVelocity > 0) 
		{
			rigid.angularVelocity -= 0.5F;
		} 
		else if (rigid.angularVelocity < 0) 
		{
			rigid.angularVelocity += 0.5F;
		}

	}

    public void Forward()
    {
        rigid.AddForce(transform.up * acceleration);
        
    }
    public void Reverse()
    {
        rigid.AddForce(-transform.up * (acceleration * 0.75f));
    }
    public void Turn(int direction)//modifier for direction, -1 for left turn, 1 for right turn.
    {
        transform.Rotate(Vector3.forward * (direction * turnRate));//((direction * turnRate)(Vector3.forward));
    }
}
