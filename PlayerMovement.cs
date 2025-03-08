using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

    public float speed;
    
    new Rigidbody2D rigidBody;
    
    Vector2 = movement;

    private void Awake() {}

    void Update() {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() {
        rigidBody.MovePosition(rigiBody.position + movement + speed * Time.fixedDeltaTime);
    }
}



