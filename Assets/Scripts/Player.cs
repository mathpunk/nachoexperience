using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Controller2D))]
//[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    #region Variables
    #region Input Vars
    float horizontalInput, verticalInput;
    #endregion Input Vars

    #region Physics Vars
    float gravity, fallSpeed;
    #endregion Physics Vars

    #region Speed Vars
    [Range(0.1f, 100f)]
    [SerializeField]
    float speed;
    #endregion Speed Vars
    #endregion Variables

    Vector2 velocity;
    Controller2D controller;

    private void Start()
    {
        controller = GetComponent<Controller2D>();
    }

    private void Update()
    {
        BasicMovement();
    }

    private void BasicMovement()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        velocity.x = input.x * speed;
        velocity.y = input.y * speed;

        controller.Move(velocity * Time.deltaTime);
    }
}
