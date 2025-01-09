using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime);
        if (transform.position.x < -10)
        {
            transform.position = startPosition + Vector3.down * Random.Range(0f, 1f);
        }
    }
}