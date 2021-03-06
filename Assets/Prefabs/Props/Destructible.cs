﻿using UnityEngine;
using System.Collections;

public class Destructible : MonoBehaviour {
    void OnMouseDown()
    {
        explode();
    }

    public void explode()
    {
        foreach (Transform child in transform)
        {
            Rigidbody rb = child.GetComponent<Rigidbody>();
            rb.isKinematic = false;
        }
    }
}
