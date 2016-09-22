using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Text;
using System.Linq;

namespace lexer
{
    public class Lexer
    {
        private string input = "";
        private List<Node> TokenList;

        private state[,] transitions = new state[,]{

            //   whitespace  as input
            { state.ignore , state.ignore },
            { state.waiting , state.ignore },

            //   char as input
            { state.ignore , state.waiting },
            { state.waiting , state.waiting },
        };

        public Lexer(string input)
        {
            this.input = input;
            TokenList = new List<Node>();
            Lex();
        }

        private void Lex()
        {
            var _tokenvalues = new List<Node>();

            var _type = typeof(Patterns);
            var _fields = _type.GetConstantsValues<string>();
            var _length = _fields.Count();

            /*
            // building the last regex.
            StringBuilder sb = new StringBuilder();
            foreach (var pattern in _fields)
            {
                sb.Append(pattern.ToString() + "|");
            }
            sb.Remove(sb.Length - 1, 1);
            Regex regex = new Regex(sb.ToString()
            // the last regex to the console
            System.Console.WriteLine(sb.ToString()
            //matching the and output the matches to console.
            foreach (var match in regex.Matches(this.input))
            {
                _tokenvalues.Add(match.ToString());
            }
            */

            // Automaton approach.
            char[] stream = this.input.ToCharArray();
            state LexingState = state.waiting;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < stream.Length; i++)
            {
                switch (stream[i])
                {
                    case ' ':
                    case '\n':
                    case '\r':
                    case '\t':
                        if (LexingState == state.waiting)
                            foreach (var pattern in _fields)
                            {
                                Regex r = new Regex(pattern);
                                if (r.IsMatch(sb.ToString()))
                                {
                                    var tokentype = (token)Enum.Parse(typeof(token), "add");
                                    _tokenvalues.Add(new Node(sb.ToString(), tokentype, 0, 0));
                                    sb.Clear();
                                    continue;
                                }
                            }

                        LexingState = transitions[(int)LexingState, 1];
                        break;

                        case '+':
                        case '-':
                        case '/':
                        case '%':
                        case '*':
                        
                        break;

                    default:
                        LexingState = transitions[2 + (int)LexingState, 1];
                        sb.Append(stream[i]);
                        break;
                }
            }

            foreach (var _token in _tokenvalues)
            {
                System.Console.WriteLine(_token.ToString());
            }

        }

        private void LexAndAddToken()
        {

        }
    }
}

public enum state
{
    ignore = 0,
    waiting = 1,
    tokenize = 2
}
