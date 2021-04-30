using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreRecorder : MonoBehaviour
{
    private GameObject scoreText;
    private int score=0;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreRecord");
    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.GetComponent<Text>().text = "Score:" + this.score;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.score += 5;
        }else if ((other.gameObject.tag == "LargeStarTag") || (other.gameObject.tag == "SmallCloudTag"))
        {
            this.score += 10;
        }else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 20;
        }
    }
}
