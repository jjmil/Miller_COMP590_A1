using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class MovingTarget : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public Camera Player;
    private int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ScoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        transform.localPosition = new Vector3(Random.Range(1, 10), Random.Range(1, 10), Random.Range(1, 10));
        //transform.LookAt(Player.transform);
        score += 10;
        ScoreText.text = "Score: " + score;
    }
}
