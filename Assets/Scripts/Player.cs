using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class Player : NetworkBehaviour {
    public bool ascending;
    public bool descending;
    public float upDownSpeed = 10f;
    public GameObject playerCamera;

    private void Start() {
        if(isLocalPlayer) {
            // Debug.Log("Setting camera to active!");
            playerCamera.SetActive(true);
        } else {
            // Debug.Log("Setting camera to not active!");
            playerCamera.SetActive(false);
        }
    }

    private void Update() {
        /*
        if (isLocalPlayer) {
            float horAxis = Input.GetAxis("Horizontal");
            float verAxis = Input.GetAxis("Vertical");
            // Debug.Log("Player is local, horizontal input is " + horAxis + ", vertical input is " + verAxis);
            if (horAxis != 0) {
                float horSign = horAxis > 0 ? 1 : -1;
                this.transform.Translate(horSign * Vector3.right * Time.deltaTime * 3f);
            }
            if (verAxis != 0) {
                float verSign = verAxis > 0 ? 1 : -1;
                this.transform.Translate(verSign * Vector3.forward * Time.deltaTime * 3f);
            }
        }
        */

        if (isLocalPlayer) {
            if(descending) {
                this.transform.Translate(-Vector3.up * Time.deltaTime * upDownSpeed);
            } else if(ascending) {
                this.transform.Translate(Vector3.up * Time.deltaTime * upDownSpeed);
            }
        }
    }
}
