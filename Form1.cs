using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memo123
{

    public partial class Form1 : Form
    {

        public Form1(){InitializeComponent();}

        //フィールドクラスを定義
        class Memo_Field
        {
            //現在開いているファイル名のフィールド
            //開いていないor新規作成した場合「無題」にする
            public String file_name { get; set; } = "無題";
            //フォーム名のフィールド
            public String form_name { get; } = "メモ帳";
            //テキストボックスに文字が入力されたか確認するためのフラグ＝保存済or未保存
            //true = 未入力(保存済)　false = 入力あり(未保存)
            public bool _isSaved { get; set; } = true;
        }

        Memo_Field mf = new Memo_Field();

        private void 新規作成ToolStripMenuItem_Click(object sender, EventArgs e) { this.NewMemo(); }
        private void 開くToolStripMenuItem_Click(object sender, EventArgs e) { this.OpenFile(); }
        private void 上書き保存sToolStripMenuItem_Click(object sender, EventArgs e) { this.OverWriteSaveText(); }
        private void 名前をつけて保存ToolStripMenuItem_Click(object sender, EventArgs e) { this.SaveTextAs(); }
        private void 終了ToolStripMenuItem_Click_1(object sender, EventArgs e) { this.CloseMemo(); }
        private void 切り取りXToolStripMenuItem_Click(object sender, EventArgs e) { this.CutText(); }
        private void 貼り付けPToolStripMenuItem_Click(object sender, EventArgs e) { this.PasteText(); }
        private void コピーCToolStripMenuItem_Click(object sender, EventArgs e) { this.CopyText(); }
        private void 削除DToolStripMenuItem_Click(object sender, EventArgs e) { this.DeleteText(); }
        private void 元に戻すZToolStripMenuItem_Click(object sender, EventArgs e) { this.UndoMemo(); }
        private void 編集EToolStripMenuItem_Click(object sender, EventArgs e) { this.CheckSelectedFlg(); }
        private void ステータスバーToolStripMenuItem_Click(object sender, EventArgs e) { this.ShowStatusBar(); }
        private void ヘルプを表示ToolStripMenuItem_Click(object sender, EventArgs e) { this.OpenWebPage("https://www3.jeed.go.jp/okinawa/poly/"); }
        private void フォントFToolStripMenuItem_Click(object sender, EventArgs e) { this.OpenFontMenu(); }

        //フォームが読み込まれた際に働くイベント
        private void Form1_Load(object sender, EventArgs e)
        {
            //フォームのテキストを変更　初期値(無題 - メモ帳)
            this.ChangeFormText();

            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                //クリップボードにテキス情報を保持していたら
                //貼り付けのコントロールをtrueにする
                this.貼り付けPToolStripMenuItem.Enabled = true;
            }
        }

        //テキストボックスに変更が生じた際に働くイベント
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ラベルのステータスバー表示機能に関係
            if (toolStripStatusLabel1.Enabled == true)
            {
                //ラベルのコントロールがtrueなら
                //文字数を表示
                string text = string.Format("文字数{0}", this.txt_memo.Text.Length);
                this.toolStripStatusLabel1.Text = text;
            }

            //テキストボックスの文字入力確認フラグを監視
            if (this.txt_memo.Text == "")
            {
                //テキストボックスの中身が空なら
                //テキストボックスの文字入力確認フラグを「未入力(保存済)」の状態に
                mf._isSaved = true;
            }
            else
            {
                //テキストボックスの中身が空以外なら
                //テキストボックスの文字入力確認フラグを「入力あり(未保存)」の状態に
                mf._isSaved = false;
            }

            //元に戻す機能に関係
            if (txt_memo.CanUndo == true)
            {
                //元に戻す機能が使えるならコントロールを有効に
                this.元に戻すZToolStripMenuItem.Enabled = true;
            }

        }


        //フォームテキストを変更するメソッド
        public void ChangeFormText()
        {
            this.Text = mf.file_name + " - " + mf.form_name;
        }

        //新規作成時、分岐処理を行うメソッド
        private void NewMemo()
        {
            if (mf._isSaved == false)
            {
                //テキストボックスのテキストが未保存の場合
                //内容を保存するか確認
                DialogResult result = MessageBox.Show("変更内容を保存しますか？",
                    "新規作成", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    //保存する場合
                    //保存処理
                    this.SaveTextAs();
                    //新規作成処理
                    this.NewProcess();
                }
                else if (result == DialogResult.No)
                {
                    //保存しない場合
                    //新規作成処理
                    this.NewProcess();
                }
                else
                {
                    //キャンセルの場合
                    //戻る
                    return;
                }
            }

            //新規作成処理
            this.NewProcess();
        }

        //新規作成処理を行うメソッド
        private void NewProcess()
        {
            //テキストボックスの中身を空にする
            this.txt_memo.Text = String.Empty;
            //テキストボックスの文字入力確認フラグを「未入力(保存済)」の状態に変更
            mf._isSaved = true;
            //file_nameの内容を無題へ変更
            mf.file_name = "無題";
            //フォームのテキストを開いているファイルの名前に変更
            this.ChangeFormText();
            //新規作成時に上書き保存できないようにフラグを変更
            上書き保存sToolStripMenuItem.Enabled = false;
        }

        //ファイルを開く処理を行うメソッド
        private void OpenFile()
        {
            //OpenFileDialogクラスのインスタンスを生成
            OpenFileDialog dialog = new OpenFileDialog();
            //テキストファイルのみ選択できるようフィルターを設定
            dialog.Filter = "テキストファイル(*.txt)|*.txt";
            //ダイアログのタイトルをメモ帳に設定
            dialog.Title = "開く";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //選択したファイルのテキスト情報をテキストボックスの内容へ反映
                this.txt_memo.Text = File.ReadAllText(dialog.FileName);
                //フィールド~file_name~を開いているファイル名に変更
                mf.file_name = dialog.FileName;
                //フォームのテキストを選択したファイル名に変更
                this.ChangeFormText();
                //テキストボックスの文字入力確認フラグを「未入力(保存済)」の状態に
                mf._isSaved = true;
                //上書き保存可能にフラグを変更
                上書き保存sToolStripMenuItem.Enabled = true;
            }
        }

        //上書き保存の処理を行うメソッド
        private void OverWriteSaveText()
        {
            //StreamWriterクラスのインスタンスを生成
            //コンストラクタに「現在開いているファイル名」、「false」、「エンコード」を指定
            //false = 上書き　true = 追記
            //エンコードはデフォルト値を使用
            using (StreamWriter sw = new StreamWriter(mf.file_name, false, Encoding.UTF8))
            {
                //開いているファイルにテキストボックスの内容を上書き保存
                sw.Write(this.txt_memo.Text);
                sw.Close();
                //テキストボックスの文字入力確認フラグを「未入力(保存済)」の状態に
                mf._isSaved = true;
            }
        }

        //テキストボックスの内容を保存するメソッド
        private void SaveTextAs()
        {
            //ファイルを保存するクラスのインスタンスを生成
            SaveFileDialog dialog = new SaveFileDialog();
            //テキストファイルのみ選択できるようフィルターを設定
            dialog.Filter = "テキストファイル(*.txt)|*.txt";
            //ダイアログのタイトルをメモ帳に設定
            dialog.Title = "名前をつけて保存";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //保存する場合
                //指定したファイルにテキストボックスの内容を保存
                File.WriteAllText(dialog.FileName, this.txt_memo.Text);
                //テキストボックスの文字入力確認フラグを「未入力(保存済)」の状態に
                mf._isSaved = true;
                //フィールド~file_name~を開いているファイル名に変更
                mf.file_name = dialog.FileName;
                //フォームのテキストを選択したファイル名に変更
                this.ChangeFormText();
                //上書き保存可能にフラグを変更
                this.上書き保存sToolStripMenuItem.Enabled = true;
            }
        }

        //メモ帳を閉じる処理を行うメソッド
        private void CloseMemo()
        {
            //テキストボックスの内容が未保存の場合
            if (mf._isSaved == false)
            {
                //ユーザーに保存せずに終了するか確認
                DialogResult result = MessageBox.Show("内容が保存されていません。保存せずに終了しますか？","メモ帳", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //内容を内容を保存しないで終了する場合
                    //終了
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    //内容を保存せずに終了したくない場合
                    //終了せずに戻る
                    return;
                }
            }
            //テキストボックスの内容が保存されている場合
            //そのまま閉じる
            this.Close();
        }

        //テキストボックスの内容を1つ元に戻す処理を行うメソッド
        private void UndoMemo()
        {
            if (txt_memo.CanUndo)
            {
                //Undoできるなら
                //テキストボックスの内容を1つ元に戻す
                this.txt_memo.Undo();
            }
        }

        //テキストボックスの選択しているテキスト情報を切り取る処理を行うメソッド
        private void CutText()
        {
            //テキストが選択されているか確認
            CheckSelectedFlg();

            if(this.切り取りXToolStripMenuItem.Enabled == true)
            {
                //テキストが選択されていたら
                //選択されているテキスト情報を切り取る
                this.txt_memo.Cut();
            }
        }

        //テキストボックスの選択しているテキスト情報をコピーする処理を行うメソッド
        private void CopyText()
        {
            //テキストが選択されているか確認
            this.CheckSelectedFlg();

            if(this.コピーCToolStripMenuItem.Enabled == true)
            {
                //テキストが選択されていたら
                //選択されているテキスト情報をコピーする
                this.txt_memo.Copy();
            }
        }

        //テキストボックスへクリップボード保持しているテキスト情報を貼り付ける処理を行うメソッド
        private void PasteText()
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                //クリップボードにテキスト情報を保持していたら
                //貼り付ける
                this.txt_memo.Paste();
            }
        }

        //テキストボックスの選択しているテキスト情報を削除するメソッド
        private void DeleteText(){
            //テキストが選択されているか確認
            this.CheckSelectedFlg();

            if(this.削除DToolStripMenuItem.Enabled == true)
            {
                //テキストが選択されていたら
                //選択されているテキストを消去
                this.txt_memo.SelectedText = String.Empty;
            }
        }



        //ショートカットキーを定義するメソッド
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //「新規作成」のショートカットキーを設定
            if ((e.KeyCode == Keys.N && e.Control) == true) { this.NewMemo(); }
            //「開く」のショートカットを設定
            if ((e.KeyCode == Keys.O && e.Control) == true) { this.OpenFile(); }
            //「上書き保存」のショートカットを設定
            if ((e.KeyCode == Keys.S && e.Control) == true) { this.OverWriteSaveText(); }
            //「元に戻す」のショートカットを設定
            if ((e.KeyCode == Keys.Z && e.Control) == true) { this.UndoMemo(); }
            //「切り取り」のショートカットを設定
            if ((e.KeyCode == Keys.X && e.Control) == true) { this.CutText(); }
            //「コピー」のショートカットを設定
            if ((e.KeyCode == Keys.C && e.Control) == true) { this.CopyText(); }
            //「貼り付け」のショートカットを設定
            if ((e.KeyCode == Keys.V && e.Control) == true) { this.PasteText(); }
        }



        //文字列選択時のみ使用できる機能のコントロールを切り替えるメソッド
        public void CheckSelectedFlg()
        {
            if (this.txt_memo.SelectedText != "")
            {
                //何かしらのテキストを選択している場合
                //各機能のコントロールを有効に切り替える
                this.切り取りXToolStripMenuItem.Enabled = true;
                this.コピーCToolStripMenuItem.Enabled = true;
                this.削除DToolStripMenuItem.Enabled = true;
            }
            else
            {
                //何も選択していない場合
                //各機能のコントロールを無効に切り替える
                this.切り取りXToolStripMenuItem.Enabled = false;
                this.コピーCToolStripMenuItem.Enabled = false;
                this.削除DToolStripMenuItem.Enabled = false;
            }
        }

        //ステータスバーを表示/非表示にするメソッド
        private void ShowStatusBar()
        {
            //ラベルのコントロールのtrue or falseを切り替え
            this.toolStripStatusLabel1.Enabled = !this.toolStripStatusLabel1.Enabled;
            
            if (this.toolStripStatusLabel1.Enabled == true)
            {
                //コントロールがtrueなら
                //ラベルに文字数を表示
                string text = string.Format("文字数{0}", this.txt_memo.Text.Length);
                this.toolStripStatusLabel1.Text = text;
            }
            else
            {
                //コントロールがfalseなら
                //ラベルテキストを消去
                this.toolStripStatusLabel1.Text = string.Empty;
            }
        }

        //フォントメニューを開くメソッド
        private void OpenFontMenu()
        {
            //FontDialogクラスのインスタンスを生成
            FontDialog fd = new FontDialog();

            //初期のフォントを設定
            fd.Font = txt_memo.Font;
            //初期の色を設定
            fd.Color = txt_memo.ForeColor;
            //ユーザーが選択できるポイントサイズの最大値を設定する
            fd.MaxSize = 15;
            fd.MinSize = 10;
            //存在しないフォントやスタイルをユーザーが選択すると
            //エラーメッセージを表示する
            fd.FontMustExist = true;
            //横書きフォントだけを表示する
            fd.AllowVerticalFonts = false;
            //色を選択できるようにする
            fd.ShowColor = true;
            //取り消し線、下線、テキストの色などのオプションを指定可能にする
            //デフォルトがTrueのため必要はない
            fd.ShowEffects = true;
            //固定ピッチフォント以外も表示する
            //デフォルトがFalseのため必要はない
            fd.FixedPitchOnly = false;
            //ベクタ フォントを選択できるようにする
            //デフォルトがTrueのため必要はない
            fd.AllowVectorFonts = true;

            //ダイアログを表示する
            if (fd.ShowDialog() != DialogResult.Cancel)
            {
                //TextBox1のフォントと色を変える
                txt_memo.Font = fd.Font;
                txt_memo.ForeColor = fd.Color;
            }
        }

        //ウェブページを開くメソッド
        private void OpenWebPage(String web_url) { System.Diagnostics.Process.Start(web_url); }
    }
}
