using UnityEngine;

public class CarObstacle : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
