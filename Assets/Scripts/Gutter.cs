//using UnityEngine;

//public class Gutter : MonoBehaviour
//{
//    [SerializeField] private Vector3 exitDirection = Vector3.up; // Ĭ���� Y ��������

//    private void OnTriggerEnter(Collider triggeredBody)
//    {
//        // ȷ��ֻ�� "Ball" ����
//        if (!triggeredBody.CompareTag("Ball"))
//        {
//            Debug.Log("Not a ball");
//            return;
//        }

//        // ��ȡ��� Rigidbody
//        Rigidbody ballRB = triggeredBody.GetComponent<Rigidbody>();

//        if (ballRB == null)
//        {
//            Debug.Log("Cannot fetch the Ball Rigidbody");
//            return;
//        }

//        Debug.Log("Fetch the Rigidbody of the Ball");

//        // ��¼���ԭʼ�ٶȴ�С��ȷ����Сֵ�����С
//        float velocityMagnitude = Mathf.Max(ballRB.linearVelocity.magnitude, 5f);

//        // ֹͣ��ĵ�ǰ�˶�
//        ballRB.linearVelocity = Vector3.zero;
//        ballRB.angularVelocity = Vector3.zero;

//        // ��������ȷ�������ϻ���
//        ballRB.AddForce(transform.up * velocityMagnitude, ForceMode.VelocityChange);

//        Debug.Log("Ball has entered the gutter and is being moved.");
//        Debug.Log("The ball's new velocity: " + ballRB.linearVelocity);
//    }
//}


using UnityEngine;

public class Gutter : MonoBehaviour
{
    [SerializeField] private Vector3 exitDirection = Vector3.up; // 默认 Y 轴方向

    private void OnTriggerEnter(Collider triggeredBody)
    {
        // 确保只有 "Ball" 触发 Gutter 逻辑
        if (!triggeredBody.CompareTag("Ball"))
        {
            Debug.Log("Not a ball");
            return;
        }

        Debug.Log("Ball has entered the gutter.");

        // 获取球的 Rigidbody 组件
        Rigidbody ballRB = triggeredBody.GetComponent<Rigidbody>();

        if (ballRB == null)
        {
            Debug.LogError("Cannot fetch the Ball Rigidbody");
            return;
        }

        Debug.Log("Fetched the Rigidbody of the Ball");

        // 记录球的原始速度大小
        float velocityMagnitude = Mathf.Max(ballRB.linearVelocity.magnitude, 5f);

        // 确保球不会受物理误差影响
        ballRB.isKinematic = true;
        ballRB.linearVelocity = Vector3.zero;
        ballRB.angularVelocity = Vector3.zero;
        ballRB.isKinematic = false;

        // 让球沿 Gutter 方向滑出
        ballRB.AddForce(transform.up * velocityMagnitude, ForceMode.Impulse);

        Debug.Log("Ball is moving inside the gutter.");
        Debug.Log("The ball's new velocity: " + ballRB.linearVelocity);
    }
}
