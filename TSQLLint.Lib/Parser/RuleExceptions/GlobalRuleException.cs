using TSQLLint.Lib.Parser.Interfaces;

namespace TSQLLint.Lib.Parser.RuleExceptions
{
    public class GlobalRuleException : IRuleException
    {
        public GlobalRuleException(int startLine, int endLine)
        {
            EndLine = endLine;
            StartLine = startLine;
        }

        public int EndLine { get; private set; }

        public int StartLine { get; }

        public void SetEndLine(int endLine)
        {
            EndLine = endLine;
        }
    }
}
