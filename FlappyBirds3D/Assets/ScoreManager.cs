using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Ссылка на компонент текста для отображения очков
    private int score = 0; // Текущее количество очков

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Увеличиваем количество очков
            score += 100;

            // Обновляем отображение очков на экране
            UpdateScoreText();
        }
    }

    private void UpdateScoreText()
    {
        // Обновляем текст с количеством очков
        scoreText.text = "Score: " + score.ToString();
    }
}