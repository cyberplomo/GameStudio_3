using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokeAnim : MonoBehaviour
{
    public float growthSpeed = 0.5f; // B�y�me h�z�
    public float upwardSpeed = 0.1f; // Yukar� hareket h�z�
    public float destroyHeight = 3.0f;

    private Vector3 originalScale; // Ba�lang�� �l�e�i
    private float originalY; // Ba�lang�� y�ksekli�i

    void Start()
    {
        // Ba�lang�� �l�e�i ve y�ksekli�ini saklay�n
        originalScale = transform.localScale;
        originalY = transform.position.y;
    }

    void Update()
    {
        // �l�e�i ve y�ksekli�i zamanla artt�r�n
        transform.localScale += originalScale * growthSpeed * Time.deltaTime;
        transform.position += Vector3.up * upwardSpeed * Time.deltaTime;

        // E�er y�kseklik �ok fazla artarsa objeyi yok edin
        if (transform.position.y - originalY >= destroyHeight)
        {
            Destroy(gameObject);
        }
    }
}
