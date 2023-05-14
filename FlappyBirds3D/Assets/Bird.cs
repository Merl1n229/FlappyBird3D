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
        // �������� ������
        transform.position += transform.right * speed * Time.deltaTime;

        // ����������
        Vector3 gravityVector = new Vector3(0f, gravity, 0f);
        rb.AddForce(gravityVector, ForceMode.Acceleration);

        // �������� �� ������� ����� ������ ���� ��� ������
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
            // ����������� ���������� �����
            score += 100;

            // ��������� ����������� ����� �� ������
            UpdateScoreText();
        }
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void UpdateScoreText()
    {
        // ��������� ����� � ����������� �����
        scoreText.text = "Score: " + score.ToString();
    }
}





