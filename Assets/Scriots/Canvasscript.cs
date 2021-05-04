using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvasscript : MonoBehaviour
{
    public GameObject Panel;

    public ParticleSystem particle;
    public Text lastscoretext;
    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
    }
   public void OnEnter()
    {
        Panel.SetActive(true);
        particle.Play();

        int nowScore = PlayerPrefs.GetInt("Score", 0);
        lastscoretext.text = nowScore.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
