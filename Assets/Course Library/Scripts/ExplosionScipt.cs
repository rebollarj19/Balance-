using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScipt : MonoBehaviour
{
    public GameObject explosionAll;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Explode();
        }
    }
    void Explode()
    {
        GameObject firework = Instantiate(explosionAll, new Vector3(0, 0, 0), Quaternion.identity);
        firework.GetComponent<ParticleSystem>().Play();
    }

}
