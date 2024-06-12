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
    public partial class AddProductForm : Form
    {
        private readonly string _path;
        private readonly List<Material> _materials;
        private readonly List<Shape> _shapes;
        private readonly List<string> _colors;
        private List<FreeIntercom> _freeIntercom;


        public AddProductForm(List<Material> materials, List<Shape> shapes, List<string> colors, List<FreeIntercom> freeIntercom, string path)
        {
            _materials = materials;
            _shapes = shapes;
            _colors = colors;
            _freeIntercom = freeIntercom;
            _path = path;
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            foreach (Material material in _materials)
                MaterialComboBox.Items.Add(material.Name);
            foreach (Shape shape in _shapes)
                ShapeComboBox.Items.Add(shape.Name);
            foreach (string color in _colors)
                ColorComboBox.Items.Add(color);

            LoadDataFromBinaryFile();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result =MessageBox.Show("Вы уверены?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void Approve_Click(object sender, EventArgs e)
        {
            string caption;
            Shape shape = null;
            Material material = null;
            string color = null;

            //Проверка на надпись
            if (CaptionTextBox.Text == string.Empty)
                caption = "Intercom";
            else
                caption = CaptionTextBox.Text;

            //Проверка на тип домофона
            if (ShapeComboBox.SelectedIndex != -1)
            {
                foreach (Shape _shape in _shapes)
                    if (_shape.Name == ShapeComboBox.Items[ShapeComboBox.SelectedIndex].ToString())
                        shape = _shape;
            }
            else
            {
                MessageBox.Show("Вы не выбрали тип");
                return;
            }
            //Проверка на материал

            if (MaterialComboBox.SelectedIndex != -1)
            {
                foreach (Material _material in _materials)
                    if (_material.Name == MaterialComboBox.Items[MaterialComboBox.SelectedIndex].ToString())
                        material = _material;
            }
            else
            {
                MessageBox.Show("Вы не выбрали материал");
                return;
            }

            //Проверка на цвет
            if (ColorComboBox.SelectedIndex != -1)
            {
                foreach (string _color in _colors)
                    if (_color == ColorComboBox.Items[ColorComboBox.SelectedIndex].ToString())
                        color = _color;
            }
            else
            {
                MessageBox.Show("Вы не выбрали цвет");
                return;
            }

            _freeIntercom.Add(new FreeIntercom(caption, shape, material, color));
            SaveDataToBinaryFile();
            MessageBox.Show("Вы успешно добавили товар!");
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
}
