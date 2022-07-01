using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    [SerializeField] GameObject GameOverMenu;
    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI ScoreText;
    [SerializeField] private AudioSource point_collect;
    [SerializeField] private AudioSource Obstacle_collision;

    private void awake()
    {
        score = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Point"))
        {
            point_collect.Play();
            score = score + 5;
            ScoreText.text = score.ToString();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Obstacle_collision.Play();
            GameOverMenu.SetActive(true);
            Time.timeScale = 0f;
        }

        
    }
}
