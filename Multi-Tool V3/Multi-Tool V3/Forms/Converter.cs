﻿using System;
using System.Windows.Forms;
using Multi_Tool_V3.Properties;

//@author xNovax

namespace Multi_Tool_V3
{
    public partial class Converter : Form
    {
        private readonly UsefulCode uc = new UsefulCode();
        private int fromSelected;
        private double fromValue;
        private int toSelected;

        public Converter()
        {
            InitializeComponent();
        }

        private void Converter_Load(object sender, EventArgs e)
        {
            string username = Settings.Default.username;
            usernameDisplay.Text = ("Logged in as: " + username);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            toComboBox.Items.Clear();
            if (fromComboBox.SelectedIndex == 0)
            {
                fromSelected = 0;
            }
            else
            {
                if (fromComboBox.SelectedIndex == 1)
                {
                    fromSelected = 1;
                }
                else
                {
                    if (fromComboBox.SelectedIndex == 2)
                    {
                        fromSelected = 2;
                    }
                    else
                    {
                        if (fromComboBox.SelectedIndex == 3)
                        {
                            fromSelected = 3;
                        }
                        else
                        {
                            if (fromComboBox.SelectedIndex == 4)
                            {
                                fromSelected = 4;
                            }
                            else
                            {
                                if (fromComboBox.SelectedIndex == 5)
                                {
                                    fromSelected = 5;
                                }
                                else
                                {
                                    if (fromComboBox.SelectedIndex == 6)
                                    {
                                        fromSelected = 6;
                                    }
                                    else
                                    {
                                        if (fromComboBox.SelectedIndex == 7)
                                        {
                                            fromSelected = 7;
                                        }
                                        else
                                        {
                                            if (fromComboBox.SelectedIndex == 8)
                                            {
                                                fromSelected = 8;
                                            }
                                            else
                                            {
                                                if (fromComboBox.SelectedIndex == 9)
                                                {
                                                    fromSelected = 9;
                                                }
                                                else
                                                {
                                                    if (fromComboBox.SelectedIndex == 10)
                                                    {
                                                        fromSelected = 10;
                                                    }
                                                    else
                                                    {
                                                        if (fromComboBox.SelectedIndex == 11)
                                                        {
                                                            fromSelected = 11;
                                                        }
                                                        else
                                                        {
                                                            if (fromComboBox.SelectedIndex == 12)
                                                            {
                                                                fromSelected = 12;
                                                            }
                                                            else
                                                            {
                                                                if (fromComboBox.SelectedIndex == 13)
                                                                {
                                                                    fromSelected = 13;
                                                                }
                                                                else
                                                                {
                                                                    uc.ErrorOccured(
                                                                        "You have selected an option that does not exist.");
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void fromValueTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            fromValueTextBox.Text = ("");
        }

        private void fromValueTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((fromValueTextBox.Text != ("")) ||
                ((fromValueTextBox.Text != ("0")) || (fromValueTextBox.Text != ("0.0"))))
            {
                fromValue = Convert.ToDouble(fromValueTextBox.Text);
            }
        }

        private void toComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fromSelected == 0)
            {
                if (toComboBox.SelectedIndex == 0)
                {
                }
                else
                {
                    if (toComboBox.SelectedIndex == 1)
                    {
                    }
                    else
                    {
                        if (toComboBox.SelectedIndex == 2)
                        {
                        }
                        else
                        {
                            if (toComboBox.SelectedIndex == 3)
                            {
                            }
                        }
                    }
                }
            }
            else
            {
                if (fromSelected == 1)
                {
                    if (toComboBox.SelectedIndex == 0)
                    {
                    }
                    else
                    {
                        if (toComboBox.SelectedIndex == 1)
                        {
                        }
                        else
                        {
                            if (toComboBox.SelectedIndex == 2)
                            {
                            }
                            else
                            {
                                if (toComboBox.SelectedIndex == 3)
                                {
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (fromSelected == 2)
                    {
                        if (toComboBox.SelectedIndex == 0)
                        {
                        }
                        else
                        {
                            if (toComboBox.SelectedIndex == 1)
                            {
                            }
                            else
                            {
                                if (toComboBox.SelectedIndex == 2)
                                {
                                }
                                else
                                {
                                    if (toComboBox.SelectedIndex == 3)
                                    {
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (fromSelected == 3)
                        {
                            if (toComboBox.SelectedIndex == 0)
                            {
                            }
                            else
                            {
                                if (toComboBox.SelectedIndex == 1)
                                {
                                }
                                else
                                {
                                    if (toComboBox.SelectedIndex == 2)
                                    {
                                    }
                                    else
                                    {
                                        if (toComboBox.SelectedIndex == 3)
                                        {
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (fromSelected == 4)
                            {
                                if (toComboBox.SelectedIndex == 0)
                                {
                                }
                                else
                                {
                                    if (toComboBox.SelectedIndex == 1)
                                    {
                                    }
                                    else
                                    {
                                        if (toComboBox.SelectedIndex == 2)
                                        {
                                        }
                                        else
                                        {
                                            if (toComboBox.SelectedIndex == 3)
                                            {
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (fromSelected == 5)
                                {
                                    if (toComboBox.SelectedIndex == 0)
                                    {
                                    }
                                    else
                                    {
                                        if (toComboBox.SelectedIndex == 1)
                                        {
                                        }
                                        else
                                        {
                                            if (toComboBox.SelectedIndex == 2)
                                            {
                                            }
                                            else
                                            {
                                                if (toComboBox.SelectedIndex == 3)
                                                {
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (fromSelected == 6)
                                    {
                                        if (toComboBox.SelectedIndex == 0)
                                        {
                                        }
                                        else
                                        {
                                            if (toComboBox.SelectedIndex == 1)
                                            {
                                            }
                                            else
                                            {
                                                if (toComboBox.SelectedIndex == 2)
                                                {
                                                }
                                                else
                                                {
                                                    if (toComboBox.SelectedIndex == 3)
                                                    {
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        uc.ErrorOccured("You have selected an option that does not exist.");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}