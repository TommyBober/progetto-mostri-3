﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClassi
{
    public partial class Form1 : Form
    {
        private List<Monster> monsters;

        public Form1()
        {
            InitializeComponent();
            monsters = Deserializer.deserializeMonsters();

            foreach (Monster m in monsters)
            {
                Console.WriteLine(m.GetType());
                if (m.GetType() == typeof(Fire_Monster))
                {
                    Fire_Monster f = m as Fire_Monster;
                    Console.WriteLine(f.fireDamage);
                }
                //Console.WriteLine(m.fire);
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(monsters[0].describe());
        }

        private Monster addMonster(Monster m)
        {
            monsters.Add(m);
            return m;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
