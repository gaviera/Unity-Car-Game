using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {
    
    private void Update() {
        float sinInTime = Mathf.Sin(Time.time);

        transform.position = new Vector3(transform.position.x, 
                                        (sinInTime * 0.25f) + 0.35f,
                                        transform.position.z);

        transform.RotateAround(transform.position, Vector3.up, 1f);
    }

}
