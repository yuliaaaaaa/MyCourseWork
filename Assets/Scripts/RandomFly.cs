using UnityEngine;

public class RandomFlight : MonoBehaviour
{
    public float speed = 5f;
    public float changeInterval = 2f;
    public int objectLayer = 0; // Новий шар для об'єкта

    private Vector3 targetPosition;
    private float timer;

    void Start()
    {
        SetRandomTarget();

        // Встановлюємо новий шар для об'єкта
        gameObject.layer = objectLayer;
    }

    void Update()
    {
        // Рух об'єкту до цілі
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Перевірка, чи досягнуто цілі
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            SetRandomTarget();
        }

        // Таймер для зміни цілі через певний інтервал
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            SetRandomTarget();
            timer = changeInterval;
        }
    }

    void SetRandomTarget()
    {
        // Генеруємо випадкову позицію в межах області (-10, -10, -10) до (10, 10, 10)
        targetPosition = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f));
    }
}

/*using UnityEngine;

public class CoolTrajectory : MonoBehaviour
{
    public float amplitude = 1f;  // Амплітуда траєкторії
    public float frequency = 1f;  // Частота траєкторії

    private Vector3 initialPosition;

    void Start()
    {
        // Запам'ятовуємо початкову позицію об'єкту
        initialPosition = transform.position;
    }

    void Update()
    {
        // Зміщення по вертикалі вздовж траєкторії
        float yOffset = amplitude * Mathf.Sin(Time.time * frequency);

        // Оновлення позиції об'єкту
        transform.position = initialPosition + new Vector3(0f, yOffset, 0f);
    }
}*/

/*using UnityEngine;

public class BouncingObject : MonoBehaviour
{
    public float jumpForce = 5f;
    public float respawnX = -10f; // Координата X для відновлення об'єкта
    public float respawnY = 0f;   // Координата Y для відновлення об'єкта

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Перевірка, чи об'єкт вийшов за поле зору
        if (transform.position.x > Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0)).x)
        {
            // Якщо об'єкт вийшов за поле зору, відновлюємо його на початковій позиції
            transform.position = new Vector3(respawnX, respawnY, transform.position.z);
        }
    }

    void FixedUpdate()
    {
        // Пригавання вправо
        rb.velocity = new Vector2(jumpForce, rb.velocity.y);
    }
}

*/