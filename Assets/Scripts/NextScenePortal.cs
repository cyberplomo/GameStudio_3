using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Sahne y�netimi i�in gerekli


public class NextScenePortal : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        SonrakiSahneyeGec();
     }

    void SonrakiSahneyeGec()
    {
        // �uanki sahnenin indeksini al
        int suankiSahneIndex = SceneManager.GetActiveScene().buildIndex;

        // Bir sonraki sahnenin indeksini hesapla
        int sonrakiSahneIndex = suankiSahneIndex + 1;

        // E�er bir sonraki sahne mevcutsa, o sahneye ge�
        if (sonrakiSahneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(sonrakiSahneIndex);
        }
    }
}
