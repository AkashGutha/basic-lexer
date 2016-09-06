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

        public Lexer(string input)
        {
            this.input = input;
            TokenList = new List<Node>();
            Lex();
        }

        private void Lex()
        {

            var _type = typeof(Patterns);
            var _fields = _type.GetConstantsValues<string>();

            StringBuilder sb = new StringBuilder();
            foreach (var pattern in _fields)
            {
                sb.Append(pattern.ToString() + "|");
            }
            sb.Remove(sb.Length-1, 1);
            Regex regex = new Regex(sb.ToString());

            System.Console.WriteLine(sb.ToString());

            foreach (var match in regex.Matches(this.input))
            {
                System.Console.WriteLine(match.ToString());
            }

        }

    }
}

public static class TypeExtensions
{
    public static IEnumerable<FieldInfo> GetConstants(this Type type)
    {
        var fieldInfos = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);

        return fieldInfos.Where(fi => fi.IsLiteral && !fi.IsInitOnly);
    }

    public static IEnumerable<T> GetConstantsValues<T>(this Type type) where T : class
    {
        var fieldInfos = GetConstants(type);

        return fieldInfos.Select(fi => fi.GetRawConstantValue() as T);
    }
}