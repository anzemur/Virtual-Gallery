using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    public GameObject spawnPoint;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            other.gameObject.transform.position = spawnPoint.transform.position;
        }
    }
}
