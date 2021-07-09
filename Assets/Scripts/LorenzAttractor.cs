using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LorenzAttractor : MonoBehaviour
{
    [SerializeField]
    float x = 0.01f;

    [SerializeField]
    float y = 0; 

    [SerializeField]
    float z = 0;

    [SerializeField]
    float a = 10;

    [SerializeField]
    float b = 28;

    [SerializeField]
    float c = 2.666667f;

    [SerializeField]
    private GameObject target;

    void Update()
    {
        float dt = 0.01f;
        float dx = (a * (y - x)) * dt;
        float dy = (x * (b - z) - y) * dt;
        float dz = (x * y - c * z) * dt;

        x += dx;
        y += dy;
        z += dz;

        target.transform.position = new Vector3(x, y, z);
    }
}
