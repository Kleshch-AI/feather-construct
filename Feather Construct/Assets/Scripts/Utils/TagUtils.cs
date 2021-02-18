namespace FeatherConstruct.Utils
{

    public static class TagUtils
    {

        public const string Construct = "Construct";
        public const string Ground = "Ground";
        public const string Feather = "Feather";
        public const string Top = "Top";

        public static bool IsGround(string tag) => tag == Ground;
        public static bool IsFeather(string tag) => tag == Feather;
        public static bool IsConstruct(string tag) => tag == Construct;
        public static bool IsTop(string tag) => tag == Top;
        
    }

}