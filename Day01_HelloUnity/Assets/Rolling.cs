using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolling : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
            transform.Rotate(Vector3.right * 5f);
        if (Input.GetKey(KeyCode.S))
            transform.Rotate(-Vector3.right * 5f);
    }
}
