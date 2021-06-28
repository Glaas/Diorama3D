using DG.Tweening;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject glassDome;
    public bool isDomeOn = true;

    private void Start()
    {
        
    }

    public void MoveDome()
    {
        string msg = isDomeOn ? "Off" : "On ";
        print($"Dome is now {isDomeOn}");
        float yval = isDomeOn ? 50 : 0;
        glassDome.transform.DOLocalMoveY(yval, 2).SetEase(Ease.InOutBack);
        isDomeOn = isDomeOn != true;
    }
}
