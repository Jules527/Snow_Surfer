using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField]
    float restartDelay;

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        int floorLayerIndex = LayerMask.NameToLayer("Floor");

        
        if (collision.gameObject.layer == floorLayerIndex)
        {
            Invoke("ReloadScene", restartDelay);
        }
    }

    void ReloadScene()
    {
       SceneManager.LoadScene(0);
    }

}
