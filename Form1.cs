using System;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int sega_i = 1;
        private int segb_i = 1;
        private int segc_i = 1;
        private int segd_i = 1;
        private int sege_i = 1;
        private int segf_i = 1;
        private int segg_i = 1;
        private int segdp_i = 1;
        private int sega_flag = 0;
        private int segb_flag = 0;
        private int segc_flag = 0;
        private int segd_flag = 0;
        private int sege_flag = 0;
        private int segf_flag = 0;
        private int segg_flag = 0;
        private int segdp_flag = 0;
        private double Result = 0;

        private int My_text = 0;


        private void seg_a_Click(object sender, EventArgs e)
        {
            sega_i ++;

            if (sega_i % 2 == 0)
            {
                seg_a.Image = Resources.seg_red;
                sega_flag = 1;
                this.text_a.Text = "1";
            }
            else
            {
                seg_a.Image = Resources.seg_blue;
                sega_flag = 0;
                this.text_a.Text = "0";
            }

            if (sega_i > 2) sega_i = 1;

        }

        private void seg_b_Click(object sender, EventArgs e)
        {
            segb_i++;

            if (segb_i % 2 == 0)
            {
                seg_b.Image = Resources.seg_red;
                segb_flag = 1;
                this.text_b.Text = "1";
            }
            else
            {
                seg_b.Image = Resources.seg_blue;
                segb_flag = 0;
                this.text_b.Text = "0";
            }
            if (segb_i > 2) segb_i = 1;
        }

        private void seg_c_Click(object sender, EventArgs e)
        {
            segc_i++;

            if (segc_i % 2 == 0)
            {
                seg_c.Image = Resources.seg_red;
                segc_flag = 1;
                this.text_c.Text = "1";
            }
            else
            {
                seg_c.Image = Resources.seg_blue;
                segc_flag = 0;
                this.text_c.Text = "0";
            }

            if (segc_i > 2) segc_i = 1;
        }

        private void seg_d_Click(object sender, EventArgs e)
        {
            segd_i++;

            if (segd_i % 2 == 0)
            {
                seg_d.Image = Resources.seg_red;
                segd_flag = 1;
                this.text_d.Text = "1";
            }
            else
            {
                seg_d.Image = Resources.seg_blue;
                segd_flag = 0;
                this.text_d.Text = "0";
            }

            if (segd_i > 2) segd_i = 1;
        }

        private void seg_e_Click(object sender, EventArgs e)
        {
            sege_i++;

            if (sege_i % 2 == 0)
            {
                seg_e.Image = Resources.seg_red;
                sege_flag = 1;
                this.text_e.Text = "1";
            }
            else
            {
                seg_e.Image = Resources.seg_blue;
                sege_flag = 0;
                this.text_e.Text = "0";
            }

            if (sege_i > 2) sege_i = 1;
        }

        private void seg_f_Click(object sender, EventArgs e)
        {
            segf_i++;

            if (segf_i % 2 == 0)
            {
                seg_f.Image = Resources.seg_red;
                segf_flag = 1;
                this.text_f.Text = "1";
            }
            else
            {
                seg_f.Image = Resources.seg_blue;
                segf_flag = 0;
                this.text_f.Text = "0";
            }

            if (segf_i > 2) segf_i = 1;
        }

        private void seg_g_Click(object sender, EventArgs e)
        {
            segg_i++;

            if (segg_i % 2 == 0)
            {
                seg_g.Image = Resources.seg_red;
                segg_flag = 1;
                this.text_g.Text = "1";
            }
            else
            {
                seg_g.Image = Resources.seg_blue;
                segg_flag = 0; 
                this.text_g.Text = "0";
            }

            if (segg_i > 2) segg_i = 1;
        }

        private void seg_dp_Click(object sender, EventArgs e)
        {
            segdp_i++;

            if (segdp_i % 2 == 0)
            {
                seg_dp.Image = Resources.seg_red;
                segdp_flag = 1;
                this.text_dp.Text = "1";
            }
            else
            {
                seg_dp.Image = Resources.seg_blue;
                segdp_flag = 0;
                this.text_dp.Text = "0";
            }

            if (segdp_i > 2) segdp_i = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Result = sega_flag * Math.Pow(2, 0)
                   + segb_flag * Math.Pow(2, 1)
                   + segc_flag * Math.Pow(2, 2)
                   + segd_flag * Math.Pow(2, 3)
                   + sege_flag * Math.Pow(2, 4)
                   + segf_flag * Math.Pow(2, 5)
                   + segg_flag * Math.Pow(2, 6)
                   + segdp_flag * Math.Pow(2, 7);
            this.text_cc.Text = "0x"+((int)Result).ToString("x2");
            this.text_ca.Text = "0x" + (255 - (int)Result).ToString("x2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seg_a.Image = Resources.seg_blue;
            sega_flag = 0;
            sega_i = 1;

            seg_b.Image = Resources.seg_blue;
            segb_flag = 0;
            segb_i = 1;

            seg_c.Image = Resources.seg_blue;
            segc_flag = 0;
            segc_i = 1;

            seg_d.Image = Resources.seg_blue;
            segd_flag = 0;
            segd_i = 1;

            seg_e.Image = Resources.seg_blue;
            sege_flag = 0;
            sege_i = 1;

            seg_f.Image = Resources.seg_blue;
            segf_flag = 0;
            segf_i = 1;

            seg_g.Image = Resources.seg_blue;
            segg_flag = 0;
            segg_i = 1;

            seg_dp.Image = Resources.seg_blue;
            segdp_flag = 0;
            segdp_i = 1;

            this.text_cc.Text = "";
            this.text_ca.Text = "";
        }

        //每个RadioButton都绑定一个CheckedChanged
        private void rbin_2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbin_2.Checked)
            {
                try
                {
                    My_text = Convert.ToInt32(this.text_in.Text, 2);
                }
                catch
                {
                    MessageBox.Show("system1");
                }
                
                this.text_in.Text = Convert.ToString(My_text);
            }
        }

        private void rbin_8_CheckedChanged(object sender, EventArgs e)
        {
            if (rbin_8.Checked)
            {
                My_text = Convert.ToInt32(this.text_in.Text, 8);
                this.text_in.Text = Convert.ToString(My_text);
            }
        }

        private void rbin_10_CheckedChanged(object sender, EventArgs e)
        {
            if (rbin_10.Checked)
            {
                My_text = Convert.ToInt32(this.text_in.Text, 10);
                this.text_in.Text = Convert.ToString(My_text);
            }
        }

        private void rbin_16_CheckedChanged(object sender, EventArgs e)
        {
            if (rbin_16.Checked)
            {
                My_text = Convert.ToInt32(this.text_in.Text, 16);
                this.text_in.Text = Convert.ToString(My_text);
            }
        }

        private void rbout_2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbout_2.Checked)
            {
                My_text = Convert.ToInt32(this.text_in.Text);
                this.text_out.Text = Convert.ToString(My_text, 2);
            }
        }

        private void rbout_8_CheckedChanged(object sender, EventArgs e)
        {
            if (rbout_8.Checked)
            {
                My_text = Convert.ToInt32(this.text_in.Text);
                this.text_out.Text = Convert.ToString(My_text, 8);
            }
        }

        private void rbout_10_CheckedChanged(object sender, EventArgs e)
        {
            if (rbout_10.Checked)
            {
                My_text = Convert.ToInt32(this.text_in.Text);
                this.text_out.Text = Convert.ToString(My_text, 10);
            }
        }

        private void rbout_16_CheckedChanged(object sender, EventArgs e)
        {
            if (rbout_16.Checked)
            {
                My_text = Convert.ToInt32(this.text_in.Text);
                this.text_out.Text = Convert.ToString(My_text, 16);
            }
        }
    }
}