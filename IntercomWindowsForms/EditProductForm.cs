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
    public partial class EditProductForm : Form
    {
        private readonly int _selectedIntercomIndex;
        private readonly string _path;
        private readonly List<Material> _materials;
        private readonly List<Shape> _shapes;
        private readonly List<string> _colors;
        private List<FreeIntercom> _freeIntercom;
        public EditProductForm(int selectedIntercomIndex, List<Material> materials, List<Shape> shapes, List<string> colors, List<FreeIntercom> freeIntercom, string path)
        {
            _selectedIntercomIndex = selectedIntercomIndex;
            _materials = materials;
            _shapes = shapes;
            _colors = colors;
            _freeIntercom = freeIntercom;
            _path = path;
            InitializeComponent();
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            LoadDataFromBinaryFile();

            foreach (Material material in _materials)
                MaterialComboBox.Items.Add(material.Name);
            foreach (Shape shape in _shapes)
                ShapeComboBox.Items.Add(shape.Name);
            foreach (string color in _colors)
                ColorComboBox.Items.Add(color);

            foreach (Material material in _materials)
                if(material.Name == _freeIntercom[_selectedIntercomIndex].Material)
                    MaterialComboBox.SelectedIndex = MaterialComboBox.Items.IndexOf(material.Name);

            foreach (Shape shape in _shapes)
                if(shape.Name == _freeIntercom[_selectedIntercomIndex].Shape)
                    ShapeComboBox.SelectedIndex = ShapeComboBox.Items.IndexOf(shape.Name);

            foreach (string color in _colors)
                if(color == _freeIntercom[_selectedIntercomIndex].Color)
                    ColorComboBox.SelectedIndex = ColorComboBox.Items.IndexOf(color);

            CaptionTextBox.Text = _freeIntercom[_selectedIntercomIndex].Caption;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

            _freeIntercom[_selectedIntercomIndex]= new FreeIntercom(caption, shape, material, color);
            SaveDataToBinaryFile();
            MessageBox.Show("Вы успешно изменили товар!");
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
