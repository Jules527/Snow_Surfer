using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float restartDelay = 1f;
    void OnTriggerEnter2D(Collider2D collision)
    {
       
        int playerLayerIndex = LayerMask.NameToLayer("Player");

   
        if (collision.gameObject.layer == playerLayerIndex)
        {
           
            Invoke("ReloadScene", restartDelay);
        }
    }

    
    void ReloadScene()
    {
        
        SceneManager.LoadScene(0);
    }
}
