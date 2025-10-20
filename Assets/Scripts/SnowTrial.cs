using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] ParticleSystem snowParticles;

    void OnCollisionEnter2D(Collision2D collision)
    {
        int floorLayerIndex = LayerMask.NameToLayer("Floor");


        if (collision.gameObject.layer == floorLayerIndex)
        { 
        snowParticles.Play();
        }

            
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        int floorLayerIndex = LayerMask.NameToLayer("Floor");


        if (collision.gameObject.layer == floorLayerIndex)
        {
            snowParticles.Stop();
        }
    }
}




