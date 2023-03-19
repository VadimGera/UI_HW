using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace LoadProgress
{
    public class LoadManager : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private Slider _slider;
        [SerializeField] private string sceneName;
        [SerializeField] private GameObject loadingScreen;
        [SerializeField] private TextMeshProUGUI _progressPercent;
    
        public void OnPointerDown(PointerEventData eventData)
        {
            
            SceneManager.LoadSceneAsync(sceneName);

            AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
            loadingScreen.SetActive(true);

            while (!operation.isDone)
            {
                float progress = Mathf.Clamp01(operation.progress / 0.8f);

                _slider.value = progress;
                _progressPercent.text = Mathf.Round(progress * 100) + "%";
                
            }
        }

        
    }
}