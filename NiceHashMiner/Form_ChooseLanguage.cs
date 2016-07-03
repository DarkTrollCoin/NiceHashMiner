﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NiceHashMiner
{
    public partial class Form_ChooseLanguage : Form
    {
        public Form_ChooseLanguage()
        {
            InitializeComponent();

            // Add language selections list
            Dictionary<int, string> lang = International.GetAvailableLanguages();

            comboBox_Languages.Items.Clear();
            for (int i = 0; i < lang.Count; i++)
            {
                comboBox_Languages.Items.Add(lang[i]);
            }

            comboBox_Languages.SelectedIndex = 0;

            label_Instruction.Location = new Point((this.Width - label_Instruction.Size.Width) / 2, label_Instruction.Location.Y);
            button_OK.Location = new Point((this.Width - button_OK.Size.Width) / 2, button_OK.Location.Y);
            comboBox_Languages.Location = new Point((this.Width - comboBox_Languages.Size.Width) / 2, comboBox_Languages.Location.Y);
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Config.ConfigData.Language = comboBox_Languages.SelectedIndex;
            this.Close();
        }
    }
}
