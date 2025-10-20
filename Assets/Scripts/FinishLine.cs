using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float restartDelay = 1f;
    [SerializeField] ParticleSystem finishParticles;

    void OnTriggerEnter2D(Collider2D collision)
    {
       
        int playerLayerIndex = LayerMask.NameToLayer("Player");

   
        if (collision.gameObject.layer == playerLayerIndex)
        {
            finishParticles.Play();
            Invoke("ReloadScene", restartDelay);
        }
    }

    
    void ReloadScene()
    {
        
        SceneManager.LoadScene(0);
    }
}
