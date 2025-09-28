using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Camera firstPersonCamera;
    [SerializeField] private Camera thirdPersonCamera;

    private bool isThirdCameraView = true;

    void Start()
    {
        ApplyView(); // đặt trạng thái ban đầu
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isThirdCameraView = !isThirdCameraView;
            ApplyView(); // áp dụng ngay khi bấm E
        }
    }

    private void ApplyView()
    {
        firstPersonCamera.gameObject.SetActive(!isThirdCameraView);
        thirdPersonCamera.gameObject.SetActive(isThirdCameraView);
    }

}
