using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    //[SerializeField] private float force = 1f;
    [SerializeField] private float force;

    [SerializeField] private InputManager inputManager;

    private Rigidbody ballRB;
    private bool isBallLaunched;


    // updated
    [SerializeField] private Transform ballAnchor; // ���ص�

    // updated
    [SerializeField] private Transform launchIndicator;



    void Start()
    {
        // get the reference for the balls
        ballRB = GetComponent<Rigidbody>();
        

        // add listener for the OnSpacePressed
        inputManager.OnSpacePressed.AddListener(LaunchBall);

        // �� Ball ����Ϸ��ʼʱ���ص� `BallAnchor`
        transform.parent = ballAnchor;
        transform.localPosition = Vector3.zero;
        ballRB.isKinematic = true; // ����������Ӱ��


        inputManager.OnResetPressed.AddListener(ResetBall);
        //ResetBall();
    }

    private void LaunchBall()
    {
        if (isBallLaunched) return;

        ballRB.isKinematic = false; // ����������Ӱ��
        isBallLaunched = true;
        transform.parent = null;
        //ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
        ballRB.AddForce(launchIndicator.forward * force, ForceMode.Impulse);

        launchIndicator.gameObject.SetActive(false);
    }

    public void ResetBall()
    {

        isBallLaunched = false;
        ballRB.isKinematic = true;
        ballRB.linearVelocity = Vector3.zero;
        ballRB.angularVelocity = Vector3.zero;
        transform.parent = ballAnchor;
        transform.localPosition = Vector3.zero;
        launchIndicator.gameObject.SetActive(true); // ������ʾͶ������ָʾ��

        // Console
        Debug.Log("Reset the ball");
    }
}
