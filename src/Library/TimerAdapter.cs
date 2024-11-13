namespace Full_GRASP_And_SOLID
{
    

    public class TimerAdapter : TimerClient
    {
        private Recipe recipe;
        private CountdownTimer countdownTimer = new CountdownTimer();

        public TimerAdapter(Recipe recipe)
        {
            this.recipe = recipe;
        }

        public void StartTimer(int cookTimeMilliseconds)
        {
            countdownTimer.Register(cookTimeMilliseconds, this);
        }

        public void TimeOut()
        {
            recipe.Cook(); 
        }
    }
}