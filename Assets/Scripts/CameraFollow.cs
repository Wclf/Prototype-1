using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -20);

    // Update is called once per frame

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;

    }
}
