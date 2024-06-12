using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntercomWindowsForms
{
    public partial class MainForm : Form
    {
        private readonly string _path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\IntercomWinForms";
        private List<Material> _materials;
        private List<Shape> _shapes;
        private List<string> _colors;

        private List<FreeIntercom> _freeIntercom = new List<FreeIntercom>();
        private int _autoIncrement = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(_path);
            LoadDataFromBinaryFile();
            UpdateList();

            _materials = new List<Material>()
            {
                new Material("Пластик", 1000),
                new Material("Алюминий", 2000),
                new Material("Сталь", 2500)
            };

            _shapes = new List<Shape>()
            {
                new Shape("Аудиодомофон", 3000),
                new Shape("Видеодомофон", 7000)
            };

            _colors = new List<string>()
            {
                "неокрашенный",
                "чёрный",
                "белый",
                "жёлтый",
                "зелёный",
                "фиолетовый"
            };
        }

        private void UpdateList()
        {
            IntercomList.Items.Clear();

            foreach (FreeIntercom freeIntercom in _freeIntercom)
                IntercomList.Items.Add($"{freeIntercom.Shape} ({freeIntercom.Material}, {freeIntercom.Color}, подпись: {freeIntercom.Caption}, {freeIntercom.Price}руб)");
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm(_materials, _shapes, _colors, _freeIntercom, _path);
            form.Show();
            form.FormClosing += Form_FormClosing;
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IntercomList.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали товар", "Ошибка");
                return;
            }

            EditProductForm form = new EditProductForm(IntercomList.SelectedIndex, _materials, _shapes, _colors, _freeIntercom, _path);
            form.Show();
            form.FormClosing += Form_FormClosing;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IntercomList.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали товар", "Ошибка");
                return;
            }

            DialogResult result = MessageBox.Show("Вы уверены?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                _freeIntercom.RemoveAt(IntercomList.SelectedIndex);

            SaveDataToBinaryFile();
            UpdateList();
        }

        private void ByPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_autoIncrement % 2 == 0)
                _freeIntercom = _freeIntercom.OrderBy(x => x.Price).ToList();
            else
                _freeIntercom = _freeIntercom.OrderByDescending(x => x.Price).ToList();

            SaveDataToBinaryFile();
            UpdateList();
        }

        private void ByShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_autoIncrement % 2 == 0)
                _freeIntercom = _freeIntercom.OrderBy(x => x.Shape).ToList();
            else
                _freeIntercom = _freeIntercom.OrderByDescending(x => x.Shape).ToList();

            SaveDataToBinaryFile();
            UpdateList();
        }

        private void ByMateraialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_autoIncrement % 2 == 0)
                _freeIntercom = _freeIntercom.OrderBy(x => x.Material).ToList();
            else
                _freeIntercom = _freeIntercom.OrderByDescending(x => x.Material).ToList();

            SaveDataToBinaryFile();
            UpdateList();
        }

        private void ByColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_autoIncrement % 2 == 0)
                _freeIntercom = _freeIntercom.OrderBy(x => x.Color).ToList();
            else
                _freeIntercom = _freeIntercom.OrderByDescending(x => x.Color).ToList();

            SaveDataToBinaryFile();
            UpdateList();
        }

        private void ByCaptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_autoIncrement % 2 == 0)
                _freeIntercom = _freeIntercom.OrderBy(x => x.Caption).ToList();
            else
                _freeIntercom = _freeIntercom.OrderByDescending(x => x.Caption).ToList();

            SaveDataToBinaryFile();
            UpdateList();
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadDataFromBinaryFile();
            UpdateList();
        }
        private void LoadDataFromBinaryFile()
        {
            if (File.Exists($@"{_path}\intercom_data.dat"))
            {
                using (FileStream fileStream = new FileStream($@"{_path}\intercom_data.dat", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    _freeIntercom = (List<FreeIntercom>)formatter.Deserialize(fileStream);
                }
            }
        }
        private void SaveDataToBinaryFile()
        {
            using (FileStream fileStream = new FileStream($@"{_path}\intercom_data.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, _freeIntercom);
            }
        }
    }

    [Serializable]
    public class FreeIntercom : Intercom
    {
        public FreeIntercom(string caption, Shape shape, Material material, string color) : base(caption, shape, material, color) { }
    }
}
