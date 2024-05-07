
using UnityEngine;
using UnityEngine.UI;
public class DragSpeedControl : MonoBehaviour
{
   public Slider speedSlider;
   public PlayerMotor playerMotor;
   private float minSpeed =3.0f;
   private float maxSpeed = 8.0f;

   private void Awake()
    {
        speedSlider = GetComponentInChildren<Slider>();
        playerMotor = FindObjectOfType<PlayerMotor>();

        // Set the minimum and maximum values for the slider
        speedSlider.minValue = minSpeed;
        speedSlider.maxValue = maxSpeed;
    }
    void Start()
    {
        speedSlider.value = minSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (speedSlider != null && playerMotor != null)
        {
            float currentSpeed = speedSlider.value;
            playerMotor.SetSpeed(currentSpeed);
        }
    }
}
