﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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

        //初期でボタンをマスク
        private void Form1_Load(object sender, EventArgs e)
        {
            initButton();
            initImage();
        }

        //ボタン追加
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

            //コンボボックスへの登録
            setComboBoxAuthor(cbAuthor.Text);
            setComboBoxName(cbCardName.Text);

            //リストに取り込む
            _Cards.Insert(0, card);

            //次の入力に備えて各項目をクリア
            inputitemAllClear();

            //ボタンのマスク判別
            initButton();
            initImage();

            //選択解除
            cellNull();
        }

        //属性を取得
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

        //カード名コンボボックスの入力候補
        private void setComboBoxName(string maker)
        {
            if (!cbCardName.Items.Contains(maker))
            {
                //コンボボックスの候補に追加
                cbCardName.Items.Add(maker);
            }

        }

        //記録者コンボボックスの入力候補
        private void setComboBoxAuthor(string maker)
        {
            if (!cbAuthor.Items.Contains(maker))
            {
                //コンボボックスの候補に追加
                cbAuthor.Items.Add(maker);
            }

        }

        //入力項目を全クリア
        private void inputitemAllClear()
        {
            cbAuthor.Text = "";
            cbCardName.Text = "";
            tbText.Clear();
            pbCard.Image = null;
        }

        //ボタンのマスクの追加、解除機能
        private void initButton()
        {
            if (_Cards.Count > 0)
            {
                btCardChange.Enabled = true;
                btCardDelete.Enabled = true;
            }
            else
            {
                btCardChange.Enabled = false;
                btCardDelete.Enabled = false;
            }
        }

        //画像に関するボタンのマスク
        private void initImage()
        {
            if (pbCard.Image == null)
            {
                btImageDelete.Enabled = false;
            }
            else
            {
                btImageDelete.Enabled = true;
            }
        }

        //セル選択解除機能
        private void cellNull()
        {
            dgvCardData.CurrentCell = null;

            btCardChange.Enabled = false;
            btCardDelete.Enabled = false;
        }

        //ボタン修正
        private void btCardChange_Click(object sender, EventArgs e)
        {
            //変更対象のレコードを取り出す
            CardReport selectedCard = _Cards[dgvCardData.CurrentRow.Index];

            //レコードを変更
            selectedCard.CreatedDate = dbCreatedDate.Value;
            selectedCard.Author = cbAuthor.Text;
            selectedCard.Elemental = RadioGet();
            selectedCard.Name = cbCardName.Text;
            selectedCard.Text = tbText.Text;
            selectedCard.Picture = pbCard.Image;

            //変更を反映
            dgvCardData.Refresh();
        }

        //ボタン削除
        private void btCardDelete_Click(object sender, EventArgs e)
        {
            //選択したレコードの削除
            _Cards.RemoveAt(dgvCardData.CurrentRow.Index);

            inputitemAllClear();

            initButton();
            initImage();

            cellNull();
        }

        //クリックしたデータをラベルに表示
        private void dgvCardData_Click(object sender, EventArgs e)
        {
            //選択したレコードを取り出す
            //データグッドビューで選択した行のインデックスを元に
            //BindingListのデータを取得する
            if (dgvCardData.CurrentRow != null)
            {
                CardReport selecedCar = _Cards[dgvCardData.CurrentRow.Index];

                dbCreatedDate.Value = selecedCar.CreatedDate;
                cbAuthor.Text = selecedCar.Author;
                dgvRadioGet(selecedCar);
                cbCardName.Text = selecedCar.Name;
                tbText.Text = selecedCar.Text;
                pbCard.Image = selecedCar.Picture;
            }

            initButton();
            initImage();
        }

        //クリックしたデータの属性を取得
        private void dgvRadioGet(CardReport selectedCar)
        {
            switch (selectedCar.Elemental)
            {
                case CardReport.CardElemental.火:
                    rbFire.Checked = true;
                    break;
                case CardReport.CardElemental.水:
                    rbAqua.Checked = true;
                    break;
                case CardReport.CardElemental.風:
                    rbWind.Checked = true;
                    break;
                case CardReport.CardElemental.地:
                    rbNorth.Checked = true;
                    break;
                case CardReport.CardElemental.闇:
                    rbDark.Checked = true;
                    break;
                case CardReport.CardElemental.光:
                    rbLight.Checked = true;
                    break;
                case CardReport.CardElemental.神:
                    rbGod.Checked = true;
                    break;
                case CardReport.CardElemental.魔法:
                    rbMagic.Checked = true;
                    break;
                case CardReport.CardElemental.罠:
                    rbTrap.Checked = true;
                    break;
                default:
                    break;
            }
        }

        //ボタン開く（画像）
        private void btImageOpen_Click(object sender, EventArgs e)
        {
            //ダイアログを表示する
            if (ofdOpenFileImage.ShowDialog() == DialogResult.OK)
            {
                //選択した画像をピクチャーボックスに表示
                pbCard.Image = Image.FromFile(ofdOpenFileImage.FileName);
                //ピクチャーボックスのサイズに画像を調整
                pbCard.SizeMode = PictureBoxSizeMode.StretchImage;

            }

            initImage();
        }

        //ボタン削除（画像）
        private void btImageDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("画像を削除してよろしいですか？","警告",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button2);

            //何が選択されたか調べる
            if (result == DialogResult.Yes)
            {
                //「はい」が選択された時
                pbCard.Image = null;
            }
            else if (result == DialogResult.No)
            {
                return;
            }

            initImage();
            cellNull();
        }

        //ボタン保存（記事）
        private void btCardSave_Click(object sender, EventArgs e)
        {
            //セーブファイルダイアログを表示する
            if (sfdSaveData.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create))
                {
                    try
                    {
                        //シリアル化して保存
                        formatter.Serialize(fs, _Cards);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        throw;
                    }

                }

            }
        }

        //ボタン開く（記事）
        private void btCardLoad_Click(object sender, EventArgs e)
        {
            //オープンファイルダイアログを表示する
            if (ofdOpenData.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofdOpenData.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        //逆シリアル化して読み込む
                        _Cards = (BindingList<CardReport>)formatter.Deserialize(fs);

                        //データグリッドビューに設定
                        dgvCardData.DataSource = _Cards;

                        //選択されている箇所を各コントロールへ表示
                        dgvCardData_Click(sender, e);
                        pbCard.SizeMode = PictureBoxSizeMode.StretchImage;

                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        
                        // メッセージボックスを表示する
                        MessageBox.Show("ファイルの種類が違います。","エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }

                }

            }
        }

        //入力項目全クリア
        private void 新規入力ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputitemAllClear();
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // セーブファイルダイアログを表示する
            if (sfdSaveData.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create))
                {
                    try
                    {
                        //シリアル化して保存
                        formatter.Serialize(fs, _Cards);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        throw;
                    }

                }
            }
        }
    }
}
