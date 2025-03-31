using UnityEngine;
public class audiomanager : MonoBehaviour
{
    [Header("-----------audio source----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-----------audio clips----------")]
    public AudioClip background;
    public AudioClip jump;
    public AudioClip hit;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    
    }
    
}
