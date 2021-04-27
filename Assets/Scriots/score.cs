using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    int Score = 0;
    // Start is called before the first frame update
    public void OnScore (int num)
    {
        Score += num;

        Text scoreText = gameObject.GetComponent<Text>();

        scoreText.text = Score.ToString();
        PlayerPrefs.SetInt("Score", Score);
        PlayerPrefs.Save();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
