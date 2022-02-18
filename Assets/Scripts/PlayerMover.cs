using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerMover : MonoBehaviour {
    // Public variables are initialized
    public float Speed = 1;

    // Private variables are initialized
    private Rigidbody rigidbody;
    private Vector3 movement_force;

    // Start is called before the first frame update
    private void Start() {
        rigidbody = GetComponent<Rigidbody>();
    }

    // FixedUpdate is called once per frame before physics calculations
    private void FixedUpdate() {
        rigidbody.AddForce(movement_force * Speed);
    }

    // OnMove is called whenever movement is inputted 
    private void OnMove(InputValue movement_input) {
        Vector2 movement_input_vector = movement_input.Get<Vector2>();
        movement_force = new Vector3(movement_input_vector.x, 0f, movement_input_vector.y);
    }
}
