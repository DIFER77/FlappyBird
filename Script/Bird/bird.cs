using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(BirdMover))]
public class bird : MonoBehaviour
{
    private BirdMover _mover;
    private int _score;
    public event UnityAction GameOver;
    public event UnityAction<int> ScoreChanged;
    private void Start()
    {
        _mover = GetComponent<BirdMover>(); 
    }
    public void IncreaseScore()
    {
        ScoreChanged?.Invoke(_score);
        _score++;
    }
    public void ResetPlayer()
    {
        _score = 0;
        _mover.ResetBird();
    }
    public void Die()
    {
       GameOver?.Invoke();
        Time.timeScale = 0;
    }
}