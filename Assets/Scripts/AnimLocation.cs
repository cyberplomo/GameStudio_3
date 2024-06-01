using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimLocation : MonoBehaviour
{
    private Vector3 originalPosition;
    public float upwardSpeed = 1.0f;  // Yukar� hareket h�z�
    public float maxY = 5.0f; // Maksimum y eksen de�eri
    private float returnSpeed = 2.0f; // Geri d�n�� h�z�

    void Start()
    {
        // Objeyi ba�lang�� pozisyonunda saklay�n
        originalPosition = transform.position;
    }

    void LateUpdate()
    {
        // Yukar� y�nde hareket etmesini sa�lay�n
        transform.Translate(Vector3.up * upwardSpeed * Time.deltaTime);

        // E�er y ekseninde maksimum de�ere ula��ld�ysa ba�lang�� noktas�na geri d�n
        if (transform.position.y >= maxY)
        {
            // Ba�lang�� noktas�na geri d�nme i�lemi
            float step = returnSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, originalPosition, step);
        }
    }
}
