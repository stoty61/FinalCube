using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TMP_Text scoreText;
    float startingPosition = 0;

    void Start()
    {
        startingPosition = player.position.z;
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + ((player.position.z - startingPosition)/10).ToString("0");
    }
}
