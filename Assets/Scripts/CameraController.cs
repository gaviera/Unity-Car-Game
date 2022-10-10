using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    
    [SerializeReference] Transform characterTransform;
    public Vector3 offset;
    private float smoothSpeed = 0.125f;

    void FixedUpdate() {
        if (characterTransform != null) {
            Vector3 offsetPosition = characterTransform.position + offset;
            Vector3 smoothPosition = Vector3.Lerp(transform.position, offsetPosition, smoothSpeed);
            
            transform.position = smoothPosition;
        }
    }
}
