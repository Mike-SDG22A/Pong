using Mono.Cecil.Cil;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public ParticleSystem collisionParticleSystem;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var em = collisionParticleSystem.emission;

        if (collision.gameObject.CompareTag("Paddle")) 
        {
            em.enabled = true;
            collisionParticleSystem.Play();

        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            em.enabled = true;
            collisionParticleSystem.Play();
        }
    }
}