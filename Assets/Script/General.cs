using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class General : MonoBehaviour
{

    private float scoreCount = 1f;
    private float pointSecond = 5f;
    public Text scoreText;



    // Update is called once per frame
    void Update()
    {
        scoreCount += pointSecond * Time.deltaTime;
        scoreText.text = (int)scoreCount + " km";

    }
}
