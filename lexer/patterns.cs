namespace lexer
{
    public class Patterns
    {
        public const string numberPattern = @"(?:\d*\.)?\d+";
        public const string identifierPattern = @"(?:[a-z_A-Z]+)[a-zA-Z_0-9]*";

        //double char operators
        public const string equivavlencePattern = @"==";
        public const string addToPattern = @"\+\s*=";
        public const string subFromPattern = @"-\s*=";
        public const string mulToPattern = @"\*\s*=";
        public const string DivideFromPattern = @"/\s*=";
        public const string ModuloFromPattern = @"%\s*=";
        public const string LeftShiftPattern = @"<<";
        public const string RightShiftPattern = @">>";

        //single char operators
        public const string assignmentPattern = @"=";
        public const string addPattern = @"\+";
        public const string subPattern = @"-";
        public const string mulPattern = @"\*";
        public const string DividePattern = @"/";
        public const string ModuloPattern = @"%";
        public const string LessThanPattern = @"<";
        public const string GreaterThanPattern = @">";

    }
}