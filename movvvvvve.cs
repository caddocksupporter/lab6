using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movvvvvve : MonoBehaviour
{
    private float dz = 0.5f;
    private float dx = 0.2f;
    private float speed = 0.6f;
    float mouseX = Input.GetAxis("Mouse X");
    float mouseY = Input.GetAxis("Mouse Y");

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * dz * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * dx * speed * Time.deltaTime);
        transform.Translate(Vector3.right * mouseX * speed * Time.deltaTime);
        transform.Translate(Vector3.up * mouseY * speed * Time.deltaTime);
    }
}
