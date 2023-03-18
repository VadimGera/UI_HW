using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonDown : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private string sceneName;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}
