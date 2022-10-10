using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {
    
    public float characterSpeed = 0.5f;
    public float rotationSpeed = 4.5f;
    public int coinsCollected = 0;

    private void FixedUpdate() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.RotateAround(transform.position, Vector3.up, horizontal * rotationSpeed);
        transform.Translate(Vector3.forward * -vertical * characterSpeed, Space.Self);

        if (coinsCollected == 4)
            Debug.Log("Ganaste!");
    }

    private void OnTriggerEnter(Collider other) {
        coinsCollected++;
        Destroy(other.gameObject);
        
        Debug.Log(coinsCollected);
    }

    private void OnCollisionEnter(Collision other) {
        Destroy(this.gameObject);

        Debug.Log("Perdiste!");
    }
}
