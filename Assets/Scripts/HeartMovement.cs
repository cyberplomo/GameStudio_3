using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartMovement : MonoBehaviour
{
    public float floatSpeed = 1.0f; // Objenin yukar� a�a�� hareket h�z�n� kontrol eder
    public float floatAmplitude = 0.5f; // Objenin yukar� a�a�� hareket geni�li�ini kontrol eder
    public float rotationSpeed = 30.0f; // Objenin z ekseninde d�nd�rme h�z�n� kontrol eder

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position; // Objenin ba�lang�� pozisyonunu kaydet
    }

    void Update()
    {
        // Yukar� ve a�a�� hareket
        float newY = initialPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatAmplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        // Z ekseninde d�nd�rme
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
