using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {
    // Public variables are initialized
    public GameObject Player;
    
    // Private variables are initialized
    private Vector3 offset;

    // Start is called before the first frame update
    private void Start() {
        offset = transform.position - Player.transform.position;
    }

    // LateUpdate is called once per frame after all other update functions
    private void LateUpdate() {
        transform.position = Player.transform.position + offset;
    }
}
