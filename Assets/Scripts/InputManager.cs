using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent OnSpacePressed = new UnityEvent();

    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    //public UnityEvent OnSpacePressed = new UnityEvent();

    public UnityEvent OnResetPressed = new UnityEvent();



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("The Space is pressed");
            OnSpacePressed?.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke();
        }

        Vector2 input = Vector2.zero;
        if (Input.GetKey(KeyCode.A)) input += Vector2.left;
        if (Input.GetKey(KeyCode.D)) input += Vector2.right;

        OnMove?.Invoke(input);

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Reset key pressed!"); // 确保 R 键检测正常
            OnResetPressed?.Invoke();
        }

    }
}
