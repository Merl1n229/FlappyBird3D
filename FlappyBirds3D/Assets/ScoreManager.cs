using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // ������ �� ��������� ������ ��� ����������� �����
    private int score = 0; // ������� ���������� �����

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // ����������� ���������� �����
            score += 100;

            // ��������� ����������� ����� �� ������
            UpdateScoreText();
        }
    }

    private void UpdateScoreText()
    {
        // ��������� ����� � ����������� �����
        scoreText.text = "Score: " + score.ToString();
    }
}