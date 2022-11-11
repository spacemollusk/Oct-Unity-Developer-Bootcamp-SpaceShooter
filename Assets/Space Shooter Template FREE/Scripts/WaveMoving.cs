using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMoving : MonoBehaviour
{
    [SerializeField]
    private float speed = 15;
    [SerializeField]
    private float frequency = 12;
    [SerializeField]
    private float amplitude = 6;

    
    void Update()
    {
        var horizontalFactor = Mathf.Sin(Time.time * frequency) * amplitude;
        var movement = (Vector3.up * speed + Vector3.right * horizontalFactor) * Time.deltaTime;
        transform.Translate(movement);
    }
}
