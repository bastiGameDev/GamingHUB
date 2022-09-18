using System;
using System.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

public class MainMenuControl : MonoBehaviour
{
    [SerializeField] private Transform movingPanel;
    [SerializeField] private Transform movingText;
    [SerializeField] private Transform buttonGo;
    private readonly Vector3 _finalPositionRight = new Vector3(-169f, 0.03445524f, 96f);
    private readonly Vector3 _finalPositionLeft = new Vector3(198.1f, 0.03445524f, -10f);
    


    private async void Start()
    {
        await Task.Delay(500);
        buttonGo.DOMove((new Vector3(0f, 0f, 96f)), 2f).SetEase(Ease.OutBack);
        movingText.DOMove((new Vector3(0f, 30f, 96f)), 2f).SetEase(Ease.OutBack);
        await movingPanel.DOMove(_finalPositionRight, 30f).AsyncWaitForCompletion();
        await movingPanel.DOMove(_finalPositionLeft, 60f).AsyncWaitForCompletion();
    }

    void Update()
    {
    }
}
