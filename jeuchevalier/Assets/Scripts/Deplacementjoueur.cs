using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacementjoueur : MonoBehaviour
{
    //CharacterController characController;
    public Rigidbody2D rigbod;

    private Vector3 velocity = Vector3.zero;

    public float MoveSpeed;
    public float JumpSpeed;

    public bool Jumping = false;
    public bool onGround = true;

    public static Deplacementjoueur instance;

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;
     
        if (rigbod.IsTouchingLayers(1))
        {
            if (Input.GetButtonDown("Jump"))
            {
                Jumping = true;
            }
        }

        horizontal_Movement(horizontalMovement);
    }


    void horizontal_Movement(float Movementx)
    {
        Vector3 targetVelocity = new Vector2(Movementx, rigbod.velocity.y);
        rigbod.velocity = Vector3.SmoothDamp(rigbod.velocity, targetVelocity, ref velocity, .05f);
        if (Jumping == true)
        {
            rigbod.AddForce(new Vector2(0f, JumpSpeed));
            Jumping = false;
        }
    }

    public void AddSpeed(int speedGiven, float speedDuration)
    {
        MoveSpeed += speedGiven;
        StartCoroutine(RemoveSpeed(speedGiven, speedDuration));
    }

    private IEnumerator RemoveSpeed(int speedGiven, float speedDuration)
    {
        yield return new WaitForSeconds(speedDuration);
        MoveSpeed -= speedGiven;
    }
}

