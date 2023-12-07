using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PEffect : MonoBehaviour
{
    public ParticleSystem collisionParticle; 

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Player"))
        {
            
            Instantiate(collisionParticle, collision.contacts[0].point, Quaternion.identity);

           
             //collisionParticle.Play();
            Debug.Log("Collison");
            
        }
    }
}
