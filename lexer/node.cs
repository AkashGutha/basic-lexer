
namespace lexer
{
    public class Node
    {
        public string value { get; set; }
        public token tok { get; set; }
        public int row { get; set; }
        public int col { get; set; }
        public Node(string value, token tok, int row, int col)
        {
            this.tok = tok;
            this.value = value;
            this.row = row;
            this.col = col;
        }

        public override string ToString()
        {
            return "Token : " + tok.ToString() +
                " Row : " + row + " Col : " + col + " Value : " + value;
        }
    }
}