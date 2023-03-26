using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
  [SerializeField] private bird _bird;
  [SerializeField] private PipeGenerator _pipeGenerator;
  [SerializeField] private startcreen _startscreen;
  [SerializeField] private gameoverScreen _gameoverscreeen;
private void OnEnable()
{
_startscreen.PlayButtonClick += OnPlayButtonClick;
_gameoverscreen.RestartButtonClick += OnRestartButtonClick;
}
private void OnDisable()
{
  _startscreen.PlayButtonClick -= OnPlayButtonClick;
_gameoverscreen.RestartButtonClick -= OnRestartButtonClick;
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
  _pipeGenerator.ResetPoll();
  StartGame();
}
private void StartGame()
{
 Time.timeScale = 1;
 _bird.ResetPlayer();
}
public void GameOver()
{
  Time.timeScale = 0;
  _gameoverscreeen.Open();
}
}
