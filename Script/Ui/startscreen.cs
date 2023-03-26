using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class startscreen : ScreenMenu
{
public event UnityAction PlayButtonClick;
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
PlayButtonClick?.Invoke();    
}
}
