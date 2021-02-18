namespace FeatherConstruct.Model
{
    
    internal class Construct : IConstruct
    {

        private int feathersCount;
        private float height;

        int IConstruct.FeathersCount => feathersCount;

        internal Construct() { }

        bool IConstruct.TakeFeather()
        {
           if (CanTakeFeather()) 
           {
               feathersCount++;
               return true;
           }
           else return false;
        }

        private bool CanTakeFeather() => feathersCount < GameManager.Configuration.MaxFeathersCount;

    }

}