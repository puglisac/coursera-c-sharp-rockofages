﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // apply impulse force to get game object moving
        const float MinImpulseForce = 1f;
        const float MaxImpulseForce = 2f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);
    }
    void Update()
    {

    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}