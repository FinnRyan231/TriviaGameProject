using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class finalQOne : MonoBehaviour
{
    public GameObject wrongAnswer;
    public GameObject correctAnswer;
    public GameObject tennaTV;
    public GameObject questionNumber;
    

    // [SerializeField]
    // private TMP_Text pointsText;
    // int points;
    // PointsSystem pointsSystem;

void Start()
    {
        // pointsSystem = FindObjectOfType<PointsSystem>();
        // points = pointsSystem.CurrentPoints;
        // pointsText.text = points + "";
    }


void finalQuestion()
    {
        SceneManager.LoadScene(2);
    }

private void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.gameObject.tag == "Player")
    {
        Invoke("finalQuestion", 1);
        
        if(gameObject.tag == "Correct")
            {
                Debug.Log("yay");
                AudioManager.Instance.PlaySFX(AudioManager.Instance.correctSFX);
                tennaTV.SetActive(false);
                questionNumber.SetActive(false);
                correctAnswer.SetActive(true);

                // points += 100;
                // pointsText.text = points + "";
                // pointsSystem.SetPoint(points);
            }
            else if(gameObject.tag == "Incorrect")
            {
                Debug.Log("boo");
                AudioManager.Instance.PlaySFX(AudioManager.Instance.incorrectSFX);
                tennaTV.SetActive(false);
                questionNumber.SetActive(false);
                wrongAnswer.SetActive(true);
            }
    }
}


}