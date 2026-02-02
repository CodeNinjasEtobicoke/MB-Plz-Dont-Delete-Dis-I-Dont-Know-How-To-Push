using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particles : MonoBehaviour
{
    public ParticleSystem hitParticles;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            hitParticles.Play();
        }
    }

    // Update is called once per frame
    void Start()
    {
        hitParticles.Pause();

    }
}