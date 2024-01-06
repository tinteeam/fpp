using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fpp.compiler
{
    public class Lexer
    {
        private readonly string _text;
        private int _position;


        public Lexer(string text)
        {
            _text = text;

        }

        public SyntaxToken NextToken()
        {

        }
    }
}
