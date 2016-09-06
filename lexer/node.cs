
namespace lexer
{
    public class Node
    {
        public string value { get; set; }
        public token tok { get; set; }
        public Node (string value , token tok)
        {
          this.tok = tok;
          this.value = value;
        }
    }
}