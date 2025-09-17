using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Events;
using Unity.VisualScripting;

public class UISeleccion : MonoBehaviour {
    public static bool gazedAt;
    public float fillTime = 5f;
    public Image radialImage;
    public UnityEvent onFillComplete;

    public Coroutine fillCorroitine;



    void Start() {
        gazedAt = false;
        radialImage.fillAmount = 0f;
    }


    public void OnPointerEnter() {
        gazedAt = true;

        if (fillCorroitine != null) {
            //Aqui va la corutina
            StopCoroutine(fillCorroitine);
        }

        fillCorroitine = StartCoroutine(FillRadial());

    }

    private IEnumerator FillRadial() {

        float elapsedTime = 0f;

        while (elapsedTime < fillTime) {
            if (!gazedAt) {
                yield break;
            }

            elapsedTime += Time.deltaTime;
            radialImage.fillAmount = Mathf.Clamp01(elapsedTime / fillTime);

            yield return null;

        }

        //e ejecuta el evento OnFillComplete cuando se completa el llenado de  carga
        onFillComplete?.Invoke();
    }


    public void OnPointerExit() {
        gazedAt = false;
        if (fillCorroitine != null) {
            StopCoroutine(fillCorroitine);
            fillCorroitine = null;
        }

        radialImage.fillAmount = 0f;

    }

}