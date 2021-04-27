using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public ParticleSystem particle;
   public  void OnTriggerEnter(Collider other)
    {
        particle.Play();
        Destroy(particle.gameObject, particle.main.duration);
        Destroy(gameObject);

        GameObject scoreTextGo = GameObject.Find("scoreText");
        
        scoreTextGo.SendMessage("OnScore", 1);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
