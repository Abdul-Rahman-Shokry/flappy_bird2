using UnityEngine;

public class pipes : MonoBehaviour
{
    public float speed =5f;

    public float leftEdge;
    void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if(transform.position.x<leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
