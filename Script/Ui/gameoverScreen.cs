using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class gameoverScreen : ScreenMenu
{
public event UnityAction RestartButtonClick;
public override void Close()
{
    CanvasGroup.alpha = 0;
    button.interactable = false;

}
public override void Open()
{
    CanvasGroup.alpha = 1;
    button.interactable = true;
    
}
protected override void OnButtonClick()
{
RestartButtonClick?.Invoke();    
}
}

