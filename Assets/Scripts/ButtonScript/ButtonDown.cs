using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ButtonScript
{
    public class ButtonDown : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private string sceneName;
        [SerializeField] private GameObject loadingScreen;
        [SerializeField] private Slider slider;
        [SerializeField] private TextMeshProUGUI _progressProcent;

        public void OnPointerDown(PointerEventData eventData)
        {
            loadingScreen.SetActive(true);
           

            StartCoroutine(LoadAsync());
        }


        public IEnumerator LoadAsync()
        {
            var asyncLoad = SceneManager.LoadSceneAsync(sceneName);

            while (!asyncLoad.isDone)
            {
                var progress = Mathf.Clamp01(asyncLoad.progress / 0 / 9f);
                slider.value = asyncLoad.progress;
                _progressProcent.text = Mathf.Round(progress * 100) + "%";
                yield return null;
            }
        }
    }
}
