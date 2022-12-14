using System;
using System.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

public class MainMenuControl : MonoBehaviour
{
    [SerializeField] private Transform movingPanel;
    [SerializeField] private Transform movingTextGameHub;
    [SerializeField] private Transform movingTextAboutGame;
    [SerializeField] private Transform btnMiniGames;
    [SerializeField] private Transform btnMiniHyperCas;
    [SerializeField] private Transform btnMiniTests;
    [SerializeField] private Transform buttonGo;
    private readonly Vector3 _finalPositionRight = new Vector3(-169f, 0.03445524f, 96f);
    private readonly Vector3 _finalPositionLeft = new Vector3(198.1f, 0.03445524f, 96f);
    private readonly Vector3 _finalButtonPosition = new Vector3(-100, 30f, 96f);
    public GameObject startPanel;
    public AudioSource musicBox;
    
    


    private async void Start()
    {
        await Task.Delay(500);
        buttonGo.DOMove((new Vector3(0f, 0f, 96f)), 2f).SetEase(Ease.OutBack);
        movingTextGameHub.DOMove((new Vector3(0f, 20f, 96f)), 2f).SetEase(Ease.OutBack);
        await movingPanel.DOMove(_finalPositionRight, 40f).AsyncWaitForCompletion();
        await movingPanel.DOMove(_finalPositionLeft, 80f).AsyncWaitForCompletion();
    }

    private void ShowButtonsChooseGames()
    {
        movingTextGameHub.DOMove(new Vector3(0, 50f, 96f), 2f).SetEase(Ease.OutBack);
        movingTextAboutGame.DOMove((new Vector3(0f, 20f,96f)), 0.9f).SetEase(Ease.OutBack);
        btnMiniGames.DOMove((new Vector3(0f,-10f,96f)), 1.5f).SetEase(Ease.OutBack);
        btnMiniHyperCas.DOMove((new Vector3(-70,-15f,96f)), 1.5f).SetEase(Ease.OutBack);
        btnMiniTests.DOMove((new Vector3(70,-15f,96f)), 1.5f).SetEase(Ease.OutBack);
    }

    public async void ButtonGoClick()
    {
        buttonGo.DOMove((new Vector3(0f, 70f, 96f)), 1f).SetEase(Ease.OutBack);
        movingTextGameHub.DOMove(new Vector3(0, 50f, 96f), 2f).SetEase(Ease.OutBack);
        
        musicBox.Play();
        
        await Task.Delay(600);
        
        ShowButtonsChooseGames();


    }
}
