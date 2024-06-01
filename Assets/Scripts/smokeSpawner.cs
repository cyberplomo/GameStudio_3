using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokeSpawner : MonoBehaviour
{
    public GameObject smokePrefab; // Olu�turulacak duman prefab�
    public Transform spawnPoint; // Spawn noktas�

    public float spawnInterval = 2.0f; // Olu�turma aral���

    public float timer = 0.0f;

    void Update()
    {
        // Timer'� g�ncelle ve spawn aral���n� kontrol et
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            // Timer s�f�rla
            timer = 0.0f;

            // Duman prefab�n� belirtilen spawn noktas�ndan olu�tur
            Instantiate(smokePrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}
