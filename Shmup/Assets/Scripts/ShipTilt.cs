using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * @Author: Katherine Rosell
 * 2/25/2020
 * This class tilts the ship when the player moves 
 * up or down. Instead of using an animation, this class
 * rotates the player in the +/- z-axis.
 * */


public class ShipTilt : MonoBehaviour {

    Rigidbody shipRB;
    float currZ;
    float tiltSpeed;

	// Use this for initialization
	void Start () {
        shipRB = GetComponent<Rigidbody>();
        currZ = shipRB.transform.rotation.z;
        tiltSpeed = 50f;
    }
	
	// Update is called once per frame
	void Update () {


        currZ = shipRB.transform.rotation.z;//get ship's z rotation 
        //player is moving UP, +z rotation to MAX +25
        if (Input.GetKey(KeyCode.W) && currZ <= 0.15f){
            if (0.14f <= currZ && currZ <= 0.16f) {
                shipRB.transform.Rotate(0f, 0f, 0.15f);
            }
            else {
                shipRB.transform.Rotate(0f, 0f, tiltSpeed * Time.deltaTime);//keep adding to z rotaion
                }
        }
        else if (Input.GetKey(KeyCode.S) && currZ >= -0.17f) {
            if (0.15f < currZ && currZ <= 0.19f) {
                shipRB.transform.Rotate(0f, 0f, 0.18f);
            }
            else {
                shipRB.transform.Rotate(0f, 0f, -tiltSpeed * Time.deltaTime);//keep adding to z rotaion
            }
                
        } 
        else RegressZ();

        //Debug.Log(currZ);

	}

    private void RegressZ() {
        if (currZ > 0.01f) { //positive z rotation, bring back down to 0
            shipRB.transform.Rotate(0f, 0f, (-tiltSpeed + 0.2f) * Time.deltaTime);//keep adding to z rotaion
        }
        if (currZ < -0.01) {
            shipRB.transform.Rotate(0f, 0f, (tiltSpeed + 0.2f) * Time.deltaTime);//keep adding to z rotaion
        }
    }


}
