using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using TagLib;

namespace ファイルTAG情報変更ツール
{
    public partial class Form1 : Form
    {
        DataTable _dtExtensions = new DataTable();
        DataTable _dtFiles = new DataTable();
        DataTable _dtPattern = new DataTable();
        bool _isChange = false;
        Rectangle dragBox;      // MouseDown座標用
        int indexIdoMoto;       // 移動元Rowインデックス
        int indexIdoSaki;       // 移動先Rowインデックス

        /// <summary>
        /// イニシャライズ
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;
            btnSelectFolder.Visible = false;

            _dtExtensions.Columns.Add("combo_value", typeof(string));
            _dtExtensions.Columns.Add("extensions", typeof(string));
            _dtExtensions.TableName = "extensions";

            _dtPattern.Columns.Add("pattern", typeof(string));
            _dtPattern.Columns.Add("digits", typeof(string));
            _dtPattern.TableName = "pattern";

            List<string[]> lstExtensions = new List<string[]>()
            {
                new string[] { "動画ファイル", "*.mp4,*.m4v,*.mov,*.avi,*.mkv" },
                new string[] { "音楽ファイル", "*.wma,*.m4a,*.mp4,*.mp3,*.asf,*.3gp,*.3g2,*.aac,*.ogg,*.oga,*.tta,*.mka,*.mkv,*.flac,*.wav,*.aiff,*.aif,*.aifc" },
                new string[] { "画像ファイル", "*.jpg,*.jpeg,*.png,*.gif,*.ttf,*.tiff,*.psd,*.bmp,*.tga,*.xcf" },
                new string[] { "テキストファイル", "*.txt,*.csv" },
                new string[] { "圧縮ファイル", "*.zip,*.rar,*.lzh,*.7z,*.tar,*.tar.gz" },
                new string[] { "すべてのファイル", "*.*" }
            };

            List<string[]> lstPattern = new List<string[]>()
            {
                new string[] { "n_<File名>", "2,3,4" },
                new string[] { "n.<File名>", "2,3,4" },
                new string[] { "n. <File名>", "2,3,4" },
                new string[] { "<File名>_n", "2,3,4" },
                new string[] { "<File名>.n", "2,3,4" }
            };

            List<string> _dtFilesList = new List<string>()
            {
                "no", "path", "filename", "changedfilename", "title", "artist", "album", "albumartist", "trackno"
            };

            foreach (string s in _dtFilesList)
            {
                if (s == "no" || s == "trackno")
                {
                    _dtFiles.Columns.Add(s, typeof(int));
                }
                else
                {
                    _dtFiles.Columns.Add(s, typeof(string));
                }
            }
            _dtFiles.TableName = "files";

            foreach (string[] s in lstExtensions)
            {
                DataRow r = _dtExtensions.NewRow();
                r["combo_value"] = s[0];    // combo_value列
                r["extensions"] = s[1];    // extensions列
                _dtExtensions.Rows.Add(r);
            }

            foreach (string[] s in lstPattern)
            {
                DataRow r = _dtPattern.NewRow();
                r["pattern"] = s[0];
                r["digits"] = s[1];
                _dtPattern.Rows.Add(r);
            }

            SetComboBox(cmbTarget);
            SetComboBox(cmbPattern);

            SetDgvFiles();
        }


        /// <summary>
        /// ComboBoxのItemセット
        /// </summary>
        /// <param name="cmb">ComboBox</param>
        void SetComboBox(ComboBox cmb)
        {
            List<string> lst = new List<string>();
            string s = string.Empty;
            char[] chr = new char[] { ',' };
            DataTable _dt = new DataTable();

            if (cmb == cmbTarget || cmb == cmbPattern)
            {
                _dt = cmb == cmbTarget ? _dtExtensions : _dtPattern;
                lst = _dt.AsEnumerable().Select(x => x[_dt.Columns[0].ToString()].ToString()).ToList();
                cmb.Items.AddRange(lst.ToArray());
            }
            else
            {
                _dt = cmb == cmbExtensions ? _dtExtensions : _dtPattern;
                lst = _dt.Select(String.Format("{0}={1}", _dt.Columns[0].ToString(), cmb.Text))[0][1].ToString().Split(chr).ToList();
                cmb.Items.Clear();
                cmb.Items.AddRange(lst.ToArray());
            }

        }

