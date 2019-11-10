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
        int a;
        public Form1()
        {
            InitializeComponent();
            this.radioButton_lavash.Checked = true; //по умолчанию лаваш
            this.radioButton_chiken.Checked = true; //по умолчанию курица
            this.radioButton_s_classic.Checked = true; //по умолчанию класический соус
            this.radioButton_s_middel.Checked = true; //по умолчанию нормальная осттрата

        }

        // double summ = 0; //стоимость шамвермы *ИЗМЕНИНА* -> Глобальная переменная: Data.Summ
        //int Data.Ost = 0; //шкала остроты (счётчик) *ИЗМЕНИНА* -> Глобальная переменная: Data.Data.Ost
        int b, c, d, f, g, h, p, k, l;
        
        //выбор основы
        private void radioButton_lavash_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_lavash.Checked == true)
            {
                Data.Summ = Data.Summ + 30;
                Data.Calories = Data.Calories + 20;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_lavash.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 30;
                Data.Calories = Data.Calories - 20;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_lavash.Visible = false;
            }
        } //лаваш
        private void radioButton_pita_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_pita.Checked == true)
            {
                Data.Summ = Data.Summ + 15;
                Data.Calories = Data.Calories + 25;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_pita.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 15;
                Data.Calories = Data.Calories - 25;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_pita.Visible = false;
            }
        } //пита
        private void radioButton_tarelka_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_lavash.Checked == true)
            {
                Data.Summ = Data.Summ + 50;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_tarelka.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 50;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_tarelka.Visible = false;
            }
        } //тарелка

        //выбор мяса
        private void radioButton_chiken_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_chiken.Checked == true)
            {
                Data.Summ = Data.Summ + 30;
                Data.Calories = Data.Calories + 200;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_chiken.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 30;
                Data.Calories = Data.Calories - 200;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_chiken.Visible = false;
            }
        } //курица
        private void radioButton_pork_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_pork.Checked == true)
            {
                Data.Summ = Data.Summ + 15;
                Data.Calories = Data.Calories + 220;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_mutton.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 15;
                Data.Calories = Data.Calories - 220;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_mutton.Visible = false;
            }
        } //говядина
        private void radioButton_mutton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_mutton.Checked == true)
            {
                Data.Summ = Data.Summ + 40;
                Data.Calories = Data.Calories + 210;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_pork.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 40;
                Data.Calories = Data.Calories - 210;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_pork.Visible = false;
            }
        } //свинина

        //выбор соуса
        private void radioButton_s_classic_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_classic.Checked == true)
            {
                Data.Summ = Data.Summ + 25;
                Data.Calories = Data.Calories + 20;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_classic.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 25;
                Data.Calories = Data.Calories - 20;
                this.pictureBox_classic.Visible = false;
                this.label3.Text = $"{Data.Summ} руб.";
            }
        } //классический
        private void radioButton_s_cheesy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_cheesy.Checked == true)
            {
                Data.Summ = Data.Summ + 30;
                Data.Calories = Data.Calories + 25;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox1_cheesy.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 30;
                Data.Calories = Data.Calories - 25;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox1_cheesy.Visible = false;
            }
        } //сырный
        private void radioButton_s_bbq_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_bbq.Checked == true)
            {
                Data.Summ = Data.Summ + 35;
                Data.Calories = Data.Calories + 25;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_bbq.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 35;
                Data.Calories = Data.Calories - 25;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_bbq.Visible = false;
            }
        } //bbq
        private void radioButton_s_adjeka_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_adjeka.Checked == true)
            {
                Data.Summ = Data.Summ + 40;
                Data.Calories = Data.Calories + 25;
                this.groupBox_s_conf.Visible = true;
                this.pictureBox_adjika.Visible = true;
                this.label3.Text = $"{Data.Summ} руб.";
            }
            else
            {
                Data.Summ = Data.Summ - 40;
                Data.Calories = Data.Calories - 25;
                this.groupBox_s_conf.Visible = false;
                this.pictureBox_adjika.Visible = false;
                this.label3.Text = $"{Data.Summ} руб.";
            }
        } //аджика
        private void radioButton_s_1000island_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_1000island.Checked == true)
            {
                Data.Summ = Data.Summ + 35;
                Data.Calories = Data.Calories + 20;
                this.pictureBox_1000island.Visible = true;
                this.label3.Text = $"{Data.Summ} руб.";
            }
            else
            {
                Data.Summ = Data.Summ - 35;
                Data.Calories = Data.Calories - 20;
                this.pictureBox_1000island.Visible = false;
                this.label3.Text = $"{Data.Summ} руб.";
            }
        } //1000 островов
        private void radioButton_s_acute_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_acute.Checked == true)
            {
                Data.Summ = Data.Summ + 40;
                Data.Calories = Data.Calories + 25;
                this.groupBox_s_conf.Visible = true;
                this.pictureBox_super.Visible = true;
                this.label3.Text = $"{Data.Summ} руб.";
            }
            else
            {
                Data.Summ = Data.Summ - 30;
                Data.Calories = Data.Calories - 25;
                this.groupBox_s_conf.Visible = false;
                this.pictureBox_super.Visible = false;
                this.label3.Text = $"{Data.Summ} руб.";
            }
        } //острый

        //тут будет выбор колличества допинга
        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            a = (int)this.numericUpDown1.Value;
            this.label_cucumber.Text = $"x{Convert.ToString((int)this.numericUpDown1.Value)}";
           
        } //огурцы
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            b = (int)this.numericUpDown2.Value;
            this.label_pickies.Text = $"x{Convert.ToString((int)this.numericUpDown2.Value)}";
        } //маринованые огурцы
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            c = (int)this.numericUpDown3.Value;
            this.label_tomatos.Text = $"x{Convert.ToString((int)this.numericUpDown3.Value)}";
        } //помидоры
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            d = (int)this.numericUpDown4.Value;
            this.label_sauerkraut.Text = $"x{Convert.ToString((int)this.numericUpDown4.Value)}";
        } //квашеная капуста
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            f = (int)this.numericUpDown5.Value;
            this.label_carrot.Text = $"x{Convert.ToString((int)this.numericUpDown5.Value)}";
        } //марковка 
        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            g = (int)this.numericUpDown6.Value;
            this.label_jalapenos.Text = $"x{Convert.ToString((int)this.numericUpDown6.Value)}";
        } //халапенью
        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            h = (int)this.numericUpDown7.Value;
            this.label_salad.Text = $"x{Convert.ToString((int)this.numericUpDown7.Value)}";
        } //салатный лист
        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            p = (int)this.numericUpDown8.Value;
            this.label_pepper.Text = $"x{Convert.ToString((int)this.numericUpDown8.Value)}";
        } //болгарский перец
        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            k = (int)this.numericUpDown9.Value;
            this.label_dill.Text = $"x{Convert.ToString((int)this.numericUpDown9.Value)}";
        } //укроп
        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            l = (int)this.numericUpDown10.Value;
            this.label_onion.Text = $"x{Convert.ToString((int)this.numericUpDown10.Value)}";
        } //лук

        //допинги
        public void checkBox_cucumber_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cucumber.Checked == true)
             {
                 this.numericUpDown1.Visible = true;
                 this.label_cucumber.Visible = true;
                 this.pictureBox_cucumber.Visible = true;                
                //this.label5.Text = Convert.ToString(a);
                 Data.Summ = Data.Summ + (30 * a);
                Data.Calories = Data.Calories + 30;
                this.label3.Text = $"{Data.Summ} руб.";
             }
             else
             {                
                 this.numericUpDown1.Visible = false;
                 this.label_cucumber.Visible = false;
                 Data.Summ = Data.Summ - (30 * a);
                Data.Calories = Data.Calories - 30;
                this.label3.Text = $"{Data.Summ} руб.";
                 this.pictureBox_cucumber.Visible = false;
             } 
        } //огурцы 
        private void checkBox_pickies_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pickies.Checked == true)
            {
                Data.Summ = Data.Summ + 30;
                Data.Calories = Data.Calories + 30;
                this.numericUpDown2.Visible = true;
                this.label_pickies.Visible = true;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_pickies.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 30;
                Data.Calories = Data.Calories - 30;
                this.numericUpDown2.Visible = false;
                this.label_pickies.Visible = false;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_pickies.Visible = false;
            }
        } //маринованый огурцы
        private void checkBox_tomato_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_tomato.Checked == true)
            {
                Data.Summ = Data.Summ + 30;
                Data.Calories = Data.Calories + 30;
                this.numericUpDown3.Visible = true;
                this.label_tomatos.Visible = true;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_tomato.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 30;
                Data.Calories = Data.Calories - 30;
                this.numericUpDown3.Visible = false;
                this.label_tomatos.Visible = false;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_tomato.Visible = false;
            }
        } //помидоры
        private void checkBox_sauerkraut_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sauerkraut.Checked == true)
            {
                Data.Summ = Data.Summ + 35;
                Data.Calories = Data.Calories + 30;
                this.numericUpDown4.Visible = true;
                this.label_sauerkraut.Visible = true;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_sauerkraut.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 35;
                Data.Calories = Data.Calories - 30;
                this.numericUpDown4.Visible = false;
                this.label_sauerkraut.Visible = false;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_sauerkraut.Visible = false;
            }
        } //квашеная капуста
        private void checkBox_carrot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_carrot.Checked == true)
            {
                Data.Summ = Data.Summ + 30;
                Data.Calories = Data.Calories + 30;
                this.numericUpDown5.Visible = true;
                this.label_carrot.Visible = true;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_carrot.Visible = true; 
            }
            else
            {
                Data.Summ = Data.Summ - 30;
                Data.Calories = Data.Calories - 30;
                this.numericUpDown5.Visible = false;
                this.label_carrot.Visible = false;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_carrot.Visible = false;
            }
        } //марковка
        private void checkBox_jalapenos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_jalapenos.Checked == true)
            {
                Data.Summ = Data.Summ + 35;
                Data.Calories = Data.Calories + 30;
                this.numericUpDown6.Visible = true;
                this.label_jalapenos.Visible = true;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_jalapenos.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 35;
                Data.Calories = Data.Calories - 30;
                this.numericUpDown6.Visible = false;
                this.label_jalapenos.Visible = false;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_jalapenos.Visible = false;
            }
        } //халопенью
        private void checkBox_salad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_salad.Checked == true)
            {
                Data.Summ = Data.Summ + 25;
                Data.Calories = Data.Calories + 30;
                this.numericUpDown7.Visible = true;
                this.label_salad.Visible = true;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_salad.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 25;
                Data.Calories = Data.Calories - 30;
                this.numericUpDown7.Visible = false;
                this.label_salad.Visible = false;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_salad.Visible = false;
            }
        } //салатный лист
        private void checkBox_bell_pepper_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_bell_pepper.Checked == true)
            {
                Data.Summ = Data.Summ + 35;
                Data.Calories = Data.Calories + 30;
                this.numericUpDown8.Visible = true;
                this.label_pepper.Visible = true;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_pepper.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 35;
                Data.Calories = Data.Calories - 30;
                this.numericUpDown8.Visible = false;
                this.label_pepper.Visible = false;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_pepper.Visible = false;
            }

        } //болгарский перец
        private void checkBox_dill_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dill.Checked == true)
            {                
                this.numericUpDown9.Visible = true;
                this.label_dill.Visible = true;
                Data.Summ = Data.Summ + 25;
                Data.Calories = Data.Calories + 30;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_dill.Visible = true;
            }
            else
            {
                this.numericUpDown9.Visible = false;
                this.label_dill.Visible = false;
                Data.Summ = Data.Summ - 25;
                Data.Calories = Data.Calories - 30;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_dill.Visible = false;
            }
        } //укроп
        private void checkBox_onion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_onion.Checked == true)
            {
                Data.Summ = Data.Summ + 25;
                Data.Calories = Data.Calories + 30;
                this.numericUpDown10.Visible = true;
                this.label_onion.Visible = true;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_onion.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 25;
                Data.Calories = Data.Calories - 30;
                this.numericUpDown10.Visible = false;
                this.label_onion.Visible = false;
                this.label3.Text = $"{Data.Summ} руб.";
                this.pictureBox_onion.Visible = false;
            }
        } //лук

        //острота соуса
        private void radioButton_s_min_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_min.Checked == true)
            {
                Data.Summ = Data.Summ + 5;
                Data.Ost++;
                this.label3.Text = $"{Data.Summ} руб.";
            }
            else
            {
                Data.Summ = Data.Summ - 5;
                Data.Ost--;
                this.label3.Text = $"{Data.Summ} руб.";
            }
        } //слабо
        private void radioButton_s_middel_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_middel.Checked == true)
            {
                Data.Summ = Data.Summ + 10;
                Data.Ost = Data.Ost + 2;
                this.label3.Text = $"{Data.Summ} руб.";
            }
            else
            {
                Data.Summ = Data.Summ - 10;
                Data.Ost = Data.Ost - 2;
                this.label3.Text = $"{Data.Summ} руб.";
            }         
        } //нормально
        private void radioButton_s_high_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_high.Checked == true)
            {
                Data.Summ = Data.Summ + 15;
                Data.Ost = Data.Ost + 3;
                this.label3.Text = $"{Data.Summ} руб.";
            }
            else
            {
                Data.Summ = Data.Summ - 15;
                Data.Ost = Data.Ost - 3;
                this.label3.Text = $"{Data.Summ} руб.";
            }            
        } //сильно
        private void radioButton_s_super_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_s_super.Checked == true)
            {
                Data.Summ = Data.Summ + 20;
                Data.Ost = Data.Ost + 4;
                this.label3.Text = $"{Data.Summ} руб.";
            }
            else
            {
                Data.Summ = Data.Summ - 20;
                Data.Ost = Data.Ost + 4;
                this.label3.Text = $"{Data.Summ} руб.";
            }          
        } //огненно

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
            this.checkBox_carrot.Checked = false;
            this.checkBox_dill.Checked = false;
            this.checkBox_sauerkraut.Checked = false;
        } //сам с усами

        //кнопка СОБРАТЬ
        private void button1_Click(object sender, EventArgs e)
        {
            //убираем основу
            this.pictureBox_pita.Visible = false;
            this.pictureBox_lavash.Visible = false;
            this.pictureBox_tarelka.Visible = false;
            //убираем мясо
            this.pictureBox_chiken.Visible = false;
            this.pictureBox_pork.Visible = false;
            this.pictureBox_mutton.Visible = false;
            //убиарем соуса
            this.pictureBox1_cheesy.Visible = false;
            this.pictureBox_bbq.Visible = false;
            this.pictureBox_1000island.Visible = false;
            this.pictureBox_classic.Visible = false;
            this.pictureBox_super.Visible = false;
            this.pictureBox_adjika.Visible = false;
            //убираем все допинги
            this.pictureBox_cucumber.Visible = false;
            this.pictureBox_bbq.Visible = false;
            this.pictureBox_pickies.Visible = false;
            this.pictureBox_tomato.Visible = false;
            this.pictureBox_sauerkraut.Visible = false;
            this.pictureBox_carrot.Visible = false;
            this.pictureBox_jalapenos.Visible = false;
            this.pictureBox_salad.Visible = false;
            this.pictureBox_dill.Visible = false;
            this.pictureBox_onion.Visible = false;
            this.pictureBox_pepper.Visible = false;
            this.label_carrot.Visible = false;
            this.label_cucumber.Visible = false;
            this.label_dill.Visible = false;
            this.label_jalapenos.Visible = false;
            this.label_onion.Visible = false;
            this.label_pepper.Visible = false;
            this.label_pickies.Visible = false;
            this.label_salad.Visible = false;
            this.label_sauerkraut.Visible = false;
            this.label_tomatos.Visible = false;

        }

        //тут спрятаны подсказки
        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(radioButton_lavash, "Свежий, хрустящий лаваш");
            t.SetToolTip(radioButton_pita, "Вкусаная, магкая, пита блитсящая");
            t.SetToolTip(radioButton_tarelka, "Тарелка, только для самых богатых");

            t.SetToolTip(radioButton_chiken, "Ко-ко-ко");
            t.SetToolTip(radioButton_pork, "Хрю-Хрю-Хрю");
            t.SetToolTip(radioButton_mutton, "Свежий, молочнй поросёнок");

            t.SetToolTip(radioButton_s_classic, "Классический, чесночно-сливочный соус, самое то!");
            t.SetToolTip(radioButton_s_cheesy, "Мощныйший сырный соус, идеально подходит для любителей сыра");
            t.SetToolTip(radioButton_s_bbq, "Соус барбекю, идеально подходит к свинине");
            t.SetToolTip(radioButton_s_adjeka, "Домашняя, выдерженная острая аджика, идеально дополнит любое блюдо");
            t.SetToolTip(radioButton_s_1000island, "Пикантный соус 1000 островов, для любителей лёгкой заправки");
            t.SetToolTip(radioButton_s_acute, "Для любителей острой кухни!");
            t.SetToolTip(radioButton_s_no, "Ну и странный Вы человек!");

            t.SetToolTip(radioButton_s_min, "Чуть-чуть пощекочет Ваш язык");
            t.SetToolTip(radioButton_s_middel, "Самое то если хочеться чего-нибдь остренького");
            t.SetToolTip(radioButton_s_high, "Будет остро, но терпимо. Рекомендую!");
            t.SetToolTip(radioButton_s_super, "Яркое пламя, пронзит Ваш язык. Возьмите еще молоко!");

            t.SetToolTip(checkBox_cucumber, "Огурцы с нашей грядки, только свежие и вкусные");
            t.SetToolTip(checkBox_pickies, "Мариновыные огурчики, изящно поддчеркнут вкус Вашего блюда");
            t.SetToolTip(checkBox_tomato, "Помидорка добавит сочности к шаверме и непердоваемый вкус");
            t.SetToolTip(checkBox_sauerkraut, "Бабушкина, квашеная капуста, ни кого не оставен равнодушним");
            t.SetToolTip(checkBox_carrot, "Оранжевая марковка, никогда не будет лишней!");
            t.SetToolTip(checkBox_jalapenos, "Халапенью, добавит капельку остроты в Ваше блюдо");
            t.SetToolTip(checkBox_salad, "Без него просто ни куда!");
            t.SetToolTip(checkBox_dill, "Просто вкусно");
            t.SetToolTip(checkBox_onion, "Вкусее, только с луком!");

            t.SetToolTip(radioButton_main_classic, "Лаваш, курица, класический соус, огурцы, салатный лист, помидоры, лук, маринованые огурчики");
            t.SetToolTip(radioButton_main_bbq, "Лаваш, курица, соус BBQ, огурцы, салат, помидоры, лук, маринованый огурцы, болгарский перец, халапенью");
            t.SetToolTip(radioButton_main_cheesy, "Лаваш, курица, сырный соус, огурцы, салат, помидоры, лук, мариновыный огурчики, болгарский перец");
            t.SetToolTip(radioButton_main_no, "Сам себе барин");
        }
    }
}
