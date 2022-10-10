using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

    [SerializeReference] GameObject coinPrefab;

    void Start() {
        for (int i = 0; i < 4; i++) {
            Instantiate(coinPrefab, new Vector3(Random.Range(-20, 20), 0f, Random.Range(-20, 20)), Quaternion.AngleAxis(90, Vector3.right));
        }
    }
}