        /// <summary>
        /// DataGridViewのカラムセット
        /// </summary>
        void SetDgvFiles()
        {
            dgvFiles.DataSource = null;
            Thread.Sleep(10);

            dgvFiles.DataSource = _dtFiles;

            List<string> _dtFilesColumnValues = new List<string>()
            {
                "連番", "パス", "ファイル名", "変更後ファイル名", "タイトル", "アーティスト", "アルバム名", "アルバムアーティスト", "トラック"
            };
            List<int> _ColumnWidths = new List<int>() { 65, 0, 300, 300, 200, 175, 175, 175, 95 };

            for (int i = 0; i < _dtFilesColumnValues.Count; i++)
            {
                dgvFiles.Columns[i].HeaderText = _dtFilesColumnValues[i];
                if (_ColumnWidths[i] == 0)
                {
                    dgvFiles.Columns[i].Visible = false;
                }
                else
                {
                    dgvFiles.Columns[i].Width = _ColumnWidths[i];
                    dgvFiles.Columns[i].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
                }
                dgvFiles.Columns[i].Frozen = false;
                if (i == 0) dgvFiles.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            dgvFiles.Font = pnlList.Font;
            dgvFiles.Refresh();
        }

        /// <summary>
        /// フォルダ名TextBox[txtFolder]にフォーカスがセットされたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFolder_Enter(object sender, EventArgs e)
        {
            btnSelectFolder.Visible = true;
        }

        /// <summary>
        /// フォルダ名TextBox[txtFolder]からフォーカスがはなれたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFolder_Leave(object sender, EventArgs e)
        {
            if (!btnSelectFolder.Focused) btnSelectFolder.Visible = false;
        }

        /// <summary>
        /// 閉じるボタン[btnExit]が押されたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (_isChange)
            {
                if (MessageBox.Show("変更点をもとにファイル情報を変更しますか？") == DialogResult.OK)
                {

                }
            }
            this.Dispose();
        }

