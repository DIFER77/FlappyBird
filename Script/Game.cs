using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
  [SerializeField] private bird _bird;
  [SerializeField] private PipeGenerator _pipeGenerator;
  [SerializeField] private startscreen _startscreen;
  [SerializeField] private gameoverScreen _gameoverscreeen;
private void OnEnable()
{
_startscreen.PlayButtonClick += OnPlayButtonClick;
_gameoverscreeen.RestartButtonClick += OnRestartButtonClick;
_bird.GameOver += OnGameOver;

}
    private void OnDisable()
    {
        _startscreen.PlayButtonClick -= OnPlayButtonClick;
        _gameoverscreeen.RestartButtonClick -= OnRestartButtonClick;
        _bird.GameOver -= OnGameOver;
    }
 private void Start()
 {
  Time.timeScale = 0;
  _startscreen.Open();
 }
 
private void OnPlayButtonClick()
{
  _startscreen.Close();
  StartGame();

}
private void OnRestartButtonClick()
{
  _gameoverscreeen.Close();
  _pipeGenerator.ResetPool();
  StartGame();
}
private void StartGame()
{
 Time.timeScale = 1;
 _bird.ResetPlayer();
}
public void OnGameOver()
{
  Time.timeScale = 0;
  _gameoverscreeen.Open();
}
}
