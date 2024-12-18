using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketController : MonoBehaviour
{

    public float speed;

    public KeyCode up;

    public KeyCode down;

    public bool isPlayer = true;

    public float offset = 0.2f;

    private Rigidbody rb;

    private Transform ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        ball = GameObject.FindGameObjectWithTag("ball").transform;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isPlayer) {
            MoveByPlayer();
        } else {
            MoveByComputer();
        }

    }

   private void MoveByPlayer() {
    bool pressedUp = Input.GetKey(this.up);
        bool pressedDown = Input.GetKey(this.down);

        if (pressedUp) {
            rb.linearVelocity = Vector3.forward * speed;
        }

        else if (pressedDown) {
            rb.linearVelocity = Vector3.back * speed;
        }

        else  {
            rb.linearVelocity = Vector3.zero;
        }
   }
   private void MoveByComputer() {
    if (this.ball.position.z > transform.position.z + offset) {
        rb.linearVelocity = Vector3.forward * speed;
    } else if (this.ball.position.z < transform.position.z - offset){
        rb.linearVelocity = Vector3.back * speed;
    } else {
        rb.linearVelocity = Vector3.zero;
    }
   }
}
