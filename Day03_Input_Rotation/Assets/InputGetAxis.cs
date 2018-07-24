using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputGetAxis : MonoBehaviour {
    public float speed = 10f;
    public float rotationSpeed = 120f;

	void Update () {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        //print("v: " + Input.GetAxis("Vertical"));

        //or transform.Translate(0, 0, v * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * v * speed * Time.deltaTime);
        
        // or transform.Rotate(0, h * rotationSpeed * Time.deltaTime, 0);
        // or transform.Rotate(Vector3.up, h * rotationSpeed * Time.deltaTime);
        transform.rotation *= Quaternion.AngleAxis(h * rotationSpeed * Time.deltaTime, Vector3.up);

    }
}
