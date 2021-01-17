using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public Text textScore;
    int score;
    public static Collect instance;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        textScore.text = score.ToString();
    }

}
