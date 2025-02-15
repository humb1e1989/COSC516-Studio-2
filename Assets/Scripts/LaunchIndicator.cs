using UnityEngine;
using Unity.Cinemachine;

public class LaunchIndicator : MonoBehaviour
{
    [SerializeField] private CinemachineCamera freeLookCamera;

    void Update()
    {
        // �ü�ͷָ���������ǰ����
        transform.forward = freeLookCamera.transform.forward;

        // ����ת Y �ᣬȷ����ͷ�������ϻ�������б
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
    }
}
