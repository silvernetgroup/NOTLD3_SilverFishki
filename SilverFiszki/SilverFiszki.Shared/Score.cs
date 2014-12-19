using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SilverFiszki
{
    public class Score : IComparable<Score>
    {
        public int GoodAnswerCount { get; set; }
        public int WrongAnswerCount { get; set; }
        public int AllAnswers { get { return GoodAnswerCount + WrongAnswerCount; } }

        public DateTime GameTime { get; set; }

        public int CompareTo(Score other)
        {
            if (this.GoodAnswerCount > other.GoodAnswerCount)
            {
                return 1;
            }
            else if (this.GoodAnswerCount < other.GoodAnswerCount)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return string.Format("Good Answers: {0}, Wrong Answers: {1}, Game Time: {2}",GoodAnswerCount, WrongAnswerCount, GameTime);
        }
    }
}
