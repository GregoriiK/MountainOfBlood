using UnityEngine;

public class PlatformRemover : MonoBehaviour
{
    float timer = 3f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (rb.useGravity)
        {
            timer -= Time.deltaTime;
            if (timer < 0) Destroy(gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            rb.useGravity = true;
            timer = 3f;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        timer = 3f;
    }


}
