using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour {
    public Transform dest;
    public float speed;
    //public GameObject destObject;

    public List<Transform> waypoints;

	void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, dest.position, step);
        //transform.position = Vector3.MoveTowards(transform.position, destObject.transform.position, 0.1f);
        //transform.position = Vector3.MoveTowards(transform.position, destObject.GetComponent<Transform>().position, 0.1f);
    }
}
