using UnityEngine;

public class UIMover : MonoBehaviour
{
    private RectTransform m_rectTransform = null;
    [SerializeField] private float m_oscillationSpeed = 1f;
    [SerializeField] private float m_max = 1f, m_min =-1f;

    private Vector2 m_maxAnchorPosition, m_minAnchorPosition;


    private float m_oscillationDirection = 1f;
    private void Awake()
    {
        m_rectTransform = this.transform as RectTransform;

        m_maxAnchorPosition = m_rectTransform.anchoredPosition + (Vector2.up * m_max);
        m_minAnchorPosition = m_rectTransform.anchoredPosition + (Vector2.down * m_min);
    }

    private void Update()
    {
        var currentAnchoredPosition = m_rectTransform.anchoredPosition;
        currentAnchoredPosition.y += Time.deltaTime * m_oscillationDirection * m_oscillationSpeed;
        m_rectTransform.anchoredPosition = currentAnchoredPosition;

        bool getToTheTop = m_oscillationDirection > 0 && currentAnchoredPosition.y >= m_maxAnchorPosition.y;
        bool getToTheBottom = m_oscillationDirection < 0 && currentAnchoredPosition.y <= m_minAnchorPosition.y;
        if (getToTheTop || getToTheBottom)
            m_oscillationDirection *= -1f;
    }
}
