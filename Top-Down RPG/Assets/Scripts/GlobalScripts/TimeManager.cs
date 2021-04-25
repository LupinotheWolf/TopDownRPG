using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float slowdownFactor = 0.05f;
    public bool overSpeed = false;

    //The amount to add to the reduced time to return it back to normal realtime
    public float slowdownLength = 2f;

    private void Update()
    {
        //Returns the time to normal by adding half of timescale to it
        //deltatime is how long time passed since last frame
        //converting a speed per second to per frame you multiply by deltatime
        //to convert back to using per second you divide by deltatime
        Time.timeScale += (1f / slowdownLength) * Time.unscaledDeltaTime;
        if (!overSpeed)
        {
            Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
        }
        else
        {
            Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 2f);
        }
    }
    //FixedUpdate is an Update function that happens a fixed amount of times per second
    public void DoSlowMotion()
    {
        Time.timeScale = slowdownFactor;
        //fixedDeltaTime is adjusting the timer of FixedUpdate, so 1/50 or 0.02 makes it go 50FPS
        //Multiplying by timescale will also slow down the time between each fixed Update to make it smooth
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }
}