        /// <summary>
        /// フォルダ選択ボタン[btnSelectFolder]がクリックされたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.RootFolder = Environment.SpecialFolder.Desktop;
                if (txtFolder.Text.Length > 0 && Directory.Exists(txtFolder.Text))
                {
                    dlg.SelectedPath = txtFolder.Text;
                }
                dlg.Description = "フォルダを選択してください。";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtFolder.Text = dlg.SelectedPath;
                }
            }
            txtFolder.Focus();
        }

        /// <summary>
        /// 開くボタン[btnOpenFolder]がクリックされたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            //if (cmbExtensions.Text == string.Empty) return;

            _dtFiles.Clear();
            string[] _filenames = null;

            if (cmbExtensions.Text != string.Empty)
            {
                _filenames = Directory.GetFiles(txtFolder.Text, cmbExtensions.Text);
            }
            else
            {
                string[] exts = _dtExtensions.Select(String.Format("combo_value='{0}'", cmbTarget.Text))[0]["extensions"].ToString().Split(new char[] { ',' });
                string ext = string.Empty;
                for (int i = 0; i < exts.Length; i++)
                {
                    if (i == 0) { ext = @".\" + exts[i]; } else { ext = ext + @"|.\" + exts[i]; }
                }
                ext = ext.Replace("*", "");
                Regex _reg = new Regex(ext);
                _filenames = (from file in Directory.GetFiles(txtFolder.Text) where _reg.IsMatch(file) select file).ToArray();
            }

            int no = 1;
            foreach (string f in _filenames)
            {

                DataRow r = _dtFiles.NewRow();

                r["no"] = no;
                r["path"] = Path.GetFullPath(f);
                r["filename"] = Path.GetFileName(f);

                try
                {
                    using (TagLib.File _mp3 = TagLib.File.Create(f))
                    {

                        r["title"] = _mp3.Tag.Title;
                        r["artist"] = _mp3.Tag.Performers.FirstOrDefault() ?? "";
                        r["album"] = _mp3.Tag.Album;
                        r["albumartist"] = _mp3.Tag.AlbumArtists.FirstOrDefault() ?? "";
                        r["trackno"] = _mp3.Tag.Track;
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                r["changedfilename"] = string.Empty;
                _dtFiles.Rows.Add(r);
                Thread.Sleep(10);
                no++;

            }

            SetDgvFiles();
        }

        /// <summary>
        /// DataGridView[dgvFIles]のセルがクリックされたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvFiles.CurrentRow;

            if (row == null) return;
            DataRowView v = (DataRowView)row.DataBoundItem;
            DataRow r = (DataRow)v.Row;
            txtFilename.Text = r["filename"].ToString();
            txtTitle.Text = r["title"].ToString();
            txtAlbum.Text = r["album"].ToString();
            txtArtists.Text = r["artist"].ToString();
            txtAlbumArtists.Text = r["albumartist"].ToString();
            txtTrackNO.Text = r["trackno"].ToString();

            try
            {
                TagLib.File _file = TagLib.File.Create(Path.Combine(txtFolder.Text, txtFilename.Text));
                picImage.SizeMode = PictureBoxSizeMode.Zoom;

                if (_file.Tag.Pictures.Length >= 1)
                {
                    byte[] bin = (byte[])(_file.Tag.Pictures[0].Data.Data);
                    picImage.Image = System.Drawing.Image.FromStream(new MemoryStream(bin));
                }
                else
                {
                    picImage.Image = Properties.Resources.NO_IMAGE;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// DataGridView[dgvFiles]内でマウスが動いた時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFiles_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (dragBox != Rectangle.Empty && !(dragBox.Contains(e.X, e.Y)))
                {
                    DragDropEffects dragEffect = dgvFiles.DoDragDrop(dgvFiles.Rows[indexIdoMoto], DragDropEffects.Move);
                }
            }
        }

        /// <summary>
        /// DataGridView[dgvFiles]内でマウスボタンが押されたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFiles_MouseDown(object sender, MouseEventArgs e)
        {
            indexIdoMoto = dgvFiles.HitTest(e.X, e.Y).RowIndex;

            // ヘッダ以外
            if (indexIdoMoto > -1)
            {
                var dragSize = SystemInformation.DragSize;

                // ドラッグ操作が開始されない範囲を取得
                dragBox = new Rectangle(new Point(e.X - dragSize.Width / 2, e.Y - dragSize.Height / 2), dragSize);
            }
            else
            {
                dragBox = Rectangle.Empty;
            }
        }

        /// <summary>
        /// DataGridView[dgvFiles]内でのドラッグを終えたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFiles_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// DataGridView[dgvFiles]内でドラッグされたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFiles_DragDrop(object sender, DragEventArgs e)
        {
            // データグリッドのポイントを取得  
            Point clientPoint = dgvFiles.PointToClient(new Point(e.X, e.Y));

            // 移動先インデックス
            indexIdoSaki = dgvFiles.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // ドラッグ＆ドロップ効果【移動】の場合・Index範囲内の場合
            if (e.Effect == DragDropEffects.Move && indexIdoSaki > -1)
            {
                Object[] rowArray = _dtFiles.Rows[indexIdoMoto].ItemArray;
                DataRow row = _dtFiles.NewRow();
                row.ItemArray = rowArray;
                _dtFiles.Rows.RemoveAt(indexIdoMoto);       // 移動元削除
                _dtFiles.Rows.InsertAt(row, indexIdoSaki);  // 移動先新規行挿入
            }
        }

        /// <summary>
        /// DataGridView[dgvFiles]のセルがダブルクリックされたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                dgvFiles.ReadOnly = false;
                dgvFiles.BeginEdit(true);
            }
        }

        /// <summary>
        /// ファイル情報変更ボタン[btnChangeFileInfo]ボタンがクリックされたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeFileInfo_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in _dtFiles.Rows)
            {
                string path = row["path"].ToString();
                string folder = Path.GetDirectoryName(path);
                string filename = row["changedfilename"].ToString() != null ? row["changedfilename"].ToString() : row["filename"].ToString();
                string newPath = Path.Combine(folder, filename);

                try
                {
                    using (TagLib.File tf = TagLib.File.Create(path))
                    {
                        tf.Tag.Title = row["title"].ToString();
                        tf.Tag.Performers = new string[] { row["artist"].ToString() };
                        tf.Tag.Album = row["album"].ToString();
                        tf.Tag.AlbumArtists = new string[] { row["albumartist"].ToString() };
                        tf.Tag.Track = Convert.ToUInt32(row["trackno"].ToString());
                        tf.Save();
                    }
                }
                catch(Exception ex) { Console.WriteLine(ex.Message); }

                if (path != newPath) System.IO.File.Move(path, newPath);
                Thread.Sleep(10);
            }

            MessageBox.Show("ファイル情報の一括書き込みが終わりました。", "ファイル情報一括書き込み", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 番号再振ボタン[btnReNumber]が押されたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReNumber_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvFiles.Rows.Count; i++)
            {
                dgvFiles.Rows[i].Cells[0].Value = i + 1;
            }
        }

        /// <summary>
        /// ファイル名連番付与ボタン[btnChangeFilenameWithNumber]がクリックされたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeFilenameWithNumber_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in _dtFiles.Rows)
                {
                    Regex reg = new Regex(@"^\d?\d?\d?\d[._]");
                    int digit = int.Parse(cmbDigit.Text.Replace("桁", ""));

                    string _ext = Path.GetExtension(row["path"].ToString());
                    string _basename = row["filename"].ToString().Replace(_ext, string.Empty);
                    string _no = String.Format("{0:D" + digit + "}", int.Parse(row["no"].ToString()));
                    row["changedfilename"] = cmbPattern.Text.Replace("n", _no).Replace("<File名>", reg.Replace(_basename, "").Trim()) + _ext;
                }
                dgvFiles.Refresh();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// トラック番号再振[btnTrackNoReNumber]がクリックされたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrackNoReNumber_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in _dtFiles.Rows)
                {
                    int no = int.Parse(row["no"].ToString());
                    row["trackno"] = no;
                }
                dgvFiles.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 統一するボタン[btnItemUnification]がクリックされたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnItemUnification_Click(object sender, EventArgs e)
        {
            string item = string.Empty;
            string value = string.Empty;

            try
            {
                switch (cmbItemUnification.Text)
                {
                    case "アーティスト":
                        item = "artist";
                        value = txtArtists.Text;
                        break;

                    case "アルバム名":
                        item = "album";
                        value = txtAlbum.Text;
                        break;

                    case "アルバムアーティスト":
                        item = "albumartist";
                        value = txtAlbumArtists.Text;
                        break;
                }

                foreach (DataRow row in _dtFiles.Rows)
                {
                    row[item] = value;
                }
                dgvFiles.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// コンボボックス[cmbTarget]の値が変更されたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTarget_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            if (cmb.Text != string.Empty)
            {
                DataRow[] rows = _dtExtensions.Select(String.Format("combo_value='{0}'", cmb.Text));
                char[] chr = new char[] { ',' };
                string[] exts = rows[0]["extensions"].ToString().Split(chr);

                cmbExtensions.Items.Clear();
                foreach (string ext in exts)
                {
                    cmbExtensions.Items.Add(ext);
                }
            }
        }

        /// <summary>
        /// タイトルTextBox[txtTitle]のテキストが変更されたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            dgvFiles.CurrentRow.Cells[3].Value = txtTitle.Text;
        }

        /// <summary>
        /// コンボボックス[cmbPattern]の値が変更されたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPattern_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            if (cmb.Text != string.Empty)
            {
                DataRow[] rows = _dtPattern.Select(String.Format("pattern='{0}'", cmb.Text));
                char[] chr = new char[] { ',' };
                string[] digits = rows[0]["digits"].ToString().Split(chr);

                cmbDigit.Items.Clear();
                foreach (string digit in digits)
                {
                    cmbDigit.Items.Add(digit+"桁");
                }
            }
        }
    }
}
