using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;



    


T FindFirstObjectByType<T>()
    {
        throw new NotImplementedException();
    }

    static void OnTriggerEnter2D(Collider2D collision,
        float restartDelay,
        ParticleSystem crashParticles,
        PlayerController playerController)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");

        if (collision.gameObject.layer == layerIndex)
        {
            playerController.DisableControls();
            crashParticles.Play();
            object value = Invoke("ReloadScene", restartDelay);
        }
        static object Invoke(string v, float restartDelay)
        {
            throw new NotImplementedException();
        }
    }
}