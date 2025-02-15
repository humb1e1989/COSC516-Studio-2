using UnityEngine;
using Unity.Cinemachine;

public class LaunchIndicator : MonoBehaviour
{
    [SerializeField] private CinemachineCamera freeLookCamera;

    void Update()
    {
        // 让箭头指向摄像机的前方向
        transform.forward = freeLookCamera.transform.forward;

        // 仅旋转 Y 轴，确保箭头不会向上或向下倾斜
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
    }
}
