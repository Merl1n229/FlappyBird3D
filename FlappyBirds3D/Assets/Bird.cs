using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Bird : MonoBehaviour
{
    public float speed = 5f;
    public float gravity = -9.8f;
    public float jumpForce = 10f;
    public TMP_Text scoreText;
    public int score = 0;

    public Rigidbody rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        // Движение вперед
        transform.position += transform.right * speed * Time.deltaTime;

        // Гравитация
        Vector3 gravityVector = new Vector3(0f, gravity, 0f);
        rb.AddForce(gravityVector, ForceMode.Acceleration);

        // Проверка на нажатие левой кнопки мыши для прыжка
        if (Input.GetMouseButton(0))
        {
            Jump();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Score");
        if (other.CompareTag("box"))
        {
            Debug.Log("Score");
            // Увеличиваем количество очков
            score += 100;

            // Обновляем отображение очков на экране
            UpdateScoreText();
        }
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void UpdateScoreText()
    {
        // Обновляем текст с количеством очков
        scoreText.text = "Score: " + score.ToString();
    }
}





