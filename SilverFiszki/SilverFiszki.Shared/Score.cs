using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SilverFiszki
{
    public class Score
    {
        public int GoodAnswerCount { get; set; }
        public int WrongAnswerCount { get; set; }
        public int AllAnswers { get { return GoodAnswerCount + WrongAnswerCount; } }

        public DateTime GameTime { get; set; }
    }
}
