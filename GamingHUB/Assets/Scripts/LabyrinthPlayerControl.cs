using System;
using UnityEngine;

public class LabyrinthPlayerControl : MonoBehaviour
{
    private Rigidbody _rigidbody;

    [SerializeField] private float speed;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        
        speed = 15;
    }

    private void FixedUpdate()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalMove, 0.0f, verticalMove);

        _rigidbody.AddForce(movement * speed * Time.deltaTime);

        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            _rigidbody.velocity = new Vector3(0, 0, 0);

        }

    }
}
