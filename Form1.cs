using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Шаверма_мейкер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.radioButton_lavash.Checked = true; //по умолчанию лаваш
            this.radioButton_chiken.Checked = true; //по умолчанию курица
            this.radioButton_s_classic.Checked = true; //по умолчанию класический соус
            this.radioButton_s_middel.Checked = true; //по умолчанию нормальная осттрата

        }

        double summ = 0; //стоимость шамвермы
        int ost = 0; //шкала остроты (счётчик)

        //выбор основы
        private void radioButton_lavash_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_lavash.Checked == true)
            {
                summ = summ + 30;
                this.label3.Text = $"{summ}";
                this.pictureBox_lavash.Visible = true;
            }
            else
            {
                summ = summ - 30;
                this.label3.Text = $"{summ}";
                this.pictureBox_lavash.Visible = false;
            }
        } //лаваш

        private void radioButton_pita_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_pita.Checked == true)
            {
                summ = summ + 15;
                this.label3.Text = $"{summ}";
                this.pictureBox_pita.Visible = true;
            }
            else
            {
                summ = summ - 15;
                this.label3.Text = $"{summ}";
                this.pictureBox_pita.Visible = false;
            }
        } //пита

        private void radioButton_tarelka_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_lavash.Checked == true)
            {
                summ = summ + 50;
                this.label3.Text = $"{summ}";
                this.pictureBox_tarelka.Visible = true;
            }
            else
            {
                summ = summ - 50;
                this.label3.Text = $"{summ}";
                this.pictureBox_tarelka.Visible = false;
            }
        } //тарелка

        //выбор мяса
        private void radioButton_chiken_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_chiken.Checked == true)
            {
                summ = summ + 30;
                this.label3.Text = $"{summ}";
                this.pictureBox_chiken.Visible = true;
            }
            else
            {
                summ = summ - 30;
                this.label3.Text = $"{summ}";
                this.pictureBox_chiken.Visible = false;
            }
        } //курица

        private void radioButton_pork_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_pork.Checked == true)
            {
                summ = summ + 15;
                this.label3.Text = $"{summ}";
                this.pictureBox_pork.Visible = true;
            }
            else
            {
                summ = summ - 15;
                this.label3.Text = $"{summ}";
                this.pictureBox_pork.Visible = false;
            }
        } //говядина

        private void radioButton_mutton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_mutton.Checked == true)
            {
                summ = summ + 40;
                this.label3.Text = $"{summ}";
                this.pictureBox_mutton.Visible = true;
            }
            else
            {
                summ = summ - 40;
                this.label3.Text = $"{summ}";
                this.pictureBox_mutton.Visible = false;
            }
        } //свинина

        //выбор соуса
        private void radioButton_s_classic_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_classic.Checked == true)
            {
                summ = summ + 25;
                this.label3.Text = $"{summ}";
                this.pictureBox_classic.Visible = true;
            }
            else
            {
                summ = summ - 25;
                this.pictureBox_classic.Visible = false;
                this.label3.Text = $"{summ}";
            }
        } //классический

        private void radioButton_s_cheesy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_cheesy.Checked == true)
            {
                summ = summ + 30;
                this.label3.Text = $"{summ}";
                this.pictureBox1_cheesy.Visible = true;
            }
            else
            {
                summ = summ - 30;
                this.label3.Text = $"{summ}";
                this.pictureBox1_cheesy.Visible = false;
            }
        } //сырный

        private void radioButton_s_bbq_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_bbq.Checked == true)
            {
                summ = summ + 35;
                this.label3.Text = $"{summ}";
                this.pictureBox_bbq.Visible = true;
            }
            else
            {
                summ = summ - 35;
                this.label3.Text = $"{summ}";
                this.pictureBox_bbq.Visible = false;
            }
        } //bbq

        private void radioButton_s_adjeka_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_adjeka.Checked == true)
            {
                summ = summ + 40;
                this.groupBox_s_conf.Visible = true;
                this.pictureBox_adjika.Visible = true;
                this.label3.Text = $"{summ}";
            }
            else
            {
                this.groupBox_s_conf.Visible = false;
                summ = summ - 40;
                this.pictureBox_adjika.Visible = false;
                this.label3.Text = $"{summ}";
            }
        } //аджика

        private void radioButton_s_1000island_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_1000island.Checked == true)
            {
                summ = summ + 35;
                this.pictureBox_1000island.Visible = true;
                this.label3.Text = $"{summ}";
            }
            else
            {
                summ = summ - 35;
                this.pictureBox_1000island.Visible = false;
                this.label3.Text = $"{summ}";
            }
        } //1000 островов

        private void radioButton_s_acute_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_acute.Checked == true)
            {
                summ = summ + 40;
                this.groupBox_s_conf.Visible = true;
                this.pictureBox_super.Visible = true;
                this.label3.Text = $"{summ}";
            }
            else
            {
                this.groupBox_s_conf.Visible = false;
                this.pictureBox_super.Visible = false;
                summ = summ - 30;
                this.label3.Text = $"{summ}";
            }
        } //острый

        //допинги

        private void checkBox_cucumber_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cucumber.Checked == true)
            {
                summ = summ + 30;
                this.numericUpDown1.Visible = true;
                this.pictureBox_cucumber.Visible = true;
                this.label3.Text = $"{summ}";
            }
            else
            {
                summ = summ - 30;
                this.numericUpDown1.Visible = false;
                this.label3.Text = $"{summ}";
                this.pictureBox_cucumber.Visible = false;
            }
        } //огурцы
        private void checkBox_pickies_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pickies.Checked == true)
            {
                summ = summ + 30;
                this.numericUpDown2.Visible = true;
                this.label3.Text = $"{summ}";
                this.pictureBox_pickies.Visible = true;
            }
            else
            {
                summ = summ - 30;
                this.numericUpDown2.Visible = false;
                this.label3.Text = $"{summ}";
                this.pictureBox_pickies.Visible = false;
            }
        } //маринованый огурцы
        private void checkBox_tomato_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_tomato.Checked == true)
            {
                summ = summ + 30;
                this.numericUpDown3.Visible = true;
                this.label3.Text = $"{summ}";
                this.pictureBox_tomato.Visible = true;
            }
            else
            {
                summ = summ - 30;
                this.numericUpDown3.Visible = false;
                this.label3.Text = $"{summ}";
                this.pictureBox_tomato.Visible = false;
            }
        } //помидоры
        private void checkBox_sauerkraut_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sauerkraut.Checked == true)
            {
                summ = summ + 35;
                this.numericUpDown4.Visible = true;
                this.label3.Text = $"{summ}";
                this.pictureBox_sauerkraut.Visible = true;
            }
            else
            {
                summ = summ - 35;
                this.numericUpDown4.Visible = false;
                this.label3.Text = $"{summ}";
                this.pictureBox_sauerkraut.Visible = false;
            }
        } //квашеная капуста
        private void checkBox_carrot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_carrot.Checked == true)
            {
                summ = summ + 30;
                this.numericUpDown5.Visible = true;
                this.label3.Text = $"{summ}";
                this.pictureBox_carrot.Visible = true; 
            }
            else
            {
                summ = summ - 30;
                this.numericUpDown5.Visible = false;
                this.label3.Text = $"{summ}";
                this.pictureBox_carrot.Visible = false;
            }
        } //марковка
        private void checkBox_jalapenos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_jalapenos.Checked == true)
            {
                summ = summ + 35;
                this.numericUpDown6.Visible = true;
                this.label3.Text = $"{summ}";
                this.pictureBox_jalapenos.Visible = true;
            }
            else
            {
                summ = summ - 35;
                this.numericUpDown6.Visible = false;
                this.label3.Text = $"{summ}";
                this.pictureBox_jalapenos.Visible = false;
            }
        } //халопенью
        private void checkBox_salad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_salad.Checked == true)
            {
                summ = summ + 25;
                this.numericUpDown7.Visible = true;
                this.label3.Text = $"{summ}";
                this.pictureBox_salad.Visible = true;
            }
            else
            {
                summ = summ - 25;
                this.numericUpDown7.Visible = false;
                this.label3.Text = $"{summ}";
                this.pictureBox_salad.Visible = false;
            }
        } //салатный лист
        private void checkBox_bell_pepper_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_bell_pepper.Checked == true)
            {
                summ = summ + 35;
                this.numericUpDown8.Visible = true;
                this.label3.Text = $"{summ}";
            }
            else
            {
                summ = summ - 35;
                this.numericUpDown8.Visible = false;
                this.label3.Text = $"{summ}";
            }

        } //болгарский перец
        private void checkBox_dill_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dill.Checked == true)
            {                
                this.numericUpDown9.Visible = true;
                summ = summ + (25 * Convert.ToInt32(this.numericUpDown9.Value));
                this.label3.Text = $"{summ}";
            }
            else
            {
                this.numericUpDown9.Visible = false;
                summ = summ - (25 * Convert.ToInt32(this.numericUpDown9.Value));
                this.label3.Text = $"{summ}";
            }
        } //укроп
        private void checkBox_onion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_onion.Checked == true)
            {
                summ = summ + 25;
                this.numericUpDown10.Visible = true;
                this.label3.Text = $"{summ}";
            }
            else
            {
                summ = summ - 25;
                this.numericUpDown10.Visible = false;
                this.label3.Text = $"{summ}";
            }
        } //лук

        //острота соуса
        private void radioButton_s_min_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_min.Checked == true)
            {
                summ = summ + 5;
                ost++;
                this.label3.Text = $"{summ}";
            }
            else
            {
                summ = summ - 5;
                ost--;
                this.label3.Text = $"{summ}";
            }
        } //слабо

        private void radioButton_s_middel_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_middel.Checked == true)
            {
                summ = summ + 10;
                ost = ost + 2;
                this.label3.Text = $"{summ}";
            }
            else
            {
                summ = summ - 10;
                ost = ost - 2;
                this.label3.Text = $"{summ}";
            }         
        } //нормально

        private void radioButton_s_high_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_high.Checked == true)
            {
                summ = summ + 15;
                ost = ost + 3;
                this.label3.Text = $"{summ}";
            }
            else
            {
                summ = summ - 15;
                ost = ost - 3;
                this.label3.Text = $"{summ}";
            }            
        } //сильно

        private void radioButton_s_super_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_super.Checked == true)
            {
                summ = summ + 20;
                ost = ost + 4;
                this.label3.Text = $"{summ}";
            }
            else
            {
                summ = summ - 20;
                ost = ost + 4;
                this.label3.Text = $"{summ}";
            }          
        } //огненно

        //тут будет выбор колличества допинга
        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {

        } 

        //это для контекстного меню
        private void готовыеВариантыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.готовыеВариантыToolStripMenuItem.Checked == true)
            {
                this.groupBox_main.Visible = true;
            }
            else
            {
                this.groupBox_main.Visible = false;
            }
        }
        private void готовыеВариантыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.готовыеВариантыToolStripMenuItem1.Checked == true)
            {
                this.groupBox_main.Visible = true;
            }
            else
            {
                this.groupBox_main.Visible = false;
            }
        }

        //готовые рецепты
        private void radioButton_main_classic_CheckedChanged(object sender, EventArgs e) 
        {
            this.radioButton_lavash.Checked = true;
            this.radioButton_chiken.Checked = true;
            this.radioButton_s_classic.Checked = true;
            this.checkBox_cucumber.Checked = true;
            this.checkBox_salad.Checked = true;
            this.checkBox_tomato.Checked = true;
            this.checkBox_onion.Checked = true;
            this.checkBox_pickies.Checked = true;
        } //рецепт класической

        private void radioButton_main_cheesy_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButton_lavash.Checked = true;
            this.radioButton_chiken.Checked = true;
            this.radioButton_s_cheesy.Checked = true;
            this.checkBox_cucumber.Checked = true;
            this.checkBox_salad.Checked = true;
            this.checkBox_tomato.Checked = true;
            this.checkBox_onion.Checked = true;
            this.checkBox_pickies.Checked = true;
            this.checkBox_bell_pepper.Checked = true;
        } //рецепт сырной

        private void radioButton_main_bbq_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButton_lavash.Checked = true;
            this.radioButton_chiken.Checked = true;
            this.radioButton_s_bbq.Checked = true;
            this.checkBox_cucumber.Checked = true;
            this.checkBox_salad.Checked = true;
            this.checkBox_tomato.Checked = true;
            this.checkBox_onion.Checked = false;
            this.checkBox_pickies.Checked = false;
            this.checkBox_bell_pepper.Checked = true;
            this.checkBox_jalapenos.Checked = true;
        } //рецепт bbq

        private void radioButton_main_no_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButton_lavash.Checked = true; //по умолчанию лаваш
            this.radioButton_chiken.Checked = true; //по умолчанию курица
            this.radioButton_s_classic.Checked = true; //по умолчанию класический соус
            this.radioButton_s_middel.Checked = true; //по умолчанию нормальная осттрата
            this.checkBox_cucumber.Checked = false;
            this.checkBox_salad.Checked = false;
            this.checkBox_tomato.Checked = false;
            this.checkBox_onion.Checked = false;
            this.checkBox_pickies.Checked = false;
            this.checkBox_bell_pepper.Checked = false;
            this.checkBox_jalapenos.Checked = false;
        } //сам с усами
    }
}
