using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private FileManger _fm;
        private List<Models.ShopVM> _mainList;
        private int _count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShopVM nShop = null;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Пусте поле!");
            }
            else
            {
                string new_name = textBox2.Text;
                int new_id = int.Parse(textBox1.Text);
                string new_street = textBox3.Text;
                int new_num = int.Parse(textBox4.Text);

               nShop = new ShopVM(new_name, new_id, new_street, new_num);
            }
            

            try
            {
                _mainList.Add(nShop);
                _fm.WriteToJsonFile<List<ShopVM>>(_mainList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void DisplayInf(int count)
        {
            ShopVM tempShop = _mainList[count];
            TextBoxNum.Text = tempShop.Id.ToString();
            TextBoxName.Text = tempShop.Name;
            TextBoxAddres.Text = tempShop.address.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _fm = new FileManger();
            _mainList = new List<Models.ShopVM>();
            _mainList = _fm.ReadFromJsonFile<ShopVM>();

            button3.Enabled = false;

            if (_mainList.Count>0)
            {
                DisplayInf(0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            button3.Enabled=true;
            _count++;
            DisplayInf(_count);
            if (_count == _mainList.Count-1)
            {
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            _count--;
            DisplayInf(_count);
            if (_count == 0)
            {
                button3.Enabled = false;
            }
        }
    }
}
