using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardReportSystem
{
    [Serializable]
    class CardReport
    {
        //属性
        public enum CardElemental
        {
            DEFAULT,
            火,
            水,
            風,
            地,
            闇,
            光,
            神,
            魔法,
            罠
        }

        //日付
        public DateTime CreatedDate { get; set; }

        //記録者
        public string Author { get; set; }

        //属性
        public CardElemental Elemental { get; set; }

        //カード名
        public string Name { get; set; }

        //テキスト
        public string Text { get; set; }

        //画像
        public Image Picture { get; set; }
    }
}
