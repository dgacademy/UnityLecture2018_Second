﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pingpong : MonoBehaviour {
    public float speed = 5.0f;
    public float dir = 1f;

	void Update () {
        float x = transform.position.x;
        float y = transform.position.y;

        if (x > 5f)
            dir = -1f;
        if (x < 0f)
            dir = 1f;
        transform.Translate(dir * speed * Time.deltaTime, 0f, 0f);
    }
}
