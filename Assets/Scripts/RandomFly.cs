using UnityEngine;

public class RandomFlight : MonoBehaviour
{
    public float speed = 5f;
    public float changeInterval = 2f;
    public int objectLayer = 0; // ����� ��� ��� ��'����

    private Vector3 targetPosition;
    private float timer;

    void Start()
    {
        SetRandomTarget();

        // ������������ ����� ��� ��� ��'����
        gameObject.layer = objectLayer;
    }

    void Update()
    {
        // ��� ��'���� �� ���
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // ��������, �� ��������� ���
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            SetRandomTarget();
        }

        // ������ ��� ���� ��� ����� ������ ��������
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            SetRandomTarget();
            timer = changeInterval;
        }
    }

    void SetRandomTarget()
    {
        // �������� ��������� ������� � ����� ������ (-10, -10, -10) �� (10, 10, 10)
        targetPosition = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f));
    }
}

/*using UnityEngine;

public class CoolTrajectory : MonoBehaviour
{
    public float amplitude = 1f;  // �������� �������
    public float frequency = 1f;  // ������� �������

    private Vector3 initialPosition;

    void Start()
    {
        // �����'������� ��������� ������� ��'����
        initialPosition = transform.position;
    }

    void Update()
    {
        // ������� �� �������� ������ �������
        float yOffset = amplitude * Mathf.Sin(Time.time * frequency);

        // ��������� ������� ��'����
        transform.position = initialPosition + new Vector3(0f, yOffset, 0f);
    }
}*/

/*using UnityEngine;

public class BouncingObject : MonoBehaviour
{
    public float jumpForce = 5f;
    public float respawnX = -10f; // ���������� X ��� ���������� ��'����
    public float respawnY = 0f;   // ���������� Y ��� ���������� ��'����

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // ��������, �� ��'��� ������ �� ���� ����
        if (transform.position.x > Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0)).x)
        {
            // ���� ��'��� ������ �� ���� ����, ���������� ���� �� ��������� �������
            transform.position = new Vector3(respawnX, respawnY, transform.position.z);
        }
    }

    void FixedUpdate()
    {
        // ���������� ������
        rb.velocity = new Vector2(jumpForce, rb.velocity.y);
    }
}

*/