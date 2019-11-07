﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float velocity = 0;
    [SerializeField] private GameObject focalPoint = null;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Fixed Update is called in fixed intervals (do physics manipulation here!)
    void FixedUpdate()
    {
        if (focalPoint)
        {
            rb.AddForce(focalPoint.transform.forward * velocity * Time.deltaTime);
        }
    }
}
