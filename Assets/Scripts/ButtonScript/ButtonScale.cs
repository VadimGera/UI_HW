using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonScale : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
  private Button _but;

  private void Start()
  {
    _but = this.GetComponent<Button>();
  }

  public void OnPointerEnter(PointerEventData eventData)
  {
    transform.localScale += new Vector3(1, 1, 1);
  }

  public void OnPointerExit(PointerEventData eventData)
  {
    transform.localScale += new Vector3(-1, -1, -1);
  }
}

