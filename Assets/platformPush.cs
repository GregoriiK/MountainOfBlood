using UnityEngine;

public class platformPush : MonoBehaviour
{
    Vector3 startPos;
    Vector3 endPos;
    Rigidbody rb;
    [SerializeField] float moveRange;
    [SerializeField] float speed;
    void Start()
    {
        startPos = transform.position;
        endPos = new Vector3(startPos.x + moveRange,startPos.y,startPos.z);
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(1000 * speed, 0, 0);
    }

    void Update()
    {
        if(transform.position.x >= endPos.x)
        {
            gameObject.SetActive(false);
            transform.position = startPos;
            gameObject.SetActive(true);
            //rb.AddRelativeForce(1 * speed, 0, 0);
        }
    }
}
