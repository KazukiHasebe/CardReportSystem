using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardReportSystem
{
    public partial class Form1 : Form
    {
        //カードデータを入れるバインディングリスト
        BindingList<CardReport> _Cards = new BindingList<CardReport>();

        

        public Form1()
        {
            InitializeComponent();
            dgvCardData.DataSource = _Cards;
        }

        private void btCardRegister_Click(object sender, EventArgs e)
        {
            CardReport card = new CardReport
            {
                CreatedDate = dbCreatedDate.Value,
                Author = cbAuthor.Text,
                Elemental = RadioGet(),
                Name = cbCardName.Text,
                Text = tbText.Text,
                Picture = pbCard.Image
            };


        }

        private CardReport.CardElemental RadioGet() 
        {
#if true
            string maker = "";

            foreach (RadioButton item in groupElemental.Controls)
            {
                if (item.Checked)
                {
                    maker = item.Text;
                }
            }

            switch (maker)
            {
                case "火":
                    return CardReport.CardElemental.火;
                case "水":
                    return CardReport.CardElemental.水;
                case "風":
                    return CardReport.CardElemental.風;
                case "地":
                    return CardReport.CardElemental.地;
                case "闇":
                    return CardReport.CardElemental.闇;
                case "光":
                    return CardReport.CardElemental.光;
                case "魔法":
                    return CardReport.CardElemental.魔法;
                case "罠":
                    return CardReport.CardElemental.罠;
                default:
                    return CardReport.CardElemental.DEFAULT;
            }
#else
            RadioButton selectMaker = (groupElemental.Controls.Cast<RadioButton>().
            FirstOrDefault(rb => rb.Checked));
            return (CardReport.CardElemental)int.Parse(selectMaker.Tag.ToString());
#endif
        }
        
    }
}
