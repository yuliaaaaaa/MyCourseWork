using UnityEngine;

public class Pawner : MonoBehaviour
{
    public float max_time = 1;
    private float timer = 0;
    public GameObject obj;
    public float XMove = 1;
    public float DestroySec = 15;

    void Update()
    {
        if (timer > max_time)
        {
            GameObject new_obj = Instantiate(obj);
            new_obj.transform.position = transform.position + new Vector3(XMove, 0, 0);
            Destroy(new_obj, DestroySec);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}