namespace FeatherConstruct.Model
{
    
    internal class Construct : IConstruct
    {

        private int feathersCount;

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

        private bool CanTakeFeather() => feathersCount < GameManager.Instance.Configuration.MaxFeathersCount;

    }

}