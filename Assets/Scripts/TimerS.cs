using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerS : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField]float remainingTime;

    // Update is called once per frame
    void Update()
    {
        remainingTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{00}", seconds);


        if (remainingTime <= 1f)
        {
            //Debug.Log("Times Up!   Times Up!");
            SceneManager.LoadScene(2);
        }
    }
}
