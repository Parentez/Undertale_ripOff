using UnityEngine;


public class Player : MonoBehaviour {

    public float speed;
    new Rigidbody2D rigidbody;
    
    private void Awake()

    void update() {

        if (Input.GetAxis("Horizontal") != 0) {
            rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0);
        }
        else {
            rigidbody.velocity = new Vector2(0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        }
    }
}



