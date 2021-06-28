using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject glassDome;
    public GameObject cameraHolder;
    public Camera cam;
    public Slider rotSpeedSlider;
    public Slider CamFOVSlider;
    public RectTransform mainPanel;
    public RectTransform foldButton;
    public bool isPanelOpen = true;
    public bool isDomeOn = true;
    public bool camRotRight = true;
    public float cameraRotSpeed = 5;

    private void Start()
    {
        glassDome = GameObject.Find("GlassDome");
        cameraHolder = GameObject.Find("CameraHolder");
        rotSpeedSlider = GameObject.Find("RotSpeedSlider").GetComponentInChildren<Slider>();
        CamFOVSlider = GameObject.Find("CamFOVSlider").GetComponentInChildren<Slider>();
        mainPanel = GameObject.Find("Panel").GetComponent<RectTransform>();
        foldButton = GameObject.Find("FoldButton").GetComponent<RectTransform>();
        cam = Camera.main;
        rotSpeedSlider.value = cameraRotSpeed;
        CamFOVSlider.value = cam.fieldOfView;

        camlocalpos = cam.transform.localPosition;

    }

    public void MoveDome()
    {
        string msg = isDomeOn ? "Off" : "On ";
        print($"Dome is now {isDomeOn}");
        float yval = isDomeOn ? 50 : 0;
        glassDome.transform.DOLocalMoveY(yval, 2).SetEase(Ease.InOutBack);
        isDomeOn = isDomeOn != true;
    }

    private void Update()
    {
        Vector3 rotDir = camRotRight ? Vector3.down : Vector3.up;
        cameraHolder.transform.Rotate(transform.rotation.eulerAngles + rotDir * (cameraRotSpeed * Time.deltaTime));

        //cam.transform.forward = camlocalpos;
    }

    public void ChangeRotDir(bool rot)
    {
        camRotRight = rot;
    }

    public void ChangeRotSpeed()
    {
        cameraRotSpeed = rotSpeedSlider.value/5;
    }

    public Vector3 camlocalpos;
    public void ChangeCamFOV()
    {
        Vector3 camPos = cam.transform.position;
        //cam.transform.localPosition = camlocalpos;
    }

    public void PanelFolding()
    {
        mainPanel.DOMoveX(-mainPanel.position.x, 1).SetEase(Ease.InOutBack);
        float dir = isPanelOpen ? -200 : 200;
        foldButton.DOMoveX(foldButton.position.x+dir, 1).SetEase(Ease.InOutBack);
        isPanelOpen = isPanelOpen != true;
    }
}
