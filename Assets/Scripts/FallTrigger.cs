using UnityEngine;
using UnityEngine.Events;

public class FallTrigger : MonoBehaviour
{
    public UnityEvent OnPinFall = new UnityEvent();
    private bool isPinFallen = false; // ��ֹ�ظ�����

    private void OnTriggerEnter(Collider other)
    {
        // ȷ��ֻ�� `Pin` ���� `Ground` ʱ����
        if (other.CompareTag("Ground") && !isPinFallen)
        {
            isPinFallen = true;
            OnPinFall.Invoke();

            //Debug.Log("The method has been invoke");

            //OnPinFall?.Invoke();
            Debug.Log(transform.parent.name + " has fallen!");
        }
    }
}
