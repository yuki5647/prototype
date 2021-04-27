using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalscropt : MonoBehaviour {

    public ParticleSystem particle;
    public GameObject crearCanvas;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "balltag")
        {
            crearCanvas.SendMessage("OnEnter");
            particle.Play();

            Destroy(particle.gameObject, particle.main.duration);

            Destroy(this.gameObject);
            
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
