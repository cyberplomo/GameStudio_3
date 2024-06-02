using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EndPortalAudio : MonoBehaviour
{
    private AudioSource audioSource;

    void Awake()
    {
        // AudioSource bile�enini al
        audioSource = GetComponent<AudioSource>();
    }

    void OnEnable()
    {
        // Obje etkinle�tirildi�inde AudioSource'un �almas�n� sa�la
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            UnityEngine.Debug.LogWarning("AudioSource bile�eni bulunamad�!");
        }
    }
}
