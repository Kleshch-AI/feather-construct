namespace FeatherConstruct.Utils
{

    public static class TagUtils
    {

        public const string Construct = "Construct";
        public const string Ground = "Ground";
        public const string Feather = "Feather";

        public static bool IsGround(string tag) => tag == Ground;
        public static bool IsFeather(string tag) => tag == Feather;
        public static bool IsConstruct(string tag) => tag == Construct;
        
    }

}