using UnityEngine;

public class DieEffect : MonoBehaviour
{
    private ParticleSystem ParticleSystem;

    private bool _isPlay;

    private void Awake()
    {
        ParticleSystem = GetComponent<ParticleSystem>();
    }

    public void OnDieEffect()
    {
        if (ParticleSystem != null)
        {
            if (_isPlay == false)
            {
                ParticleSystem.Play();

                _isPlay = true;
            }
        }
    }
}