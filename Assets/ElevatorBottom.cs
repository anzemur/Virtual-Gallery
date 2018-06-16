using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorBottom : MonoBehaviour {

    public Collider forceFloor;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            other.GetComponent<Player>().descending = false;
            other.GetComponent<Rigidbody>().useGravity = true;
            forceFloor.enabled = true;
            other.gameObject.layer = 11;
        }
    }

    private void OnTriggerStay(Collider other) {
        Player player = other.GetComponent<Player>();
        if (other.tag == "Player" && player.isLocalPlayer && Input.GetButtonDown("Jump")) {
            other.transform.position = this.transform.position;
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0, 0, 0);
            player.ascending = true;
            other.GetComponent<Rigidbody>().useGravity = false;
            forceFloor.enabled = false;
            other.gameObject.layer = 12;
        }
    }
}
