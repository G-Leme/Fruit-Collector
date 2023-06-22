using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;

    private Vector2 moveDirection = Vector2.zero;
    private PlayerInputs controls;
    private InputAction movePlayer;


    private void Awake()
    {
        controls = new PlayerInputs();
        
    }

    private void Update()
    {
        moveDirection = movePlayer.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * speed * Time.deltaTime, moveDirection.y * 0);
    }

    private void OnEnable()
    {
        movePlayer = controls.Player.Movement;
        movePlayer.Enable();
    }

    private void OnDisable()
    {
        movePlayer.Disable();
    }
}
