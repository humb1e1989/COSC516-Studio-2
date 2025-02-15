using UnityEngine;
using TMPro; // 引入 TextMeshPro 命名空间

public class GameManager : MonoBehaviour
{
    [SerializeField] private int score = 0;
    public FallTrigger[] pins;


    [SerializeField] private TextMeshProUGUI scoreText; // 连接 Score UI

    // updated
    [SerializeField] private BallController ball;
    public GameObject pinCollection; // `Pins` 的父对象
    //[SerializeField] public GameObject pinPrefab; // `Pins` 的父对象
    [SerializeField] private Transform pinAnchor;  // `Pins` 复位位置
    [SerializeField] private InputManager inputManager;

    private GameObject[] pinObjects; // 存储 `PinCollection` 里的 `Pins`

    private Vector3[] pinOriginalPositions; // 存储 `Pins` 初始位置
    private Quaternion[] pinOriginalRotations; // 存储 `Pins` 初始旋转


    private void Start()
    {
        //// 获取所有 `Pin` 的 `FallTrigger` 组件
        //pins = FindObjectsOfType<FallTrigger>();

        //// 监听每个 `Pin` 的 `OnPinFall` 事件
        //foreach (FallTrigger pin in pins)
        //{
        //    pin.OnPinFall.AddListener(IncrementScore);
        //}

        RegisterPins();

        //inputManager.OnResetPressed.AddListener(HandleReset);
        inputManager.OnResetPressed.AddListener(ResetGame);

        StoreInitialPinPositions();
    }

    private void RegisterPins()
    {
        // 获取所有 `Pin` 的 `FallTrigger` 组件
        pins = FindObjectsOfType<FallTrigger>();

        // 监听每个 `Pin` 的 `OnPinFall` 事件
        foreach (FallTrigger pin in pins)
        {
            pin.OnPinFall.AddListener(IncrementScore);
        }
    }

    private void IncrementScore()
    {
        score++;
        Debug.Log("Score: " + score);
        UpdateScoreUI();
    }

    // update TMP UI
    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }


    //private void HandleReset()
    //{
    //    // excute the ball reset
    //    ball.ResetBall();
    //    SetPins();
    //}



    public void ResetGame()
    {
        Debug.Log("Game is resetting...");

        // 1️⃣ 让 Ball 回到初始位置
        ball.ResetBall();


        //// 2️⃣ 让 `PinCollection` 直接复位
        //if (pinCollection != null)
        //{
        //    pinCollection.transform.position = pinAnchor.position;
        //    pinCollection.transform.rotation = Quaternion.identity;
        //}

        // 2️⃣ 删除所有已倒下的 Pins
        if (pinCollection != null)
        {
            Destroy(pinCollection);
            Debug.Log("Destroy the pin collection");
        }

        // 3️⃣ 生成新的 Pins
        pinCollection = Instantiate(pinCollection, pinAnchor.position, Quaternion.identity);

        // 获取 `PinCollection` 下的所有 `Pins` 并存入 `pinObjects`
        pinObjects = new GameObject[pinCollection.transform.childCount];

        // Assign the data
        for (int i = 0; i < pinCollection.transform.childCount; i++)
        {
            pinObjects[i] = pinCollection.transform.GetChild(i).gameObject;
        }

        ResetPins();


        //if (pinCollection != null)
        //{
        //    //RegisterPins();
        //    ResetPins();
        //}
        //else {
        //    Debug.Log("Can not find the pinCollection");
        //}

        //// 4️⃣ 重新监听 `FallTrigger`
        ////RegisterPins();
        //ResetPins();
    }

    private void ResetPins()
    {
        // Console
        Debug.Log("Excute Reset Pins");


        for (int i = 0; i < pinObjects.Length; i++)
        {
            GameObject pin = pinObjects[i];

            if (pin == null)
            {
                Debug.LogError("Pin is null at index " + i);
                continue;
            }

            Rigidbody rb = pin.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                //rb.transform.rotation = Quaternion.identity;
                //rb.transform.position = pin.transform.position;
                //// **恢复最初的旋转和位置**
                //rb.transform.position = pinOriginalPositions[i];
                //rb.transform.rotation = pinOriginalRotations[i];

                // **恢复最初的旋转和位置**
                rb.transform.localPosition = pinOriginalPositions[i];
                rb.transform.localRotation = pinOriginalRotations[i];

                //rb.isKinematic = true;
                rb.isKinematic = false;
                //pin.OnPinFall.AddListener(IncrementScore);
            }

            Debug.Log("Resetting Pin: " + pin.name);
        }

        RegisterPins();

        Debug.Log("Pins Reset Complete!");


        ////FallTrigger[] pins = pinCollection.GetComponentsInChildren<FallTrigger>();

        //// 获取所有 `Pin` 的 `FallTrigger` 组件
        //pins = FindObjectsOfType<FallTrigger>();

        //Debug.Log("pins are:" + pins);

        //foreach (FallTrigger pin in pins)
        //{

        //    Debug.Log("pins are:" + pin.gameObject.name);
        //    Rigidbody rb = pin.GetComponent<Rigidbody>();
        //    if (rb != null)
        //    {
        //        //  Console
        //        Debug.Log("Reseting the Pin...");

        //        rb.linearVelocity = Vector3.zero;
        //        rb.angularVelocity = Vector3.zero;
        //        rb.transform.rotation = Quaternion.identity;
        //        rb.transform.position = pin.transform.parent.position;
        //        //rb.isKinematic = true;
        //        rb.isKinematic = false; // 重新启用物理系统

        //        pin.OnPinFall.AddListener(IncrementScore);
        //    }
        //}
    }

    private void StoreInitialPinPositions()
    {
        if (pinCollection == null)
        {
            Debug.LogError("PinCollection is NULL! Cannot store initial positions.");
            return;
        }

        int pinCount = pinCollection.transform.childCount;
        pinOriginalPositions = new Vector3[pinCount];
        pinOriginalRotations = new Quaternion[pinCount];

        for (int i = 0; i < pinCount; i++)
        {
            GameObject pin = pinCollection.transform.GetChild(i).gameObject;
            pinOriginalPositions[i] = pin.transform.localPosition; // 记录初始 `localPosition`
            pinOriginalRotations[i] = pin.transform.localRotation; // 记录初始 `localRotation`
        }

        Debug.Log("Stored initial pin positions.");
    }


}
