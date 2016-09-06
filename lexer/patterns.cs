namespace lexer
{
    public class Patterns
    {
        public const string numberPattern = @"(?:\d*\.)?\d+";
        public const string identifierPattern = @"(?:[a-z_A-Z]+)[a-zA-Z_0-9]*";
        public const string assignmentPattern = @"=";
        
    }
}