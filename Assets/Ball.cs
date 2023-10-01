using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    int enemyScore = 0;
    int playerScore = 0;

    public TextMeshPro PlayerScore;

    public TextMeshPro EnemyScore;

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("GoalEnemy"))
        {
            playerScore += 1;
            PlayerScore.text = playerScore.ToString();
            transform.position = Vector3.zero;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (collision.gameObject.name.Contains("GoalPlayer"))
        {
            enemyScore += 1;
            EnemyScore.text = enemyScore.ToString();
            transform.position = Vector3.zero;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}