using UnityEngine;

public class CloudScript : MonoBehaviour
{
    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime);
        if(transform.position.x< -10)
        {
            transform.position = startPosition +
                Vector3.down * Random.Range(0f, 1f);
        }
    }
}
