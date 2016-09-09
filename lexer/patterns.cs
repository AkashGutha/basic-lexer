namespace lexer
{
    public class Patterns
    {
        public const string number = @"(?:\d*\.)?\d+";
        public const string identifier = @"(?:[a-z_A-Z]+)[a-zA-Z_0-9]*";

        //double char operators
        public const string equivavlence = @"==";
        public const string addTo = @"\+\s*=";
        public const string subFrom = @"-\s*=";
        public const string mulTo = @"\*\s*=";
        public const string divideFrom = @"/\s*=";
        public const string moduloFrom = @"%\s*=";
        public const string leftShift = @"<<";
        public const string rightShift = @">>";

        //single char operators
        public const string assignment = @"=";
        public const string add = @"\+";
        public const string sub = @"-";
        public const string mul = @"\*";
        public const string divide = @"/";
        public const string modulo = @"%";
        public const string lessThan = @"<";
        public const string greaterThan = @">";

    }
}