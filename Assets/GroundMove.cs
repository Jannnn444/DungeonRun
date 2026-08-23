using UnityEngine;

public class GroundMove : MonoBehaviour
{
    public static float speed = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0f, 0f);

        if (transform.position.x < -25f)
        {
            Destroy(gameObject);
        }
    }
}
