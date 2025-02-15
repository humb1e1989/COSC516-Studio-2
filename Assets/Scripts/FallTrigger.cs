using UnityEngine;
using UnityEngine.Events;

public class FallTrigger : MonoBehaviour
{
    public UnityEvent OnPinFall = new UnityEvent();
    private bool isPinFallen = false; // 防止重复触发

    private void OnTriggerEnter(Collider other)
    {
        // 确保只在 `Pin` 碰到 `Ground` 时触发
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
